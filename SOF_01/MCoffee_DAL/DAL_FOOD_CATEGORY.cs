using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using MCoffee_DTO;

namespace MCoffee_DAL
{
    public class DAL_FOOD_CATEGORY : DBConnection
    {
        public bool Insert(DTO_FOOD_CATEGORY food_category)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [FOOD_CATEGORY] VALUES(@ID_CAT, @NAMECAT)", conn);
                cmd.Parameters.AddWithValue("@ID_CAT", food_category.ID_CAT);
                cmd.Parameters.AddWithValue("@NAMECAT", food_category.NAMECAT);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e)
            { }

            finally
            {
                conn.Close();
            }

            return false;
        }
        public bool NextID(ref String NextID)
        {
            String query = "SELECT TOP 1 [ID_CAT] FROM [FOOD_CATEGORY] ORDER BY [ID_CAT] DESC";
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
                        id = reader["ID_CAT"].ToString();
                    String pre = id.Substring(0, 2);
                    String suf = id.Substring(2, id.Length - 2);

                    int num = Int32.Parse(suf);
                    num = num + 1;

                    String strNum = num.ToString();
                    suf = suf.Substring(0, suf.Length - strNum.Length);
                    suf = suf + strNum;

                    id = pre + suf;
                    NextID = id;
                }
                else id = "CA0001";
            }
            catch (Exception e)
            {
                conn.Close();
                System.Console.WriteLine(e.Message);
                return false;
            }

            conn.Close();
            return true;
        }

        public bool SelectAll(ref List<DTO_FOOD_CATEGORY> ListCategory)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [FOOD_CATEGORY] ORDER BY [ID_CAT] ASC", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListCategory.Add(new DTO_FOOD_CATEGORY(dr["ID_CAT"].ToString(), dr["DISPLAYNAME"].ToString()));
                }
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e)
            { }

            finally
            {
                conn.Close();
            }

            return false;
        }
    }
}
