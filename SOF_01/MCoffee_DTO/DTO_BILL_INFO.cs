using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCoffee_DTO
{
    public class DTO_BILL_INFO
    {
        private string _ID_BILF;
        private string _ID_FOD;
        private string _ID_BIL;
        private int _COUNT;
        private double _PRICE;

        public DTO_BILL_INFO() { }
        public DTO_BILL_INFO(string ID_BILF, String ID_FOD, string ID_BIL, int COUNT, double PRICE)
        {
            _ID_BILF = ID_BILF;
            _ID_FOD = ID_FOD;
            _ID_BIL = ID_BIL;
            _COUNT = COUNT;
            _PRICE = PRICE;

        }
        public string ID_BILF { get => _ID_BILF; set => _ID_BILF = value; }
        public string ID_FOD { get => _ID_FOD; set => _ID_FOD = value; }
        public string ID_BIL { get => _ID_BIL; set => _ID_BIL = value; }
        public int COUNT { get => _COUNT; set => _COUNT = value; }
        public double PRICE { get => _PRICE; set => _PRICE = value; }

    }
}
