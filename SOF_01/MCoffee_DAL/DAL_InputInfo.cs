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
    public class DAL_InputInfo :DBConnection
    {
        public String nextID()
        {
            String query = "SELECT TOP 1 [ID_INF] FROM INPUT_INFO ORDER BY [ID_INF] DESC";
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
                        id = reader["ID_INF"].ToString();
                    String pre = id.Substring(0, 2);
                    String suf = id.Substring(2, id.Length - 2);

                    int num = Int32.Parse(suf);
                    num = num + 1;

                    String strNum = num.ToString();
                    suf = suf.Substring(0, suf.Length - strNum.Length);
                    suf = suf + strNum;

                    id = pre + suf;
                }
                else id = "IF00000001";
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

        public Result insert(DTO_InputInfo input_info)
        {
            String query = "INSERT INTO [INPUT_INFO] ([ID_INF], [ID_INP], [ID_OBJ], [ID_EMP], [COUNT], [INPUTPRICE]) ";
            query += "VALUES (@ID_INF, @ID_INP, @ID_OBJ, @ID_EMP, @COUNT, @INPUTPRICE)";
            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_INF", input_info.ID);
            cmmd.Parameters.AddWithValue("@ID_INP", input_info.ID_INP);
            cmmd.Parameters.AddWithValue("@ID_OBJ", input_info.ID_OBJ);
            cmmd.Parameters.AddWithValue("@ID_EMP", input_info.ID_EMP);
            cmmd.Parameters.AddWithValue("@COUNT", input_info.COUNT);
            cmmd.Parameters.AddWithValue("@INPUTPRICE", input_info.INPUTPRICE);

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

        public Result update(DTO_InputInfo input_info)
        {
            String query = "UPDATE [INPUT_INFO] ";
            query += "SET [ID_OBJ] = @ID_OBJ, [ID_EMP] = @ID_EMP, [COUNT] = @COUNT, [INPUTPRICE] = @INPUTPRICE ";
            query += "WHERE [ID_INP] = @ID_INP AND [ID_INF] = @ID_INF";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_INF", input_info.ID);
            cmmd.Parameters.AddWithValue("@ID_INP", input_info.ID_INP);
            cmmd.Parameters.AddWithValue("@ID_OBJ", input_info.ID_OBJ);
            cmmd.Parameters.AddWithValue("@ID_EMP", input_info.ID_EMP);
            cmmd.Parameters.AddWithValue("@COUNT", input_info.COUNT);
            cmmd.Parameters.AddWithValue("@INPUTPRICE", input_info.INPUTPRICE);

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
            String query = "DELETE FROM [INPUT_INFO] ";
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

        public List<DTO_InputInfo> SelectAll(String id_input)
        {
            List<DTO_InputInfo> listSuplier = new List<DTO_InputInfo>();
            String query = "SELECT * FROM INPUT_INFO WHERE [ID_INP] = @ID_INP";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_INP", id_input);

            try
            {
                conn.Open();
                SqlDataReader reader;
                reader = cmmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        listSuplier.Add(new DTO_InputInfo(reader["ID_INF"].ToString(),
                            reader["ID_INP"].ToString(),
                            reader["ID_OBJ"].ToString(),
                            reader["ID_EMP"].ToString(),
                            Int16.Parse(reader["COUNT"].ToString()), 
                            reader["INPUTPRICE"].ToString()));
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
