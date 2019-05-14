using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCoffee_DTO
{
    public class DTO_Input
    {
        private String id;
        private DateTime date_input;
        
        public String ID
        {
            get { return id; }
            set { id = value; }
        }
      
        public DateTime DATEINPUT
        {
            get { return date_input; }
            set { date_input = value; }
        }

        
        public DTO_Input()
        {

        }

        public DTO_Input(String id, DateTime date)
        {
            ID = id;            
            DATEINPUT = date;
        }
    }
}
