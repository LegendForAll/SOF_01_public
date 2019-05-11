using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCoffee_DTO
{
    public class DTO_User
    {
        private string _Id;
        private string _Name;
        private string _Type;
        private string _Username;
        private string _Password;
        private DateTime _DateStart;
        private string _Address;

        // getter, setter

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

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
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

        public string Username
        {
            get
            {
                return _Username;
            }
            set
            {
                _Username = value;
            }
        }

        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }

        public DateTime DateStart
        {
            get
            {
                return _DateStart;
            }

            set
            {
                _DateStart = value;
            }
        }

        public string Address
        {
            get
            {
                return _Address;
            }

            set
            {
                _Address = value;
            }
        }

        //contructor
        public DTO_User() { }
        public DTO_User(string SId, string SName, string SType, string SUsername, string SPassword, DateTime SDateStart, string SAddress)
        {
            this.Id = SId;
            this.Name = SName;
            this.Type = SType;
            this.Username = SUsername;
            this.Password = SPassword;
            this.DateStart = SDateStart;
            this.Address = SAddress;
        }

    }
}
