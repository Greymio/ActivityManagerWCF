using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ActivityManager.Services
{
    [ServiceContract]
    interface IOrganisation
    {
        [OperationContract]
        string Hello();
    }
}
