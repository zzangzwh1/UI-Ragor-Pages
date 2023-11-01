using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UI_Ragor_Pages.Model;

namespace UI_Ragor_Pages.Pages
{
    public class wcho2CategoriesModel : PageModel
    {
        public List<string> ColumnNames { get; set; }

        public Class1 cc= new Class1();
        public List<List<object>> Data { get; set; }
        public void OnGet()
        {
            var north = new GetNorthwindCategories();
            north.DisplayNortwindCategory();

            ColumnNames = north.colName;
            
            Data = new List<List<object>> { north.obj };
        }
    }
}
