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
    public class DAL_FOOD : DBConnection
    {
        public bool Insert(DTO_FOOD food)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [FOOD]" +
                    " VALUES( @ID_FOD, @ID_CAT,@DISPLAYNAME, @OUTPUTPRICE, @PICTURE )", conn);
                cmd.Parameters.AddWithValue("@ID_FOD", food.ID_FOD);
                cmd.Parameters.AddWithValue("@ID_CAT", food.ID_CAT);
                cmd.Parameters.AddWithValue("@DISPLAYNAME", food.DISPLAYNAME);
                cmd.Parameters.AddWithValue("@OUTPUTPRICE", food.OUTPUTPRICE);
                cmd.Parameters.AddWithValue("@PICTURE", food.PICTURE);
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
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 [ID_FOD] FROM [FOOD] ORDER BY [ID_FOD] DESC", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                String ID = dr["ID_FOD"].ToString();
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
        public bool SelectAll(ref List<DTO_FOOD> ListFood)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT [ID_FOD],[ID_CAT],[DISPLAYNAME]," +
                    "[OUTPUTPRICE],[PICTURE] FROM [FOOD] ORDER BY [ID_FOD] ASC", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListFood.Add(new DTO_FOOD(dr["ID_FOD"].ToString(), dr["ID_CAT"].ToString()
                        , dr["DISPLAYNAME"].ToString(), 
                        Int32.Parse( dr["OUTPUTPRICE"].ToString()), dr["PICTURE"].ToString()));
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
        public bool SelectAllByCategory(ref List<DTO_FOOD> ListFood, String Category)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand
                    ("SELECT [ID_FOD],[FOOD].[ID_CAT],[DISPLAYNAME], [OUTPUTPRICE],[PICTURE]" +
                    "FROM [FOOD],[FOOD_CATEGORY] " +
                    "WHERE [FOOD].[ID_CAT]=[FOOD_CATEGORY].[ID_CAT]" +
                    " AND [NAMECAT]=@NAMECAT" +
                    " ORDER BY [ID_FOD] ASC", conn);
                cmd.Parameters.AddWithValue("@NAMECAT", Category);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListFood.Add(new DTO_FOOD(dr["ID_FOD"].ToString(), dr["ID_CAT"].ToString()
                        , dr["DISPLAYNAME"].ToString(), 
                        Int32.Parse(dr["OUTPUTPRICE"].ToString()), dr["PICTURE"].ToString()));
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
        public bool Update(DTO_FOOD food)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [FOOD] SET " +
                    "[ID_CAT]=@ID_CAT, " +
                    "[DISPLAYNAME]=@DISPLAYNAME, " +
                    "[OUTPUTPRICE]=@OUTPUTPRICE " +
                    "[PICTURE]=@PICTURE " +
                    "WHERE [ID_FOD]=@ID_FOD", conn);
                cmd.Parameters.AddWithValue("@ID_FOD", food.ID_FOD);
                cmd.Parameters.AddWithValue("@ID_CAT", food.ID_CAT);
                cmd.Parameters.AddWithValue("@DISPLAYNAME", food.DISPLAYNAME);
                cmd.Parameters.AddWithValue("@OUTPUTPRICE", food.OUTPUTPRICE);
                cmd.Parameters.AddWithValue("@PICTURE", food.PICTURE);
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
        public bool Delete(String ID_FOD)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [FOOD] " +
                    "WHERE [ID_FOD] = @ID_FOD", conn);
                cmd.Parameters.AddWithValue("@ID_FOD", ID_FOD);
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
        public bool Search(ref List<DTO_FOOD> ListFood, String Category, String searchtext)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand
                    ("SELECT [ID_FOD],[FOOD].[ID_CAT],[DISPLAYNAME], [OUTPUTPRICE],[PICTURE]" +
                    "FROM [FOOD],[FOOD_CATEGORY] " +
                    "WHERE [FOOD].[ID_CAT]=[FOOD_CATEGORY].[ID_CAT] " +
                    "AND [NAMECAT]=@NAMECAT " +
                    "AND CONCAT([ID_FOD],[DISPLAYNAME],[OUTPUTPRICE]) like '%' + @searchtext + '%' " +
                    " ORDER BY [ID_FOD] ASC", conn);
                cmd.Parameters.AddWithValue("@NAMECAT", Category);
                cmd.Parameters.AddWithValue("@searchtext", searchtext);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListFood.Add(new DTO_FOOD(dr["ID_FOD"].ToString(), dr["ID_CAT"].ToString()
                        , dr["DISPLAYNAME"].ToString(), 
                        Int32.Parse(dr["OUTPUTPRICE"].ToString()), dr["PICTURE"].ToString()));
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
        public bool SelectAllByName(ref DTO_FOOD food, String Name)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand
                    ("SELECT [ID_FOD],[ID_CAT],[DISPLAYNAME], [OUTPUTPRICE],[PICTURE]" +
                    "FROM [FOOD] " +
                    "WHERE [DISPLAYNAME]=@DISPLAYNAME" +
                    " ORDER BY [ID_FOD] ASC", conn);
                cmd.Parameters.AddWithValue("@DISPLAYNAME", Name);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    food=new DTO_FOOD(dr["ID_FOD"].ToString(), dr["ID_CAT"].ToString()
                        , dr["DISPLAYNAME"].ToString(), 
                        Int32.Parse(dr["OUTPUTPRICE"].ToString()), dr["PICTURE"].ToString());
                    return true;
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
