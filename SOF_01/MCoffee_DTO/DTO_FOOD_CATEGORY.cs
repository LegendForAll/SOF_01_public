using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCoffee_DTO
{
    public class DTO_FOOD_CATEGORY
    {
        private string _ID_CAT;
        private string _DISPLAYNAME;

        public DTO_FOOD_CATEGORY() { }
        public DTO_FOOD_CATEGORY(String ID_CAT,String DISPLAYNAME)
        {
            _ID_CAT = ID_CAT;
            _DISPLAYNAME = DISPLAYNAME;
        }


        public string ID_CAT { get => _ID_CAT; set => _ID_CAT = value; }
        public string DISPLAYNAME { get => _DISPLAYNAME; set => _DISPLAYNAME = value; }
    }
}
