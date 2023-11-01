namespace UI_Ragor_Pages.Model
{
    using System.Data;
    using System.Data.SqlTypes;
    using Microsoft.Data.SqlClient;
    public class GetNorthwindCategories
    {
       public List<string> colName = new List<string>();
       public List<object> obj = new List<object>();

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
                                Class1 test = new Class1();
                                test.CategoryName = reader.GetName(0);
                                test.Description = reader.GetName(1);
                                test.image = reader.GetName(2);
                                colName.Add(reader.GetName(i));
                            }
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    //db null
                                    if (reader[i] == DBNull.Value || reader[i].ToString() == "")
                                    {
                                        obj.Add("N/A;");
                                    }
                                    else
                                    {
                                        obj.Add(reader[i]);

                                    }
                                }
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
