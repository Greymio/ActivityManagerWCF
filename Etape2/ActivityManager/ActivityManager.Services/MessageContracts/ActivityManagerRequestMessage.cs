using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ActivityManager.Services.MessageContracts
{
    [MessageContract(IsWrapped=false)]
    public class ActivityManagerRequestMessage
    {
        [MessageHeader(Name = "LicenceInfo")]
        public string LicenceKey;
    }
}
