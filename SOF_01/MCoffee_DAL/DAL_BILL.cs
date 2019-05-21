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
    public class DAL_BILL : DBConnection
    {
        public bool FindIdBillByIdTable(ref String IdBill, String IdTable)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand
                    ("SELECT [ID_BIL] " +
                    "FROM [BILL] " +
                    "WHERE [NUMBER]=@NUMBER " +
                    "AND STATUS = @STATUS", conn);
                cmd.Parameters.AddWithValue("@NUMBER", IdTable);
                cmd.Parameters.AddWithValue("@STATUS", 1);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    IdBill = dr["ID_BIL"].ToString();
                    return true;
                }
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e)
            {
            }

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
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 [ID_BIL] FROM [BILL] ORDER BY [ID_BIL] DESC", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                String ID = dr["ID_BIL"].ToString();
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
        public bool Insert(DTO_BILL bill_info)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [BILL] " +
                    "VALUES(@ID_BIL, @NUMBER,@SUMPRICE, @SUBPRICE, @STATUS)", conn);
                cmd.Parameters.AddWithValue("@ID_BIL", bill_info.ID_BIL);
                cmd.Parameters.AddWithValue("@NUMBER", bill_info.NUMBER);
                cmd.Parameters.AddWithValue("@SUMPRICE", bill_info.SUMPRICE);
                cmd.Parameters.AddWithValue("@SUBPRICE", bill_info.SUBPRICE);
                cmd.Parameters.AddWithValue("@STATUS", bill_info.STATUS);
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
        public bool UpdateSumPrice(int SUMPRICE,String ID_BIL)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [BILL] " +
                    "SET [SUMPRICE] = @SUMPRICE WHERE [ID_BIL] = @ID_BIL", conn);
                cmd.Parameters.AddWithValue("@SUMPRICE", SUMPRICE);
                cmd.Parameters.AddWithValue("@ID_BIL", ID_BIL);
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
        public bool UpdateSubPrice(int SUBPRICE, String ID_BIL)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [BILL] " +
                    "SET [SUBPRICE] = @SUBPRICE WHERE [ID_BIL] = @ID_BIL", conn);
                cmd.Parameters.AddWithValue("@SUBPRICE", SUBPRICE);
                cmd.Parameters.AddWithValue("@ID_BIL", ID_BIL);
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
        public bool UpdateStatus(String ID_BIL, int status)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [BILL] " +
                    "SET [STATUS]=@STATUS" +
                    " WHERE [ID_BIL]=@ID_BIL", conn);
                cmd.Parameters.AddWithValue("@STATUS", status);
                cmd.Parameters.AddWithValue("@ID_BIL", ID_BIL);
                SqlDataReader dr = cmd.ExecuteReader();
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
