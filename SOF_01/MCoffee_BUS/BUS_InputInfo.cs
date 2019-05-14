using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCoffee_DAL;
using MCoffee_DTO;
using Untility;

namespace MCoffee_BUS
{
    public class BUS_InputInfo
    {
        DAL_InputInfo dal_input_info = new DAL_InputInfo();
        public String nextID()
        {
            return dal_input_info.nextID();
        }

        public Result insert(DTO_InputInfo input_info)
        {
            return dal_input_info.insert(input_info);
        }

        public Result update(DTO_InputInfo input_info)
        {
            return dal_input_info.update(input_info);
        }

        public Result delete(String id)
        {
            return dal_input_info.delete(id);
        }

        public List<DTO_InputInfo> SelectAll(String id)
        {
            return dal_input_info.SelectAll(id);
        }
    }
}
