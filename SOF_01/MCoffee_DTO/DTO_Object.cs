using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCoffee_DTO
{
    public class DTO_Object
    {
        private String id;
        private String displayname;
        private String id_sup;
        private String id_uni;
        private int number_repo;

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

        public String ID_SUP
        {
            get { return id_sup; }
            set { id_sup = value; }
        }

        public String ID_UNI
        {
            get { return id_uni; }
            set { id_uni = value; }
        }

        public int NUM_REPO
        {
            get { return number_repo; }
            set { number_repo = value; }
        }

        public DTO_Object(String id, String name, String id_sup, String id_uni, int num_repo)
        {
            ID = id;
            DISPLAYNAME = name;
            ID_SUP = id_sup;
            ID_UNI = id_uni;
            NUM_REPO = num_repo;
        }
    }
}
