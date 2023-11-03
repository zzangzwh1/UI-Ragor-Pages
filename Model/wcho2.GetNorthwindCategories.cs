namespace UI_Ragor_Pages.Model
{
    using System.Data;
    using System.Data.SqlTypes;
    using Microsoft.Data.SqlClient;
    public class GetNorthwindCategories
    {
        public List<string> colName = new List<string>();
        public List<Category> obj = new List<Category>();

        public void DisplayNortwindCategory()
        {
            string connectionString = @"Persist Security Info= False;  Server=dev1.baist.ca; Database=Northwind; User ID=wcho2;password=Whdnjsgur1! ";
          

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("wcho2.GetNorthwindCategories", conn))
                {
                    try
                    {

                        
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                //Class1 test = new Class1();
                                string categories = reader.GetName(i);
                                colName.Add(categories);
                            }
                            while (reader.Read())
                            {
                               
                                Category category = new Category();
                                category.CategoryName = (string)reader["CategoryName"];
                                category.Description = (string)reader["Description"];


                                byte[] arr = (byte[])reader["Picture"];
                                byte[] arr2 =  new byte[arr.Length-78];

                                Array.Copy(arr, 78, arr2, 0, arr2.Length);

                                category.Picture = Convert.ToBase64String(arr2);

                         
                                obj.Add(category);

                            }
                         

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }
                    finally
                    {
                        conn.Close();
                    }

                }
            }

        }


    }


}
