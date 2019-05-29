using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCoffee_DAL;
using MCoffee_DTO;
using Untility;

namespace MCoffee_BUS
{
    public class BUS_Table
    {
        DAL_Table dal_table = new DAL_Table();

        public bool isExist(String id)
        {
            List<DTO_Table> tables = new List<DTO_Table>();
            tables = SelectAll();
            foreach (DTO_Table tab in tables)
                if (tab.ID.Equals(id))
                    return true;
            return false;
        }

        public String nextID()
        {
            return dal_table.nextID();
        }

        public Result insert(DTO_Table table)
        {
            return dal_table.insert(table);
        }

        public Result update(DTO_Table table)
        {
            return dal_table.update(table);
        }

        public Result delete(String id)
        {
            return dal_table.delete(id);
        }

        public DTO_Table Select_ID(String id)
        {
            return dal_table.Select_ID(id);
        }

        public List<DTO_Table> SelectAll()
        {
            return dal_table.SelectAll();
        }
    }
}
