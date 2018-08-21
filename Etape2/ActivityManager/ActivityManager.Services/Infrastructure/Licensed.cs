using ActivityManager.Services.MessageContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityManager.Services.Infrastructure
{
    public static class Licensed
    {
        public static string ValidLicenseKey = "MPE123252";

        public static bool isValid(ActivityManagerRequestMessage reqMsg)
        {
            return reqMsg.LicenceKey == ValidLicenseKey;
        }
    }
}
