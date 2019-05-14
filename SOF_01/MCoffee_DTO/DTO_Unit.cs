using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCoffee_DTO
{
    public class DTO_Unit
    {
        private String id;
        private String displayname;

        public String ID
        {
            get { return id; }
            set { id = value; }
        }

        public String DISPLAYNAME
        {
            get { return displayname; }
            set { displayname = value; }
        }

        public DTO_Unit()
        {

        }

        public DTO_Unit(String id, String name)
        {
            ID = id;
            DISPLAYNAME = name;
        }
    }
}
