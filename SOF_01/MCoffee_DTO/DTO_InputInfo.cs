using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCoffee_DTO
{
    public class DTO_InputInfo
    {
        private String id;
        private String id_Obj;
        private String id_emp;
        private String id_input;
        private int count;
        private String price_input;

        public String ID
        {
            get { return id; }
            set { id = value; }
        }

        public String ID_OBJ
        {
            get { return id_Obj; }
            set { id_Obj = value; }
        }

        public String ID_EMP
        {
            get { return id_emp; }
            set { id_emp = value; }
        }

        public String ID_INP
        {
            get { return id_input; }
            set { id_input = value; }
        }

        public int COUNT
        {
            get { return count; }
            set { count = value; }
        }

        public String INPUTPRICE
        {
            get { return price_input; }
            set { price_input = value; }
        }

        public DTO_InputInfo()
        {

        }

        public DTO_InputInfo(String id, String id_input, String id_obj, String id_emp, int count, String priceinput)
        {
            ID = id;
            ID_OBJ = id_obj;
            ID_EMP = id_emp;
            ID_INP = id_input;
            COUNT = count;
            INPUTPRICE = priceinput;
        }
    }
}
