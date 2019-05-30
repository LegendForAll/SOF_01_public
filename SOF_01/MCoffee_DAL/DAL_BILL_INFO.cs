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
    public class DAL_BILL_INFO : DBConnection
    {
        public String nextID()
        {
            String query = "SELECT TOP 1 [ID_BILF] FROM [BILL_INFO] ORDER BY [ID_BILF] DESC";
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
                        id = reader["ID_BILF"].ToString();
                    String pre = id.Substring(0, 2);
                    String suf = id.Substring(2, id.Length - 2);

                    int num = Int32.Parse(suf);
                    num = num + 1;

                    String strNum = num.ToString();
                    suf = suf.Substring(0, suf.Length - strNum.Length);
                    suf = suf + strNum;

                    id = pre + suf;
                }
                else id = "BF0001";
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

        public Result insert(DTO_BILL_INFO bill_in)
        {
            String query = "INSERT INTO [BILL_INFO] ([ID_BILF], [ID_FOD], [ID_BIL], [COUNT], [PRICE]) ";
            query += "VALUES (@ID_BILF, @ID_FOD, @ID_BIL, @COUNT, @PRICE)";
            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_BILF", bill_in.ID);
            cmmd.Parameters.AddWithValue("@ID_FOD", bill_in.ID_FOD);
            cmmd.Parameters.AddWithValue("@ID_BIL", bill_in.ID_BIL);
            cmmd.Parameters.AddWithValue("@COUNT", bill_in.COUNT);
            cmmd.Parameters.AddWithValue("@PRICE", bill_in.PRICE);

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

        public Result update(DTO_BILL_INFO bill_in)
        {
            String query = "UPDATE [BILL_INFO] ";
            query += "SET [ID_FOD] = @ID_FOD ";
            query += "SET [ID_BIL] = @ID_BIL ";
            query += "SET [COUNT] = @COUNT ";
            query += "SET [PRICE] = @PRICE ";
            query += "WHERE [ID_BILF] = @ID_BILF";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_BILF", bill_in.ID);
            cmmd.Parameters.AddWithValue("@ID_FOD", bill_in.ID_FOD);
            cmmd.Parameters.AddWithValue("@ID_BIL", bill_in.ID_BIL);
            cmmd.Parameters.AddWithValue("@COUNT", bill_in.COUNT);
            cmmd.Parameters.AddWithValue("@PRICE", bill_in.PRICE);

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
            String query = "DELETE FROM [BILL_INFO] ";
            query += "WHERE [ID_BILF] = @ID_BILF";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_BILF", id);
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

        public List<DTO_infoBill> SelectAll_IDBill(String ibill)
        {
            List<DTO_infoBill> listbill_in = new List<DTO_infoBill>();
            String query = "SELECT * ";
            query += "FROM [BILL_INFO] INNER JOIN [FOOD] ON [BILL_INFO].[ID_FOD] = [FOOD].[ID_FOD] ";
            query += "WHERE [BILL_INFO].[ID_BIL] = @ID_BIL ";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_BIL", ibill);

            try
            {
                conn.Open();
                SqlDataReader reader;
                reader = cmmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        listbill_in.Add(new DTO_infoBill(reader["ID_FOD"].ToString(),
                                                    reader["DISPLAYNAME"].ToString(),
                                                    Convert.ToInt32(reader["COUNT"].ToString()),
                                                    Convert.ToDouble(reader["PRICE"].ToString())));
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
            return listbill_in;
        }

        public List<DTO_BILL_INFO> SelectAll()
        {
            List<DTO_BILL_INFO> listbill_in = new List<DTO_BILL_INFO>();
            String query = "SELECT * FROM [BILL_INFO]";

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
                        listbill_in.Add(new DTO_BILL_INFO(reader["ID_BILF"].ToString(),
                                                    reader["ID_FOD"].ToString(),
                                                    reader["ID_BIL"].ToString(),
                                                    Convert.ToInt32(reader["COUNT"].ToString()),
                                                    Convert.ToDouble(reader["PRICE"].ToString())));
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
            return listbill_in;
        }

        public List<DTO_Menu> SelectAll(String id_bill)
        {
            List<DTO_Menu> listbill_in = new List<DTO_Menu>();
            String query = "SELECT * ";
            query += "FROM [BILL_INFO] INNER JOIN [FOOD] ON [BILL_INFO].[ID_FOD] = [FOOD].[ID_FOD] ";
            query += "WHERE [BILL_INFO].[ID_BIL] = @ID_BIL ";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_BIL", id_bill);

            try
            {
                conn.Open();
                SqlDataReader reader;
                reader = cmmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        listbill_in.Add(new DTO_Menu(reader["DISPLAYNAME"].ToString(),
                                                    Convert.ToInt32(reader["COUNT"].ToString()),
                                                    Convert.ToDouble(reader["PRICE"].ToString())));
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
            return listbill_in;
        }
    }
}
