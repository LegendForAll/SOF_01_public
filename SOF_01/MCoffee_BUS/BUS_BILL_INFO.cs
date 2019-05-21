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
    public class BUS_BILL_INFO
    {
        DAL_BILL_INFO bill_info = new DAL_BILL_INFO();
        public bool SelectAllByTableNumber(ref List<DTO_Menu> ListBillInfo, String number)
        {
            return bill_info.SelectAllByTableNumber(ref ListBillInfo, number);
        }
        public bool Insert(DTO_BILL_INFO dal)
        {
            return bill_info.Insert(dal);
        }
        public bool NextID(ref int NextID)
        {
            return bill_info.NextID(ref NextID);
        }
        public bool Sumprice(ref int SumPrice,String ID_BIL)
        {
            return bill_info.Sumprice(ref SumPrice, ID_BIL);

        }
    }
}
