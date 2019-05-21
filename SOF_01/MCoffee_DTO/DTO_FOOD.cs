using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCoffee_DTO
{
    public class DTO_FOOD
    {
        private string _ID_FOD; 
        private string _ID_CAT; 
        private string _DISPLAYNAME;
        private double _OUTPUTPRICE;
        private string _PICTURE;

        public DTO_FOOD() { }
        public DTO_FOOD(String ID_FOD, String ID_CAT, String DISPLAYNAME, double OUTPUTPRICE,string PICTURE)
        {
            _ID_FOD = ID_FOD;
            _ID_CAT = ID_CAT;
            _DISPLAYNAME = DISPLAYNAME;
            _OUTPUTPRICE = OUTPUTPRICE;
            this.PICTURE = PICTURE;
        }

        public string ID_FOD { get => _ID_FOD; set => _ID_FOD = value; }
        public string ID_CAT { get => _ID_CAT; set => _ID_CAT = value; }
        public string DISPLAYNAME { get => _DISPLAYNAME; set => _DISPLAYNAME = value; }
        public double OUTPUTPRICE { get => _OUTPUTPRICE; set => _OUTPUTPRICE = value; }
        public string PICTURE { get => _PICTURE; set => _PICTURE = value; }
    }
}
