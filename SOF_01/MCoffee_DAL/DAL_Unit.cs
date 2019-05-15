using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MCoffee_DTO;
using Untility;

namespace MCoffee_DAL
{
    public class DAL_Unit : DBConnection
    {
        public String nextID()
        {
            String query = "SELECT TOP 1 [ID_UNI] FROM UNIT ORDER BY [ID_UNI] DESC";
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
                        id = reader["ID_UNI"].ToString();
                    String pre = id.Substring(0, 2);
                    String suf = id.Substring(2, id.Length - 2);

                    int num = Int32.Parse(suf);
                    num = num + 1;

                    String strNum = num.ToString();
                    suf = suf.Substring(0, suf.Length - strNum.Length);
                    suf = suf + strNum;

                    id = pre + suf;
                }
                else id = "UN0001";
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

        public Result insert(DTO_Unit unit)
        {
            String query = "INSERT INTO [UNIT] ([ID_UNI], [DISPLAYNAME]) ";
            query += "VALUES (@ID_UNI, @DISPLAYNAME)";
            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_UNI", unit.ID);
            cmmd.Parameters.AddWithValue("@DISPLAYNAME", unit.DISPLAYNAME);
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

        public Result update(DTO_Unit unit)
        {
            String query = "UPDATE [UNIT] ";
            query += "SET [DISPLAYNAME] = @DISPLAYNAME ";
            query += "WHERE [ID_UNI] = @ID_UNI";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_UNI", unit.ID);
            cmmd.Parameters.AddWithValue("@DISPLAYNAME", unit.DISPLAYNAME);          

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

        public Result delete(String id)
        {
            String query = "DELETE FROM [UNIT] ";
            query += "WHERE [ID_UNI] = @ID_UNI";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_UNI", id);
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

        public List<DTO_Unit> SelectAll()
        {
            List<DTO_Unit> listSuplier = new List<DTO_Unit>();
            String query = "SELECT * FROM UNIT";

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
                        listSuplier.Add(new DTO_Unit(reader["ID_UNI"].ToString(),
                            reader["DISPLAYNAME"].ToString()));
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
