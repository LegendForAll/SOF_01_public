using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCoffee_DTO;
using MCoffee_DAL;
using System.Data;

namespace MCoffee_BUS
{
    public class BUS_FOOD_CATEGORY
    {
        DAL_FOOD_CATEGORY food_category = new DAL_FOOD_CATEGORY();

        public bool Insert(DTO_FOOD_CATEGORY dal)
        {
            return food_category.Insert(dal);
        }
        public bool NextID(ref int NextID)
        {
            return food_category.NextID(ref NextID);
        }
        public bool SelectAll(ref List<DTO_FOOD_CATEGORY> ListCategory)
        {
            return food_category.SelectAll(ref ListCategory);
        }
        public bool Update(DTO_FOOD_CATEGORY dal)
        {
            return food_category.Update(dal);
        }
        public bool Delete(String ID_CAT)
        {
            return food_category.Delete(ID_CAT);
        }
    }
}
