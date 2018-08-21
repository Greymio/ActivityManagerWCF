using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ActivityManager.Services.MessageContracts
{
    [MessageContract(IsWrapped=false)]
    public class ActivityCollectionResponseMessage
    {
        [MessageBodyMember]
        public List<ActivityManager.DAL.ClientModel.Activity> datas;
    }
}
