using DevEdu.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace DevEdu.Data.Storages
{
    public class CourseStorage
    {
        private const string connectionString = @"Data Source=185.26.112.224;Initial Catalog=DevEducation;User ID=dev;Password=********;";

        public List<ThemeDetails> GetThemeDeatails()
        {
            SqlConnection newc = new SqlConnection();
            List<ThemeDetails> res = new List<ThemeDetails>();
            string sqlExpression = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ThemeDetails themeDetail = new ThemeDetails() { Id = reader.GetInt32(0), Topic = reader.GetString(2) };
                                res.Add(themeDetail);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex);
                }

            }
            return res;
        }
    }
}
