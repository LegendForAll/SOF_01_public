using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCoffee_DTO;
using MCoffee_DAL;
using System.Data;

namespace MCoffee_BUS
{
    public class BUS_User
    {
        // create 1 object - data access layer doing with database
        DAL_User dal = new DAL_User();

        public String nextID()
        {
            return dal.nextID();
        }

        public bool Insert(DTO_User usr)
        {
            return dal.Insert(usr);
        }

        public Dictionary<string, string> Login(string SUsername, string SPassword)
        {
            return dal.Login(SUsername, SPassword);
        }

        public int[] Options(string SType)
        {
            Dictionary<string, int[]> dic = new Dictionary<string, int[]>();

            //binary options
            int[] E01_option = new int[] { 1, 0, 0, 0, 1 };
            int[] E02_option = new int[] { 0, 1, 0, 1, 1 };
            int[] E03_option = new int[] { 0, 0, 1, 1 ,1 };
            dic.Add("E01", E01_option);
            dic.Add("E02", E02_option);
            dic.Add("E03", E03_option);

            //array option
            return dic[SType];
        }

        public DataTable Display(string sql)
        {
            return dal.Display(sql);
        }

        public List<DTO_User> SelectAll()
        {
            return dal.SelectAll();
        }
    }
}
