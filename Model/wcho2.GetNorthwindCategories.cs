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
                                /*Category c = new Category();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    // CategoryName
                                    if (reader["CategoryName"] != DBNull.Value)
                                    {
                                        c.CategoryName = (string)reader["CategoryName"];

                                    }
                                    // Description
                                    if (reader["Description"] != DBNull.Value)
                                    {
                                        c.Description = (string)reader["Description"];
                                    }

                                    // Image
                                    if (reader["Picture"] != DBNull.Value)
                                    {

                                        byte[] imageData = (byte[])reader["Picture"];
                                        Console.WriteLine($"Image Data Length: {imageData.Length}");
                                      
                                        Console.Write(c.Picture);
                                       c.Picture = Convert.ToBase64String(imageData);

                                    }
*/
                                Category category = new Category();
                                category.CategoryName = (string)reader["CategoryName"];
                                category.Description = (string)reader["Description"];
                                category.Picture = Convert.ToBase64String((byte[])reader["Picture"]);
                                obj.Add(category);

                            }
                                //obj.Add(c);
                            //}

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
