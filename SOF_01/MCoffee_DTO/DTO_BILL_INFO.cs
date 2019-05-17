using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCoffee_DTO
{
    public class DTO_BILL_INFO
    {
        private String id;
        private String id_fod;
        private String id_bill;
        private int icount;
        private Double price;

        public String ID
        {
            get { return id; }
            set { id = value; }
        }

        public String ID_FOD
        {
            get { return id_fod; }
            set { id_fod = value; }
        }

        public String ID_BIL
        {
            get { return id_bill; }
            set { id_bill = value; }
        }

        public int COUNT
        {
            get { return icount; }
            set { icount = value; }
        }

        public Double PRICE
        {
            get { return price; }
            set { price = value; }
        }

        public DTO_BILL_INFO()
        {

        }

        public DTO_BILL_INFO(String id, String id_fod, String id_bill, int icount, Double price = 0)
        {
            ID = id;
            ID_FOD = id_fod;
            ID_BIL = id_bill;
            COUNT = icount;
            PRICE = price;
        }
    }
}
