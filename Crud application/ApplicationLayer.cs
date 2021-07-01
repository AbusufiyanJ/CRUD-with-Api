using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud_application
{
    public class ApplicationLayer
    {
        private string _Name;
        private string _PhoneNo;
        private string _JobRole;
        private bool _CurrentStatus;
        private string _Location;

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

        public string PhoneNo
        {
            get
            {
                return _PhoneNo;
            }
            set
            {
                _PhoneNo = value;
            }
        }

        public string JobRole
        {
            get
            {
                return _JobRole;
            }
            set
            {
                _JobRole = value;
            }
        }

        public bool CurrentStatus
        {
            get
            {
                return _CurrentStatus;
            }
            set
            {
                _CurrentStatus = value;
            }
        }

        public string Location
        {
            get
            {
                return _Location;
            }
            set
            {
                _Location = value;
            }
        }
    }
}