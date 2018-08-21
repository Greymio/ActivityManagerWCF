using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityManager.Services.Faults
{
    public class ActivityFaultContract
    {
        private DateTime _RequestTime;
        private String _method;
        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }

        public String Method
        {
            get { return _method; }
            set { _method = value; }
        }


        public DateTime RequestTime
        {
            get { return _RequestTime; }
            set { _RequestTime = value; }
        }
    }
}
