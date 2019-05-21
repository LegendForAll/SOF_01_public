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
    public class DAL_BILL_INFO : DBConnection
    {
        public bool SelectAllByTableNumber(ref List<DTO_Menu> ListBillInfo, String IdTable)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand
                    ("SELECT [DISPLAYNAME],[COUNT],[PRICE] " +
                    "FROM [BILL],[BILL_INFO],[FOOD] " +
                    "WHERE [BILL].[ID_BIL]=[BILL_INFO].[ID_BIL] " +
                    "AND [BILL_INFO].[ID_FOD]=[FOOD].[ID_FOD]" +
                    "AND [ID_TAB]=@ID_TAB " +
                    "AND [STATUS]=@STATUS ", conn);
                cmd.Parameters.AddWithValue("@ID_TAB", IdTable);
                cmd.Parameters.AddWithValue("@STATUS", 1);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListBillInfo.Add(new DTO_Menu(dr["DISPLAYNAME"].ToString(), 
                        Int32.Parse(dr["COUNT"].ToString()), double.Parse(dr["PRICE"].ToString())));
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
        public bool Insert(DTO_BILL_INFO bill_info)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [BILL_INFO] " +
                    "VALUES(@ID_BILF, @ID_FOD,@ID_BIL, @COUNT, @PRICE)", conn);
                cmd.Parameters.AddWithValue("@ID_BILF", bill_info.ID_BILF);
                cmd.Parameters.AddWithValue("@ID_FOD", bill_info.ID_FOD);
                cmd.Parameters.AddWithValue("@ID_BIL", bill_info.ID_BIL);
                cmd.Parameters.AddWithValue("@COUNT", bill_info.COUNT);
                cmd.Parameters.AddWithValue("@PRICE", bill_info.PRICE);
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
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 [ID_BILF] FROM [BILL_INFO] ORDER BY [ID_BILF] DESC", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                String ID = dr["ID_BILF"].ToString();
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
        public bool Sumprice(ref int SumPrice, String ID_BIL)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT SUM([PRICE]) AS [TONG] " +
                    "FROM [BILL_INFO] " +
                    " WHERE [ID_BIL] = @ID_BIL", conn);
                cmd.Parameters.AddWithValue("@ID_BIL", ID_BIL);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                SumPrice = Int32.Parse( dr["TONG"].ToString());
                //NextID = int.Parse(ID) + 1;
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
