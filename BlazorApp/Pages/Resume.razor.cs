using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{
    public class ResumeViewModel:ComponentBase
    {
        public string currentHeading = "";
        public string? newHeading;
        public bool value;

        public void pushInfo()
        {
            if (!value)
            {
                value = true;
            }
            else
            {
                value= false;
            }
        }
    }
}
