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
    public class BUS_Unit
    {
        DAL_Unit dal_unit = new DAL_Unit();

        public bool isExist(String id)
        {
            List<DTO_Unit> units = new List<DTO_Unit>();
            units = SelectAll();
            foreach (DTO_Unit unit in units)
                if (unit.ID.Equals(id))
                    return true;
            return false;
        }

        public String nextID()
        {
            return dal_unit.nextID();
        }

        public Result insert (DTO_Unit unit)
        {
            return dal_unit.insert(unit);
        }

        public Result update (DTO_Unit unit)
        {
            return dal_unit.update(unit);
        }

        public Result delete (String id)
        {
            return dal_unit.delete(id);
        }

        public List<DTO_Unit> SelectAll()
        {
            return dal_unit.SelectAll();
        }
    }
}
