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

        // GET BALANCE BY UID
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

        // GET BALANCE BY USERNAME
        public Person GetBalanceByUsername(string Username)
        {
            Person result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Person where Username = @Username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@Username", Username);
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

        //ADD CASH TO BALANCE ACCORDING TO THE UID
        public float AddCashWithUID(int UID, float cash)
        {
            float result = 0;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Person SET Balance=@Balance WHERE UID = @UID";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@UID", UID);
                    result = GetBalanceByUID(UID).Balance + cash;
                    cmd.Parameters.AddWithValue("@Balance", result);

                    cn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        //ADD CASH TO BALANCE ACCORDING TO THE USERNAME
        public float AddCashWithUsername(string Username, float cash)
        {
            float result = 0;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Person SET Balance=@Balance WHERE Username = @Username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    result = GetBalanceByUsername(Username).Balance + cash;
                    cmd.Parameters.AddWithValue("@Balance", result);

                    cn.Open();

                    cmd.ExecuteNonQuery();
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
