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
        private string _NUMBER;
        private string _PRICE;

        public DTO_Menu() { }
        public DTO_Menu(string DISPLAYNAME, String NUMBER, string PRICE)
        {
            _DISPLAYNAME = DISPLAYNAME;
            _NUMBER = NUMBER;
            _PRICE = PRICE;
        }
        public string DISPLAYNAME { get => _DISPLAYNAME; set => _DISPLAYNAME = value; }
        public string NUMBER { get => _NUMBER; set => _NUMBER = value; }
        public string PRICE { get => _PRICE; set => _PRICE = value; }
   }
}
