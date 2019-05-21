using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCoffee_DTO
{
    public class DTO_BILL
    {
        private string _ID_BIL;
        private DateTime _DATETIME;
        private string _ID_EMP;
        private string _ID_TAB;
        private string _STATUS;
        private double _SUMPRICE;
        private double _SUBPRICE;

        public DTO_BILL() { }
        public DTO_BILL(string ID_BIL, DateTime DATETIME, string ID_EMP, String ID_TAB
            , string STATUS, double SUMPRICE, double SUBPRICE)
        {
            _ID_BIL = ID_BIL;
            this.DATETIME = DATETIME;
            this.ID_EMP = ID_EMP;
            this.ID_TAB = ID_TAB;
            this.STATUS = STATUS;
            this.SUMPRICE = SUMPRICE;
            this.SUBPRICE = SUBPRICE;
        }
        public string ID_BIL { get => _ID_BIL; set => _ID_BIL = value; }
        public DateTime DATETIME { get => _DATETIME; set => _DATETIME = value; }
        public string ID_EMP { get => _ID_EMP; set => _ID_EMP = value; }
        public string ID_TAB { get => _ID_TAB; set => _ID_TAB = value; }
        public string STATUS { get => _STATUS; set => _STATUS = value; }
        public double SUMPRICE { get => _SUMPRICE; set => _SUMPRICE = value; }
        public double SUBPRICE { get => _SUBPRICE; set => _SUBPRICE = value; }
    }
}
