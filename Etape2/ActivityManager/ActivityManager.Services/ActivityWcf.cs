using ActivityManager.DAL;
using ActivityManager.DAL.ClientModel;
using ActivityManager.DAL.Mapper;
using ActivityManager.Services.Faults;
using ActivityManager.Services.Infrastructure;
using ActivityManager.Services.MessageContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ActivityManager.Services
{
    
    public class ActivityWcf : IActivity
    {
       // public List<DAL.ClientModel.Activity> getActivities()
        //{

        public ActivityCollectionResponseMessage getActivities(ActivityManagerRequestMessage reqMsgs)
        {
            if (!Licensed.isValid(reqMsgs))
            {
                ActivityFaultContract AFC = new ActivityFaultContract() { RequestTime = DateTime.Now, Method = "getActivities", ErrorMessage = "Wrong License Key" };

                //throw new FaultException<ActivityFaultContract>(AFC, "NO LICENSES");
            }
            List<DAL.ClientModel.Activity> la = null;
            List<DAL.Activity> ld = null;
           using (ActivityDbEntities Db = new ActivityDbEntities())
           {
               ld = Db.Activity.ToList();
           }
            if(ld.Count<1)
            {
                ActivityFaultContract AFC = new ActivityFaultContract(){ RequestTime = DateTime.Now, Method="getActivities", ErrorMessage="No Activity available" };

                throw new FaultException<ActivityFaultContract>(AFC, "No Data");
            }
            else
            {
                la = ld.Select(l => AutoMapper<DAL.ClientModel.Activity, DAL.Activity>.Map(l)).ToList();
            }

            return new ActivityCollectionResponseMessage() { datas = la };
        }

        public List<DAL.ClientModel.Activity> getActivitiesOnDate(DateTime TheDate)
        {

            List<DAL.ClientModel.Activity> la = null;
            List<DAL.Activity> ld = null;
            using (ActivityDbEntities Db = new ActivityDbEntities())
            {
                ld = Db.Activity.Where(a=>a.OrgActivity.Where(o=>o.StartDate==TheDate).Count()>0).ToList();
            }
            if (ld.Count < 1)
            {
                ActivityFaultContract AFC = new ActivityFaultContract() { RequestTime = DateTime.Now, Method = "getActivitiesOnDate", ErrorMessage = string.Format("No Activity available on {0}", TheDate.ToShortDateString()) };

                throw new FaultException<ActivityFaultContract>(AFC, "No Data");
            }
            else
            {
                la = ld.Select(l => AutoMapper<DAL.ClientModel.Activity, DAL.Activity>.Map(l)).ToList();
            }

            return la;
        }

        
        public bool SaveActivity(DAL.ClientModel.Activity AToInsert)
        {
            using (ActivityDbEntities Db = new ActivityDbEntities())
            {
                //1 aller rechercher l'activity
                DAL.Activity aGToInsert = Db.Activity.Single(a => a.IdActivity == AToInsert.IdActivity);

                //2 Mapping
                aGToInsert.Libelle = AToInsert.Libelle;
                aGToInsert.Description = AToInsert.Description;
                aGToInsert.Adress = AToInsert.Adress;
                aGToInsert.Num = AToInsert.Num;
                aGToInsert.Zip = AToInsert.Zip;
                aGToInsert.City = AToInsert.City;
                aGToInsert.IdSubActivity = AToInsert.IdSubActivity;

                try
                {
                    Db.SaveChanges();
                    return true;
                }
                catch (Exception ex )
                {
                    
                ActivityFaultContract AFC = new ActivityFaultContract() { RequestTime = DateTime.Now, Method = "SaveActivity", ErrorMessage = ex.Message };

                throw new FaultException<ActivityFaultContract>(AFC, "Save Error");
                }

            }
        }
    }
}
