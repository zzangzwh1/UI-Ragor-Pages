using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace UI_Ragor_Pages.Pages
{
    public class usernameStudentModel : PageModel
    {
         public string? Message { get; set; }
        public void OnGet()
        {
            Message = " ** On Get ***";
        }
        public void OnPost() 
        {
            if (ModelState.IsValid)
            {
                Message = " ***  Valid ***";
            }
            else
            {
                Message = "** Not Valid ** ";
            }


        }
    }
}
