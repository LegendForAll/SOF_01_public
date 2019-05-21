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
    public class BUS_BILL
    {
        DAL_BILL bill = new DAL_BILL();
        public bool FindIdBillByIdTable(ref String IdBill, String IdTable)
        {
            return bill.FindIdBillByIdTable(ref IdBill, IdTable);
        }
        public bool NextID(ref int NextID)
        {
            return bill.NextID(ref NextID);
        }
        public bool Insert(DTO_BILL dal)
        {
            return bill.Insert(dal);
        }
        public bool UpdateSumPrice(double SUMPRICE,String ID_BIL)
        {
            return bill.UpdateSumPrice(SUMPRICE, ID_BIL);
        }
        public bool UpdateSubPrice(double SUBPRICE, String ID_BIL)
        {
            return bill.UpdateSubPrice(SUBPRICE, ID_BIL);
        }
        public bool UpdateStatus(String ID_BIL, string status)
        {
            return bill.UpdateStatus(ID_BIL, status);
        }
    }
}
