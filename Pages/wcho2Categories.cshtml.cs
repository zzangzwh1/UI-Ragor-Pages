using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UI_Ragor_Pages.Model;

namespace UI_Ragor_Pages.Pages
{
    public class wcho2CategoriesModel : PageModel
    {

        public List<string> ColumnNames = new List<string>();
        public List<Category> Categories = new List<Category>();

        public void OnGet()
        {
            var north = new GetNorthwindCategories();
            north.DisplayNortwindCategory();

            ColumnNames = north.colName;

            Categories = north.obj;
        }
    }

}
