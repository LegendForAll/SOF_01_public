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
    public class BUS_Suplier
    {
        private DAL_Suplier dal_suplier = new DAL_Suplier();

        public bool isExist(String id)
        {
            List<DTO_Suplier> supliers = new List<DTO_Suplier>();
            supliers = SelectAll();
            foreach (DTO_Suplier suplier in supliers)
                if (suplier.ID.Equals(id))
                    return true;
            return false;
        }
        public String nextID()
        {
            return dal_suplier.nextID();
        }

        public Result insert(DTO_Suplier suplier)
        {
            return dal_suplier.insert(suplier);
        }

        public Result update(DTO_Suplier suplier)
        {
            return dal_suplier.update(suplier);
        }

        public Result delete(String id)
        {
            return dal_suplier.delete(id);
        }

        public List<DTO_Suplier> SelectAll()
        {
            return dal_suplier.SelectAll();
        }
    }
}
