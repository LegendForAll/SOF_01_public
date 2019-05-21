using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCoffee_DTO
{
    public class DTO_Menu
    {
        private string _DISPLAYNAME;
        private int _COUNT;
        private Double _PRICE;

        public DTO_Menu() { }
        public DTO_Menu(string DISPLAYNAME, int COUNT, Double PRICE)
        {
            _DISPLAYNAME = DISPLAYNAME;
            _COUNT = COUNT;
            _PRICE = PRICE;
        }
        public string DISPLAYNAME { get => _DISPLAYNAME; set => _DISPLAYNAME = value; }
        public int COUNT { get => _COUNT; set => _COUNT = value; }
        public double PRICE { get => _PRICE; set => _PRICE = value; }
   }
}
