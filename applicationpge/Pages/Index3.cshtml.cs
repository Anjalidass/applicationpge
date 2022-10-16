using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace applicationpge.Pages
{
    public class Index3Model : PageModel
    {

        public bool hasData = false;
        public string firstname = "";
        public string lastname = "";
        public string message = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            hasData = true;
            firstname = Request.Form["firstname"];
            lastname = Request.Form["lastname"];
            message = Request.Form["subject"];
        }
    }
}
