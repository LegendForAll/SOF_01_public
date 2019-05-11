using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MCoffee_DTO; 

namespace MCoffee_DAL
{
    public class DAL_User : DBConnection
    {
        public bool Insert(DTO_User usr)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO USER VALUES(@Id, @Name, @Type, @Username, @Password, @DateStart, @Address)", conn);
                cmd.Parameters.AddWithValue("@Id", usr.Id);
                cmd.Parameters.AddWithValue("@Name", usr.Name);
                cmd.Parameters.AddWithValue("@Type", usr.Type);
                cmd.Parameters.AddWithValue("@Username", usr.Username);
                cmd.Parameters.AddWithValue("@Password", usr.Password);
                cmd.Parameters.AddWithValue("@DateStart", usr.DateStart);
                cmd.Parameters.AddWithValue("@Address", usr.Address);
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

        public Dictionary<string, string> Login(string SUsername, string SPassword)
        {
            var dictionary = new Dictionary<string, string>();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * from [USER] WHERE Username IN(@Username)", conn);
                cmd.Parameters.AddWithValue("@Username", SUsername);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if(dr["Password"].ToString().Equals(SPassword))
                    {
                        dictionary.Add("DUsername", dr["Username"].ToString());
                        dictionary.Add("DPassword", dr["Password"].ToString());
                        dictionary.Add("DType", dr["Type"].ToString());
                        return dictionary;
                    }
                }                  
            }

            catch (Exception e)
            { }

            finally
            {
                conn.Close();
            }

            return null;
        }

        public DataTable Display(string sql)
        {
            DataTable tblNhanVien = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblNhanVien);  //Fill vào một biến kiểu Datatable
                return tblNhanVien;
            }

            catch (Exception e) { }

            finally
            { conn.Close(); }

            return null;
        }
    }
}
