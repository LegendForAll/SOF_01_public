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
    public class DAL_TABLE : DBConnection
    {
        public bool SelectAll(ref List<DTO_TABLE> ListCategory)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT [NUMBER] , [STATUS] FROM [TABLE] ORDER BY [NUMBER] ASC", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListCategory.Add(new DTO_TABLE(Int32.Parse(dr["NUMBER"].ToString()), dr["STATUS"].ToString()));
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
        public bool UpdateStatus(String number, int status)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [TABLE] " +
                    "SET [STATUS]=@STATUS" +
                    " WHERE [NUMBER]=@NUMBER", conn);
                cmd.Parameters.AddWithValue("@STATUS", status);
                cmd.Parameters.AddWithValue("@NUMBER", number);
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
