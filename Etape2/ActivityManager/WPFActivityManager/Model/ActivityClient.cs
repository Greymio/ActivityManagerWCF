using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFActivityManager.ActivityService;

namespace WPFActivityManager.Model
{
   public class ActivityClient
    {
        public int IdActivity { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public int? IdSubActivity { get; set; }
        public string Adress { get; set; }
        public int Num { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }


        public static ActivityClient LoadFromService(Activity a)
         {
             return new ActivityClient()
             {
                 IdActivity = a.IdActivity,
                 Libelle = a.Libelle,
                 Description = a.Description,
                 IdSubActivity = a.IdSubActivity,
                 Adress = a.Adress,
                 Num = a.Num,
                 Zip = a.Zip,
                 City = a.City
             };
         }
    }
}
