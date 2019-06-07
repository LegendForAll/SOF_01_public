using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCoffee_DTO
{
    public class DTO_TypeUser
    {
        private string _Id;
        private string _Type;

        public string Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }

        public string Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }

        public DTO_TypeUser() { }
        public DTO_TypeUser(string SId, string SType)
        {
            this.Id = SId;
            this.Type = SType;
        }
    }
}
