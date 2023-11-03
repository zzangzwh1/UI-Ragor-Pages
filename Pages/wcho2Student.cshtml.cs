using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace UI_Ragor_Pages.Pages
{
    public class usernameStudentModel : PageModel
    {
        public string? Message { get; set; }

        [BindProperty]
        public string firstName { get; set; } = string.Empty;
        [BindProperty]
        public string lastName { get; set; } = string.Empty;

        [BindProperty]
        public string email { get; set; } = string.Empty;

        [BindProperty]
        public string userId { get; set; } = string.Empty;

        [BindProperty]
        public string password { get; set; } = string.Empty;
        [BindProperty]
        public string cPassword { get; set; } = string.Empty;

        public void OnGet()
        {           

            Message = " ** Please fill in Data in the input Field ***";
        }
        public void OnPost()
        {

            string emailPattern = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$";
            string userIdPattern = "^[a-zA-Z]{4}\\d{4}$";

            Regex emailRegex = new Regex(emailPattern);
            Regex userIdRegex = new Regex(userIdPattern);
          

            if (firstName == null || firstName.Length == 0)
                ModelState.AddModelError("firstName", "firstName is reuqired");

            if (lastName == null || lastName.Length == 0)
                ModelState.AddModelError("lastName", "lastName is reuqired");

            if (email == null || email.Length == 0 || !emailRegex.IsMatch(email))
            {
                ModelState.AddModelError("email", "Eamil is reuqired or invalid Format : ex)wcho2@nait.ca");

            }         
            if (userId == null || userId.Length == 0 || !userIdRegex.IsMatch(userId))
            {
                ModelState.AddModelError("userId", "User ID is reuqired and invalid user ID Format :  ex)abcd1234");
            }
         

            if (password == null || password.Length < 5)
            {
                ModelState.AddModelError("password", "password is reuqired and Mininum length :6");
            }

            if (cPassword == null)
            {
                ModelState.AddModelError("cPassword", "cPassword is reuqired");
            }
            if (password != cPassword)
            {
                ModelState.AddModelError("cPassword", "Password is not matching!");
            }



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
