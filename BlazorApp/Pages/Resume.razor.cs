using Microsoft.AspNetCore.Components;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;
using System.Data;
using BlazorApp.Data;

namespace BlazorApp.Pages
{
    public class ResumeViewModel : ComponentBase
    {
        public string currentHeading = "";
        public DataPage data = new DataPage();

        public bool value { get; set; }
        protected override void OnInitialized()
        {
            pushInfo();
        }

        public void pushInfo()
        {
            

            if (!value)
            {
                value = true;
            }
            else
            {
                value = false;
            }
            using (FileStream fs = new FileStream("DataPage.json", FileMode.OpenOrCreate))
            {
                data = JsonSerializer.Deserialize<DataPage>(fs);
                StateHasChanged();
            }

        }


        public void saveInfo(DataPage data)
        {
            if (!value)
            {
                value = true;
            }
            else
            {
                value = false;
            }
            using (FileStream fs = new FileStream("DataPage.json", FileMode.OpenOrCreate))
            {
                string jsonString = JsonSerializer.Serialize<DataPage>(data);
                byte[] array = Encoding.Default.GetBytes(jsonString);
                fs.WriteAsync(array, 0, array.Length);
                StateHasChanged();
            }
            
        }

        public void cancelInfo()
        {
            value = false;
            
        }



    }

}
