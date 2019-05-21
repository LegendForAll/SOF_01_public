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
        private string _NUMBER ;
        private int _SUMPRICE;
        private int _SUBPRICE;
        private int _STATUS;

        public DTO_BILL() { }
        public DTO_BILL(string ID_BIL, String NUMBER, int SUMPRICE, int SUBPRICE,int STATUS)
        {
            _ID_BIL = ID_BIL;
            _NUMBER = NUMBER;
            _SUMPRICE = SUMPRICE;
            _SUBPRICE = SUBPRICE;
            _STATUS = STATUS;
        }
        public string ID_BIL { get => _ID_BIL; set => _ID_BIL = value; }
        public string NUMBER { get => _NUMBER; set => _NUMBER = value; }
        public int SUMPRICE { get => _SUMPRICE; set => _SUMPRICE = value; }
        public int SUBPRICE { get => _SUBPRICE; set => _SUBPRICE = value; }
        public int STATUS { get => _STATUS; set => _STATUS = value; }
    }
}
