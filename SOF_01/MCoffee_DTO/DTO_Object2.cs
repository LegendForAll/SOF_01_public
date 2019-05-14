using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCoffee_DTO
{
    public class DTO_Object2
    {
        private String id;
        private String displayname;
        private String supliername;
        private String unitname;
        private int numrepo;

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

        public String SUPLIERNAME
        {
            get { return supliername; }
            set { supliername = value; }
        }

        public String UNITNAME
        {
            get { return unitname; }
            set { unitname = value; }
        }

        public int NUM_REPO
        {
            get { return numrepo; }
            set { numrepo = value; }
        }

        public DTO_Object2(String id, String displayname, String supliername, String unitname, int numrepo)
        {
            ID = id;
            DISPLAYNAME = displayname;
            SUPLIERNAME = supliername;
            UNITNAME = unitname;
            NUM_REPO = numrepo;
        }
    }
}
