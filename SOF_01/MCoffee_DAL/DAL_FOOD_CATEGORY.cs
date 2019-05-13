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
        public bool NextID(ref int NextID)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 [ID_CAT] FROM [FOOD_CATEGORY] ORDER BY [ID_CAT] DESC", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                String ID = dr["ID_CAT"].ToString();
                NextID = int.Parse(ID) + 1;
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
        public bool SelectAll(ref List<DTO_FOOD_CATEGORY> ListCategory)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT [ID_CAT] , [NAMECAT] FROM [FOOD_CATEGORY] ORDER BY [ID_CAT] ASC", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListCategory.Add(new DTO_FOOD_CATEGORY(dr["ID_CAT"].ToString(), dr["NAMECAT"].ToString()));
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
