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
            connectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;
        }

        public Person GetUsernameByUID(int UID)
        {
            Person result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Person where UID = @UID";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@UID", UID);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = new Person();
                          
                            result.UID = (int)dr["UID"];
                            result.Username = (string)dr["Username"];
                            result.Balance = (float)dr["Balance"];
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

        public Person GetBalanceByUID(int UID)
        {
            Person result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Person where UID = @UID";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@UID", UID);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = new Person();

                            result.UID = (int)dr["UID"];
                            result.Username = (string)dr["Username"];
                            result.Balance = (float)dr["Balance"];
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
