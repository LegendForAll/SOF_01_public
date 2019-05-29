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
    public class DAL_Table : DBConnection
    {
        public String nextID()
        {
            String query = "SELECT TOP 1 [ID_TAB] FROM [TABLE] ORDER BY [ID_TAB] DESC";
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
                        id = reader["ID_TAB"].ToString();
                    String pre = id.Substring(0, 2);
                    String suf = id.Substring(2, id.Length - 2);

                    int num = Int32.Parse(suf);
                    num = num + 1;

                    String strNum = num.ToString();
                    suf = suf.Substring(0, suf.Length - strNum.Length);
                    suf = suf + strNum;

                    id = pre + suf;
                }
                else id = "TB0001";
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

        public Result insert(DTO_Table table)
        {
            String query = "INSERT INTO [TABLE] ([ID_TAB], [NUMBER], [AREA], [LIMIT], [STATUS]) ";
            query += "VALUES (@ID_TAB, @NUMBER, @AREA, @LIMIT, @STATUS)";
            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_TAB", table.ID);
            cmmd.Parameters.AddWithValue("@NUMBER", table.NUMBER);
            cmmd.Parameters.AddWithValue("@AREA", table.AREA);
            cmmd.Parameters.AddWithValue("@LIMIT", table.LIMIT.ToString());
            cmmd.Parameters.AddWithValue("@STATUS", table.STATUS.ToString());
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

        public Result update(DTO_Table table)
        {
            String query = "UPDATE [TABLE] ";
            query += "SET [NUMBER] = @NUMBER , ";
            query += " [AREA] = @AREA , ";
            query += " [LIMIT] = @LIMIT , ";
            query += " [STATUS] = @STATUS ";
            query += " WHERE [ID_TAB] = @ID_TAB ";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_TAB", table.ID);
            cmmd.Parameters.AddWithValue("@NUMBER", table.NUMBER);
            cmmd.Parameters.AddWithValue("@AREA", table.AREA);
            cmmd.Parameters.AddWithValue("@LIMIT", table.LIMIT);
            cmmd.Parameters.AddWithValue("@STATUS", table.STATUS);

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
            String query = "DELETE FROM [TABLE] ";
            query += "WHERE [ID_TAB] = @ID_TAB";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_TAB", id);
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

        public DTO_Table Select_ID(String id)
        {
            DTO_Table listtable = new DTO_Table();
            String query = "SELECT * FROM [TABLE] ";
            query += "WHERE [ID_TAB] = @ID_TAB";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_TAB", id);

            try
            {
                conn.Open();
                SqlDataReader reader;
                reader = cmmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        listtable = new DTO_Table(reader["ID_TAB"].ToString(),
                                                    reader["NUMBER"].ToString(),
                                                    reader["AREA"].ToString(),
                                                    reader["LIMIT"].ToString(),
                                                    reader["STATUS"].ToString());
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
            return listtable;
        }

        public List<DTO_Table> SelectAll()
        {
            List<DTO_Table> listtable = new List<DTO_Table>();
            String query = "SELECT * FROM [TABLE]";

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
                        listtable.Add(new DTO_Table(reader["ID_TAB"].ToString(),
                                                    reader["NUMBER"].ToString(),
                                                    reader["AREA"].ToString(),
                                                    reader["LIMIT"].ToString(),
                                                    reader["STATUS"].ToString()));
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
            return listtable;
        }
    }
}
