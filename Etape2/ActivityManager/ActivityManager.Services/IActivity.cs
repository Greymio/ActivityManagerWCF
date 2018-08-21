using ActivityManager.DAL.ClientModel;
using ActivityManager.Services.Faults;
using ActivityManager.Services.MessageContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ActivityManager.Services
{
    [ServiceContract(Name="ActivityService", Namespace="http://www.BestDev.be/ActivityManager")]
    public interface IActivity
    {
        //[OperationContract]
        //[FaultContract(typeof(ActivityFaultContract))]
        //List<Activity> getActivities();

        [OperationContract]
        [FaultContract(typeof(ActivityFaultContract))]
        ActivityCollectionResponseMessage getActivities(ActivityManagerRequestMessage reqMsgs);

        [OperationContract]
        [FaultContract(typeof(ActivityFaultContract))]
        List<Activity> getActivitiesOnDate(DateTime TheDate);

        [OperationContract]
        [FaultContract(typeof(ActivityFaultContract))]
        bool SaveActivity(Activity AToInsert);
    }
}
