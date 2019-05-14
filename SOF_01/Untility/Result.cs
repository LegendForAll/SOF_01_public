using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untility
{
    public class Result
    {
        private String message;
        private bool flag;

        public String Message
        {
            get { return message; }
            set { message = value; }
        }

        public bool Flag
        {
            get { return flag; }
            set { flag = value; }
        }

        public Result(bool flag)
        {
            Flag = flag;
        }

        public Result(bool flag, String messg)
        {
            Flag = flag;
            Message = messg;
        }
    }
}
