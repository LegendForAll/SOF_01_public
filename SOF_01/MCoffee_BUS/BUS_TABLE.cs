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
    public class BUS_TABLE
    {
        DAL_TABLE table = new DAL_TABLE();

        public bool SelectAll(ref List<DTO_TABLE> ListTable)
        {
            return table.SelectAll(ref ListTable);
        }
        public bool UpdateStatus(String number ,int status)
        {
            return table.UpdateStatus(number,status);
        }
    }
}
