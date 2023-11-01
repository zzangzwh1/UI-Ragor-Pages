using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace UI_Ragor_Pages.Pages
{
    public class usernameSignOnModel : PageModel
    {
        public string Message { get; set; } = string.Empty;

        [BindProperty]
        [Required]

        [RegularExpression(@"[a-zA-Z][a-zA-Z][a-zA-Z][a-zA-Z][0-9][0-9][0-9][0-9]", ErrorMessage = "User ID, 4 letters followed by 4 digits (e.g. BAIS9999)")]
        public string UserID { get; set; } = string.Empty;

        [BindProperty]
        [Required]
        [RegularExpression(@"^.{6,}$", ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; } = string.Empty;
        public void OnGet()
        {
            Message = "";
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
