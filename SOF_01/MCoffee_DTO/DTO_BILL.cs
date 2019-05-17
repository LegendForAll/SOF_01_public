using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCoffee_DTO
{
    public class DTO_BILL
    {
        private String id;
        private DateTime date;
        private String id_user;
        private String id_table;
        private String status;
        private Double sum_price;
        private Double sub_price;

        public String ID
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime DATETIME
        {
            get { return date; }
            set { date = value; }
        }

        public String ID_EMP
        {
            get { return id_user; }
            set { id_user = value; }
        }

        public String ID_TAB
        {
            get { return id_table; }
            set { id_table = value; }
        }

        public String STATUS
        {
            get { return status; }
            set { status = value; }
        }

        public Double SUMPRICE
        {
            get { return sum_price; }
            set { sum_price = value; }
        }

        public Double SUBPRICE
        {
            get { return sub_price; }
            set { sub_price = value; }
        }

        public DTO_BILL()
        {

        }

        public DTO_BILL(String id, DateTime date, String id_user, String id_table, String status, Double sum_price = 0, Double sub_price = 0)
        {
            ID = id;
            DATETIME = date;
            ID_EMP = id_user;
            ID_TAB = id_table;
            STATUS = status;
            SUMPRICE = sum_price;
            SUBPRICE = sub_price;
        }
    }
}
