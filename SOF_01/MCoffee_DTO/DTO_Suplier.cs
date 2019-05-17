using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCoffee_DTO
{
 public class DTO_Suplier
    {
        private String id;
        private String displayName;
        private String address;
        private String phoneNumber;
        private DateTime contractDate;

        public String ID
        {
            get { return id; }
            set { id = value; }
        }

        public String DISPLAYNAME
        {
            get { return displayName; }
            set { displayName = value; }
        }

        public String ADDRESS
        {
            get { return address; }
            set { address = value; }
        }

        public String PHONENUMBER
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public DateTime CONTRACTDATE
        {
            get { return contractDate; }
            set { contractDate = value; }
        }

        public DTO_Suplier()
        {

        }

        public DTO_Suplier(String name, String address, String phone, DateTime date)
        {
            DISPLAYNAME = name;
            ADDRESS = address;
            PHONENUMBER = phone;
            CONTRACTDATE = date;
        }

        public DTO_Suplier(String id, String name, String address, String phone, DateTime date)
        {
            ID = id;
            DISPLAYNAME = name;
            ADDRESS = address;
            PHONENUMBER = phone;
            CONTRACTDATE = date;
        }
    }
}
