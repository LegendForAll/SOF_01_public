using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCoffee_DTO;
using System.Data.SqlClient;
using Untility;

namespace MCoffee_DAL
{
    public class DAL_Suplier : DBConnection
    {
        public String nextID()
        {
            String query = "SELECT TOP 1 [ID_SUP] FROM SUPLIER ORDER BY [ID_SUP] DESC";
            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;

            String id = String.Empty;
            try
            {
                conn.Open();
                SqlDataReader reader;
                reader = cmmd.ExecuteReader();

                if (reader.HasRows == true)
                {
                    while (reader.Read())
                        id = reader["ID_SUP"].ToString();
                    String pre = id.Substring(0, 2);
                    String suf = id.Substring(2, id.Length - 2);

                    int num = Int32.Parse(suf);
                    num = num + 1;

                    String strNum = num.ToString();
                    suf = suf.Substring(0, suf.Length - strNum.Length);
                    suf = suf + strNum;

                    id = pre + suf;
                }
                else id = "SU0001";
            }
            catch (Exception e)
            {
                conn.Close();
                System.Console.WriteLine(e.Message);
                return "xxxxxxxxxxxxxx";
            }

            conn.Close();
            return id;
        }

        public Result insert(DTO_Suplier suplier)
        {
            String query = "INSERT INTO [SUPLIER] ([ID_SUP], [DISPLAYNAME], [ADDRESS], [PHONENUMBER], [CONTRACTDATE]) ";
            query += "VALUES (@ID_SUP, @DISPLAYNAME, @ADDRESS, @PHONENUMBER, @CONTRACTDATE)";
            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_SUP", suplier.ID);
            cmmd.Parameters.AddWithValue("@DISPLAYNAME", suplier.DISPLAYNAME);
            cmmd.Parameters.AddWithValue("@ADDRESS", suplier.ADDRESS);
            cmmd.Parameters.AddWithValue("@PHONENUMBER", suplier.PHONENUMBER);
            cmmd.Parameters.AddWithValue("@CONTRACTDATE", suplier.CONTRACTDATE);

            try
            {
                conn.Open();
                cmmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                conn.Close();
                System.Console.WriteLine(e.Message);
                return new Result(false, e.Message);
            }
            conn.Close();
            return new Result(true);
        }

        public Result update(DTO_Suplier suplier)
        {
            String query = "UPDATE [SUPLIER] ";
            query += "SET [DISPLAYNAME] = @DISPLAYNAME, [ADDRESS] = @ADDRESS, [PHONENUMBER] = @PHONENUMBER, [CONTRACTDATE] = @CONTRACTDATE ";
            query += "WHERE [ID_SUP] = @ID_SUP";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_SUP", suplier.ID);
            cmmd.Parameters.AddWithValue("@DISPLAYNAME", suplier.DISPLAYNAME);
            cmmd.Parameters.AddWithValue("@ADDRESS", suplier.ADDRESS);
            cmmd.Parameters.AddWithValue("@PHONENUMBER", suplier.PHONENUMBER);
            cmmd.Parameters.AddWithValue("@CONTRACTDATE", suplier.CONTRACTDATE);

            try
            {
                conn.Open();
                cmmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                conn.Close();
                System.Console.WriteLine(e.Message);
                return new Result(false, e.Message);    
            }
            conn.Close();
            return new Result(true);
        }

        public Result delete (String id)
        {
            String query = "DELETE FROM [SUPLIER] ";
            query += "WHERE [ID_SUP] = @ID_SUP";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_SUP", id);
            try
            {
                conn.Open();
                cmmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                conn.Close();
                System.Console.WriteLine(e.Message);
                return new Result(false, e.Message);
            }

            conn.Close();
            return new Result(true);
        }

        public List<DTO_Suplier> SelectAll()
        {
            List<DTO_Suplier> listSuplier = new List<DTO_Suplier>();
            String query = "SELECT * FROM SUPLIER";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;

            try
            {
                conn.Open();
                SqlDataReader reader;
                reader = cmmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        listSuplier.Add(new DTO_Suplier(reader["ID_SUP"].ToString(),
                            reader["DISPLAYNAME"].ToString(),
                            reader["ADDRESS"].ToString(),
                            reader["PHONENUMBER"].ToString(),
                            (DateTime)reader["CONTRACTDATE"]));
                    }
                }
            }
            catch (Exception e)
            {
                conn.Close();
                System.Console.WriteLine(e.Message);
                return null;
            }

            conn.Close();
            return listSuplier;
        }
    }
}
