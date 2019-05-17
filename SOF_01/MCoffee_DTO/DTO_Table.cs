using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCoffee_DTO
{
    public class DTO_Table
    {
        private String id;
        private String number;
        private String area;
        private String limit;
        private String status;

        public String ID
        {
            get { return id; }
            set { id = value; }
        }

        public String NUMBER
        {
            get { return number; }
            set { number = value; }
        }

        public String AREA
        {
            get { return area; }
            set { area = value; }
        }

        public String LIMIT
        {
            get { return limit; }
            set { limit = value; }
        }

        public String STATUS
        {
            get { return status; }
            set { status = value; }
        }

        public DTO_Table()
        {

        }

        public DTO_Table(String id, String number, String area, String limit, String status)
        {
            ID = id;
            NUMBER = number;
            AREA = area;
            LIMIT = limit;
            STATUS = status;
        }
    }
}
