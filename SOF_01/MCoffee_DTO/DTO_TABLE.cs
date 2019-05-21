using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCoffee_DTO
{
    public class DTO_TABLE
    {
        private string _ID_TAB;
        private string _NUMBER; 
        private string _AREA;
        private int _STATUS;

        public DTO_TABLE() { }
        public DTO_TABLE(string ID_TAB, string NUMBER, string AREA, int STATUS)
        {
            this.ID_TAB = ID_TAB;
            this.NUMBER = NUMBER;
            this.AREA = AREA;
            this.STATUS = STATUS;
        }

        public string ID_TAB { get => _ID_TAB; set => _ID_TAB = value; }
        public string NUMBER { get => _NUMBER; set => _NUMBER = value; }
        public string AREA { get => _AREA; set => _AREA = value; }
        public int STATUS { get => _STATUS; set => _STATUS = value; }
    }
}
