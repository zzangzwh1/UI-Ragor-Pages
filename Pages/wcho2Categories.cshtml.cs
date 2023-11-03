using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UI_Ragor_Pages.Model;

namespace UI_Ragor_Pages.Pages
{
    public class wcho2CategoriesModel : PageModel
    {

        public List<string> ColumnNames = new List<string>();
        public List<Category> Categories = new List<Category>();

        //test
        public List<string> testColumnNames = new List<string>();
        public List<Category> testCategories = new List<Category>();
        public string result = "";
        public string Test = "";
        public string Test2 = "";
        public void OnGet()
        {
            var north = new GetNorthwindCategories();
            north.DisplayNortwindCategory();

            ColumnNames = north.colName;

            Categories = north.obj;

            //Test

            var test = new TestNorthWind();

            test.DisplayNortwindCategory();
            testCategories = test.obj;
            testColumnNames = test.colName;
            for(int i = 0; i <test.obj.Count; i++)
            {
                result = Convert.ToBase64String(test.obj[1].ImageData);
            }
            Test = result.Replace("////", "/");
            Test2 = Test.Replace("//", "/");
        
        }
    
    }

}
