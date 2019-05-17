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
        private string _NAMECAT;

        public DTO_FOOD_CATEGORY() { }
        public DTO_FOOD_CATEGORY(String ID_CAT,String NAMECAT)
        {
            _ID_CAT = ID_CAT;
            _NAMECAT = NAMECAT;
        }


        public string ID_CAT { get => _ID_CAT; set => _ID_CAT = value; }
        public string NAMECAT { get => _NAMECAT; set => _NAMECAT = value; }
    }
}
