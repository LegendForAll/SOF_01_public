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
    public class DAL_Object :DBConnection
    {
        public String nextID()
        {
            String query = "SELECT TOP 1 [ID_OBJ] FROM OBJECT ORDER BY [ID_OBJ] DESC";
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
                        id = reader["ID_OBJ"].ToString();
                    String pre = id.Substring(0, 2);
                    String suf = id.Substring(2, id.Length - 2);

                    int num = Int32.Parse(suf);
                    num = num + 1;

                    String strNum = num.ToString();
                    suf = suf.Substring(0, suf.Length - strNum.Length);
                    suf = suf + strNum;

                    id = pre + suf;
                }
                else id = "OB0001";
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

        public Result insert(DTO_Object obj)
        {
            String query = "INSERT INTO [OBJECT] ([ID_OBJ], [DISPLAYNAME], [ID_SUP], [ID_UNI], [NUM_REPO]) ";
            query += "VALUES (@ID_OBJ, @DISPLAYNAME, @ID_SUP, @ID_UNI, @NUM_REPO)";
            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_OBJ", obj.ID);
            cmmd.Parameters.AddWithValue("@DISPLAYNAME", obj.DISPLAYNAME);
            cmmd.Parameters.AddWithValue("@ID_SUP", obj.ID_SUP);
            cmmd.Parameters.AddWithValue("@ID_UNI", obj.ID_UNI);
            cmmd.Parameters.AddWithValue("@NUM_REPO", obj.NUM_REPO);

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

        public Result update(DTO_Object obj)
        {
            String query = "UPDATE [OBJECT] ";
            query += "SET [DISPLAYNAME] = @DISPLAYNAME, [ID_SUP] = @ID_SUP, [ID_UNI] = @ID_UNI, [NUM_REPO] = @NUM_REPO ";
            query += "WHERE [ID_OBJ] = @ID_OBJ";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_OBJ", obj.ID);
            cmmd.Parameters.AddWithValue("@DISPLAYNAME", obj.DISPLAYNAME);
            cmmd.Parameters.AddWithValue("@ID_SUP", obj.ID_SUP);
            cmmd.Parameters.AddWithValue("@ID_UNI", obj.ID_UNI);
            cmmd.Parameters.AddWithValue("@NUM_REPO", obj.NUM_REPO);

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

        public int getNum_repo(String id)
        {
            int num = 0;
            String query = "SELECT [NUM_REPO] FROM [OBJECT] WHERE [ID_OBJ] = @ID_OBJ";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_OBJ", id);
            try
            {
                conn.Open();               
                SqlDataReader reader = cmmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                        num = (int)reader["NUM_REPO"];
                }
            }
            catch (Exception e)
            {
                conn.Close();
                System.Console.WriteLine(e.Message);
                return -1;
            }

            conn.Close();
            return num;
        }

        public Result updateNum_repo(String id, int num)
        {
            String query = "UPDATE [OBJECT] ";
            query += "SET [NUM_REPO] = @NUM_REPO ";
            query += "WHERE [ID_OBJ] = @ID_OBJ";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_OBJ", id);
            cmmd.Parameters.AddWithValue("@NUM_REPO", num);

            try
            {
                conn.Open();
                cmmd.ExecuteNonQuery();
            }
            catch(Exception e)
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
            String query = "DELETE FROM [OBJECT] ";
            query += "WHERE [ID_OBJ] = @ID_OBJ";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@ID_OBJ", id);
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

        public List<DTO_Object2> SelectAll()
        {
            String query = "SELECT [ID_OBJ], [OBJECT].[DISPLAYNAME], [SUPLIER].[DISPLAYNAME] AS SUPLIERNAME, ";
            query += "[UNIT].[DISPLAYNAME] AS UNITNAME, [NUM_REPO] ";
            query += "FROM [OBJECT], [SUPLIER], [UNIT] ";
            query += "WHERE [OBJECT].[ID_SUP] = [SUPLIER].[ID_SUP] AND [OBJECT].[ID_UNI] = [UNIT].[ID_UNI] ";

            List<DTO_Object2> listObject = new List<DTO_Object2>();

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
                        listObject.Add(new DTO_Object2(reader["ID_OBJ"].ToString(),
                            reader["DISPLAYNAME"].ToString(),
                            reader["SUPLIERNAME"].ToString(),
                            reader["UNITNAME"].ToString(),
                            (int)reader["NUM_REPO"]));
                }
            }
            catch (Exception e)
            {
                conn.Close();
                System.Console.WriteLine(e.Message);
                return null;
            }

            conn.Close();
            return listObject;
        }

        public List<DTO_Object2> Select_SUPLIER(String suplier)
        {
            String query = "SELECT [ID_OBJ], [OBJECT].[DISPLAYNAME], [SUPLIER].[DISPLAYNAME] AS SUPLIERNAME, ";
            query += "[UNIT].[DISPLAYNAME] AS UNITNAME, [NUM_REPO] ";
            query += "FROM [OBJECT], [SUPLIER], [UNIT] ";
            query += "WHERE [OBJECT].[ID_SUP] = [SUPLIER].[ID_SUP] AND [OBJECT].[ID_UNI] = [UNIT].[ID_UNI] ";
            query += "AND [SUPLIER].[DISPLAYNAME] = @Name";

            List <DTO_Object2> listObject = new List<DTO_Object2>();

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@Name", suplier);

            try
            {
                conn.Open();
                SqlDataReader reader;
                reader = cmmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                        listObject.Add(new DTO_Object2(reader["ID_OBJ"].ToString(),
                            reader["DISPLAYNAME"].ToString(),
                            reader["SUPLIERNAME"].ToString(),
                            reader["UNITNAME"].ToString(),
                            (int)reader["NUM_REPO"]));
                }
            }
            catch (Exception e)
            {
                conn.Close();
                System.Console.WriteLine(e.Message);
                return null;
            }

            conn.Close();
            return listObject;
        }

        public List<DTO_Object2> Select_NAME(String name)
        {
            String query = "SELECT [ID_OBJ], [OBJECT].[DISPLAYNAME], [SUPLIER].[DISPLAYNAME] AS SUPLIERNAME, ";
            query += "[UNIT].[DISPLAYNAME] AS UNITNAME, [NUM_REPO] ";
            query += "FROM [OBJECT], [SUPLIER], [UNIT] ";
            query += "WHERE [OBJECT].[ID_SUP] = [SUPLIER].[ID_SUP] AND [OBJECT].[ID_UNI] = [UNIT].[ID_UNI] ";
            query += "AND [OBJECT].[DISPLAYNAME] = @Name";

            List<DTO_Object2> listObject = new List<DTO_Object2>();

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;
            cmmd.Parameters.AddWithValue("@Name", name);

            try
            {
                conn.Open();
                SqlDataReader reader;
                reader = cmmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                        listObject.Add(new DTO_Object2(reader["ID_OBJ"].ToString(),
                            reader["DISPLAYNAME"].ToString(),
                            reader["SUPLIERNAME"].ToString(),
                            reader["UNITNAME"].ToString(),
                            (int)reader["NUM_REPO"]));
                }
            }
            catch (Exception e)
            {
                conn.Close();
                System.Console.WriteLine(e.Message);
                return null;
            }

            conn.Close();
            return listObject;
        }
    }
}
