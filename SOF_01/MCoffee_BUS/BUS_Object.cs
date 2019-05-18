using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCoffee_DTO;
using MCoffee_DAL;
using Untility;

namespace MCoffee_BUS
{
    public class BUS_Object
    {
        DAL_Object dal_object = new DAL_Object();
        public bool isExist(String id)
        {
            List<DTO_Object2> objs = new List<DTO_Object2>();
            objs = SelectAll();
            foreach (DTO_Object2 obj in objs)
                if (obj.ID.Equals(id))
                    return true;
            return false;
        }

        public int getNum_Repo(String id)
        {
            return dal_object.getNum_repo(id);
        }

        public String nextID()
        {
            return dal_object.nextID();
        }

        public Result insert(DTO_Object obj)
        {
            return dal_object.insert(obj);
        }

        public Result update(DTO_Object obj)
        {
            return dal_object.update(obj);
        }

        public Result updateNumRepo(String id, int num)
        {
            return dal_object.updateNum_repo(id, num);
        }

        public Result delete(String id)
        {
            return dal_object.delete(id);
        }

        public List<DTO_Object2> SelectAll()
        {
            return dal_object.SelectAll();
        }

        public List<DTO_Object2> Select_SUPLIER(String suplier)
        {
            return dal_object.Select_SUPLIER(suplier);
        }

        public List<DTO_Object2> Select_NAME(String name)
        {
            return dal_object.Select_NAME(name);
        }
    }
}
