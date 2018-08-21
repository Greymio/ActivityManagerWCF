using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ActivityManager.Test.ProxyActivityNS;
using System.Collections.Generic;
using System.ServiceModel;
using System.Diagnostics;

namespace ActivityManager.Test
{
    [TestClass]
    public class ActivityMangerService
    {
        [TestMethod]
        public void TestGetActivities()
        {

           ActivityServiceClient Cli = new ActivityServiceClient();

           try
           {
               List<Activity> la = Cli.getActivities();
               Assert.IsNotNull(la);
               Assert.AreEqual(1, la.Count);
           }
           catch (FaultException<ActivityFaultContract> Fe)
           {
               Debug.WriteLine(Fe.Reason);
               Debug.WriteLine(Fe.Detail.ErrorMessage);
               Debug.WriteLine(Fe.Detail.RequestTime);
               Debug.WriteLine(Fe.Detail.Method);
               Assert.Fail();
           }

        }
    }
}
