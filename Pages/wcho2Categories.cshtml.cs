using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UI_Ragor_Pages.Model;
using UI_Ragor_Pages.TechService;

namespace UI_Ragor_Pages.Pages
{
    public class wcho2CategoriesModel : PageModel
    {

        public List<string> ColumnNames = new List<string>();
        public List<Category> Categories = new List<Category>();
        public void OnGet()
        {

            var getCategories = new GetNorthwindCategories();
            getCategories.DisplayNortwindCategory();
            ColumnNames = getCategories.colName;
            Categories = getCategories.obj;



        }


    }

}
