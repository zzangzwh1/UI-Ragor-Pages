using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UI_Ragor_Pages.Model;
using System.Drawing;

namespace UI_Ragor_Pages.Pages
{
    public class wcho2CategoriesModel : PageModel
    {

        public List<string> ColumnNames = new List<string>();
        public List<Category> Categories = new List<Category>();

        //test
        public List<string> testColumnNames = new List<string>();
        public List<Category> testCategories = new List<Category>();
        public List<string> imageResults = new List<string>();

        public string result = "";
        public string Test = "";
        public string Test2 = "";
        public byte[] imageData = null;
      
        public void OnGet()
        {
          
            var getCategories = new GetNorthwindCategories();
            getCategories.DisplayNortwindCategory();

            ColumnNames = getCategories.colName;

            Categories = getCategories.obj;

            //Test

            var test = new TestNorthWind();

            test.DisplayNortwindCategory();
            testCategories = test.obj;
            testColumnNames = test.colName;

            byte[] arr = null;
            for(int i = 0; i <test.obj.Count; i++)
            {
                Console.Write(test.obj[2].ImageData);
                Console.WriteLine();
                result = Convert.ToHexString(test.obj[2].ImageData);
                Console.Write(result);
              
            }
            //test 2

           

        }

  
    }

}
