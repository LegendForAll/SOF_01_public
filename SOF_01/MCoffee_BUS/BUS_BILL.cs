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
    public class BUS_BILL
    {
        DAL_BILL dal_bill = new DAL_BILL();

        public bool isExist(String id)
        {
            List<DTO_BILL> bills = new List<DTO_BILL>();
            bills = SelectAll();
            foreach (DTO_BILL tab in bills)
                if (tab.ID.Equals(id))
                    return true;
            return false;
        }

        public String nextID()
        {
            return dal_bill.nextID();
        }

        public Result insert(DTO_BILL bill)
        {
            return dal_bill.insert(bill);
        }

        public DTO_BILL SelectID_Table(String id_table)
        {
            return dal_bill.SelectID_Table(id_table);
        }

        public DTO_BILL SelectID(String id)
        {
            return dal_bill.SelectID(id);
        }

        public List<DTO_BILL> Select_DATE(DateTime date)
        {
            return dal_bill.Select_DATE(date);
        }

        public List<DTO_BILL> SelectAll()
        {
            return dal_bill.SelectAll();
        }
    }
}
