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
    public class BUS_BILL_INFO
    {
        DAL_BILL_INFO dal_bill_in = new DAL_BILL_INFO();

        public bool isExist(String id)
        {
            List<DTO_BILL_INFO> bills_in = new List<DTO_BILL_INFO>();
            bills_in = SelectAll();
            foreach (DTO_BILL_INFO tab in bills_in)
                if (tab.ID.Equals(id))
                    return true;
            return false;
        }

        public String nextID()
        {
            return dal_bill_in.nextID();
        }

        public Result insert(DTO_BILL_INFO bill_in)
        {
            return dal_bill_in.insert(bill_in);
        }

        public List<DTO_BILL_INFO> SelectAll(String id_bill)
        {
            return dal_bill_in.SelectAll(id_bill);
        }

        public List<DTO_BILL_INFO> SelectAll()
        {
            return dal_bill_in.SelectAll();
        }
    }
}
