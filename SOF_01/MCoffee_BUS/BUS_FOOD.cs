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
    public class BUS_FOOD
    {
        DAL_FOOD food = new DAL_FOOD();

        public bool Insert(DTO_FOOD dal)
        {
            return food.Insert(dal);
        }
        public bool NextID(ref int NextID)
        {
            return food.NextID(ref NextID);
        }
        public bool SelectAll(ref List<DTO_FOOD> ListFood)
        {
            return food.SelectAll(ref ListFood);
        }
        public bool SelectAllByCategory(ref List<DTO_FOOD> ListFood,String Category)
        {
            return food.SelectAllByCategory(ref ListFood, Category);
        }
        public bool Update(DTO_FOOD dal)
        {
            return food.Update(dal);
        }
        public bool Delete(String ID_FOD)
        {
            return food.Delete(ID_FOD);
        }
        public bool Search(ref List<DTO_FOOD> ListFood, String Category, String searchtext)
        {
            return food.Search(ref ListFood, Category, searchtext);

        }
        public bool SelectAllByName(ref DTO_FOOD Food, String Name)
        {
            return food.SelectAllByName(ref Food, Name);
        }
    }
}
