using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCoffee_DTO
{
    public class DTO_TABLE
    {
        private int _NUMBER;
        private string _STATUS;

        public DTO_TABLE() { }
        public DTO_TABLE(int NUMBER, String STATUS)
        {
            _NUMBER = NUMBER;
            _STATUS = STATUS;
        }
        public int NUMBER { get => _NUMBER; set => _NUMBER = value; }
        public string STATUS { get => _STATUS; set => _STATUS = value; }
    }
}
