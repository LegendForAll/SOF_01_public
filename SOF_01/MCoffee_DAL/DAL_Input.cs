using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCoffee_DTO;
using Untility;
using System.Data.SqlClient;


namespace MCoffee_DAL
{
    public class DAL_Input : DBConnection
    {
        public String nextID()
        {
            String query = "SELECT TOP 1 [ID_INP] FROM INPUT ORDER BY [ID_INP] DESC";
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
                        id = reader["ID_INP"].ToString();
                    String pre = id.Substring(0, 2);
                    String suf = id.Substring(2, id.Length - 2); 

                    int num = Int32.Parse(suf);
                    num = num + 1; 

                    String strNum = num.ToString();
                    suf = suf.Substring(0, suf.Length - strNum.Length);
                    suf = suf + strNum;

                    id = pre + suf;
                }
                else id = "IP0001";
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

        public Result insert(DTO_Input input)
        {
            String query = "INSERT INTO [INPUT] ([ID_INP], [DATEINPUT]) ";
            query += "VALUES (@ID_INP, @DATEINPUT)";
            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_INP", input.ID);
            cmmd.Parameters.AddWithValue("@DATEINPUT", input.DATEINPUT);            

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

        public Result update(DTO_Input input)
        {
            String query = "UPDATE [INPUT] ";
            query += "SET [DATEINPUT] = @DATEINPUT ";
            query += "WHERE [ID_INP] = @ID_INP";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_INP", input.ID);
            cmmd.Parameters.AddWithValue("@DATEINPUT", input.DATEINPUT);
            

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
            String query = "DELETE FROM [INPUT] ";
            query += "WHERE [ID_INP] = @ID_INP";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_INP", id);
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

        public List<DTO_Input> SelectAll()
        {
            List<DTO_Input> listSuplier = new List<DTO_Input>();
            String query = "SELECT * FROM INPUT";

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
                        listSuplier.Add(new DTO_Input(reader["ID_INP"].ToString(),
                            (DateTime)reader["DATEINPUT"]));
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
