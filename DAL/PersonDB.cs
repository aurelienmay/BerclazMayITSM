using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonDB : IPersonDB
    {
        private string connectionString = null;
        public PersonDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DemoDB"].ConnectionString;
        }

        public Person GetPersonById(int id)
        {
            Person result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Person where IdPerson = @id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = new Person();
                          
                            result.Id = (int)dr["IdPerson"];
                            result.FirstName = (string)dr["FirstName"];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }
    }
}
