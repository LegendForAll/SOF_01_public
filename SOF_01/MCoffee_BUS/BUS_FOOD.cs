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

        public bool Insert(DTO_FOOD ifood)
        {
            return food.Insert(ifood);
        }
        public bool NextID(ref String NextID)
        {
            return food.NextID(ref NextID);
        }
        public bool SelectAll(ref List<DTO_FOOD> ListFood)
        {
            return food.SelectAll(ref ListFood);
        }
        public bool Select_ID(ref DTO_FOOD _food, string id_food)
        {
            return food.Select_ID(ref _food, id_food);
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
    }
}
