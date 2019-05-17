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
    public class DAL_BILL : DBConnection
    {
        public String nextID()
        {
            String query = "SELECT TOP 1 [ID_BIL] FROM [BILL] ORDER BY [ID_BIL] DESC";
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
                        id = reader["ID_BIL"].ToString();
                    String pre = id.Substring(0, 2);
                    String suf = id.Substring(2, id.Length - 2);

                    int num = Int32.Parse(suf);
                    num = num + 1;

                    String strNum = num.ToString();
                    suf = suf.Substring(0, suf.Length - strNum.Length);
                    suf = suf + strNum;

                    id = pre + suf;
                }
                else id = "B0001";
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

        public Result insert(DTO_BILL bill)
        {
            String query = "INSERT INTO [BILL] ([ID_BIL], [DATETIME], [ID_EMP], [ID_TAB], [STATUS], [SUMPRICE], [SUBPRICE]) ";
            query += "VALUES (@ID_BIL, @DATETIME, @ID_EMP, @ID_TAB, @STATUS, @SUMPRICE, @SUBPRICE)";
            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_BIL", bill.ID);
            cmmd.Parameters.AddWithValue("@DATETIME", bill.DATETIME);
            cmmd.Parameters.AddWithValue("@ID_EMP", bill.ID_EMP);
            cmmd.Parameters.AddWithValue("@ID_TAB", bill.ID_TAB);
            cmmd.Parameters.AddWithValue("@STATUS", bill.STATUS);
            cmmd.Parameters.AddWithValue("@SUMPRICE", bill.SUMPRICE.ToString());
            cmmd.Parameters.AddWithValue("@SUBPRICE", bill.SUBPRICE.ToString());
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
            return new Result(true);
        }

        public Result delete(String id)
        {
            String query = "DELETE FROM [BILL] ";
            query += "WHERE [ID_BIL] = @ID_BIL";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_BIL", id);
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

        public DTO_BILL SelectID(String id)
        {
            DTO_BILL bill = new DTO_BILL();
            String query = "SELECT * FROM [BILL] ";
            query += "WHERE [ID_BIL] = @ID_BIL";


            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_BIL", id);


            try
            {
                conn.Open();
                SqlDataReader reader;
                reader = cmmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        bill = new DTO_BILL(reader["ID_BIL"].ToString(),
                                                    Convert.ToDateTime(reader["DATETIME"].ToString()),
                                                    reader["ID_EMP"].ToString(),
                                                    reader["ID_TAB"].ToString(),
                                                    reader["STATUS"].ToString(),
                                                    Convert.ToDouble(reader["SUMPRICE"].ToString()),
                                                    Convert.ToDouble(reader["SUBPRICE"].ToString()));
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
            return bill;
        }

        public List<DTO_BILL> Select_DATE(DateTime date)
        {
            List<DTO_BILL> listbill = new List<DTO_BILL>();
            String query = "SELECT * FROM [BILL] ";
            query += "[DATETIME] = '2019-09-09 00:00:00.0000000'";

            String temp = date.ToString("yyyy-MM-dd 00:00:00.0000000");

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
                        listbill.Add(new DTO_BILL(reader["ID_BIL"].ToString(),
                                                    Convert.ToDateTime(reader["DATETIME"].ToString()),
                                                    reader["ID_EMP"].ToString(),
                                                    reader["ID_TAB"].ToString(),
                                                    reader["STATUS"].ToString(),
                                                    Convert.ToDouble(reader["SUMPRICE"].ToString()),
                                                    Convert.ToDouble(reader["SUBPRICE"].ToString())));
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
            return listbill;
        }

        public DTO_BILL SelectID_Table(String id_table)
        {
            DTO_BILL bill = new DTO_BILL();
            String query = "SELECT * FROM [BILL]";
            query += "WHERE [ID_TAB] = @ID_TAB";
            query += " AND [STATUS] = @STATUS";


            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_TAB", id_table);
            cmmd.Parameters.AddWithValue("@STATUS", "NO");

            try
            {
                conn.Open();
                SqlDataReader reader;
                reader = cmmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        bill = new DTO_BILL(reader["ID_BIL"].ToString(),
                                                    Convert.ToDateTime(reader["DATETIME"].ToString()),
                                                    reader["ID_EMP"].ToString(),
                                                    reader["ID_TAB"].ToString(),
                                                    reader["STATUS"].ToString(),
                                                    Convert.ToDouble(reader["SUMPRICE"].ToString()),
                                                    Convert.ToDouble(reader["SUBPRICE"].ToString()));
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
            return bill;
        }

        public List<DTO_BILL> SelectAll()
        {
            List<DTO_BILL> listbill = new List<DTO_BILL>();
            String query = "SELECT * FROM [BILL]";

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
                        listbill.Add(new DTO_BILL(reader["ID_BIL"].ToString(),
                                                    Convert.ToDateTime(reader["DATETIME"].ToString()),
                                                    reader["ID_EMP"].ToString(),
                                                    reader["ID_TAB"].ToString(),
                                                    reader["STATUS"].ToString(),
                                                    Convert.ToDouble(reader["SUMPRICE"].ToString()),
                                                    Convert.ToDouble(reader["SUBPRICE"].ToString())));
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
            return listbill;
        }
    }
}
