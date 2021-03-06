﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MCoffee_DTO;
using Untility;

namespace MCoffee_DAL
{
    public class DAL_User : DBConnection
    {
        public String nextID()
        {
            String query = "SELECT TOP 1 [ID_EMP] FROM [USER] ORDER BY [ID_EMP] DESC";
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
                        id = reader["ID_EMP"].ToString();
                    String pre = id.Substring(0, 2);
                    String suf = id.Substring(2, id.Length - 2);

                    int num = Int32.Parse(suf);
                    num = num + 1;

                    String strNum = num.ToString();
                    suf = suf.Substring(0, suf.Length - strNum.Length);
                    suf = suf + strNum;

                    id = pre + suf;
                }
                else id = "U0001";
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

        public bool Insert(DTO_User usr)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO [USER] VALUES(@Id, @Name, @Type, @Username, @Password, @DateStart, @Address)", conn);
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

                SqlCommand cmd = new SqlCommand("Select * from [USER] WHERE [USERNAME] IN(@Username)", conn);
                cmd.Parameters.AddWithValue("@Username", SUsername);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if(dr["PASSWORD"].ToString().Equals(SPassword))
                    {
                        dictionary.Add("DUsername", dr["USERNAME"].ToString());
                        dictionary.Add("DPassword", dr["PASSWORD"].ToString());
                        dictionary.Add("DType", dr["TYPE"].ToString());
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

        public List<DTO_User> SelectAll()
        {
            List<DTO_User> listUser = new List<DTO_User>();
            String query = "SELECT * FROM [USER]";

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
                        listUser.Add(new DTO_User(reader["ID_EMP"].ToString(),
                                                    reader["NAME"].ToString(),
                                                    reader["TYPE"].ToString(),
                                                    reader["USERNAME"].ToString(),
                                                    reader["PASSWORD"].ToString(),
                                                    Convert.ToDateTime(reader["DATESTART"].ToString()),
                                                    reader["ADDRESS"].ToString()));
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
            return listUser;
        }

        public Result Update(DTO_User userDTO)
        {
            String query = "UPDATE [USER] ";
            query += "SET [ID_EMP] = @ID_EMP, [NAME] = @NAME, [TYPE] = @TYPE, [USERNAME] = @USERNAME," +
                    "[PASSWORD] = @PASSWORD, [DATESTART] = @DATESTART, [ADDRESS] = @ADDRESS ";
            query += "WHERE [ID_EMP] = @ID_EMP";

            SqlCommand cmmd = new SqlCommand();
            cmmd.Connection = conn;
            cmmd.CommandType = System.Data.CommandType.Text;
            cmmd.CommandText = query;

            cmmd.Parameters.AddWithValue("@ID_EMP", userDTO.Id);
            cmmd.Parameters.AddWithValue("@NAME", userDTO.Name);
            cmmd.Parameters.AddWithValue("@TYPE", userDTO.Type);
            cmmd.Parameters.AddWithValue("@USERNAME", userDTO.Username);
            cmmd.Parameters.AddWithValue("@PASSWORD", userDTO.Password);
            cmmd.Parameters.AddWithValue("@DATESTART", userDTO.DateStart);
            cmmd.Parameters.AddWithValue("@ADDRESS", userDTO.Address);

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
    }
}
