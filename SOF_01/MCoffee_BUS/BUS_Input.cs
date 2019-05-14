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
    public class BUS_Input
    {
        DAL_Input dal_input = new DAL_Input();

        public bool isExist(String id)
        {
            List<DTO_Input> inputs = new List<DTO_Input>();
            inputs = SelectAll();
            foreach (DTO_Input input in inputs)
                if (input.ID.Equals(id))
                    return true;
            return false;
        }

        public String nextID()
        {
            return dal_input.nextID();
        }

        public Result insert(DTO_Input input)
        {
            return dal_input.insert(input);
        }

        public Result update(DTO_Input input)
        {
            return dal_input.update(input);
        }

        public Result delete(String id)
        {
            return dal_input.delete(id);
        }

        public List<DTO_Input> SelectAll()
        {
            return dal_input.SelectAll();
        }
    }
}
