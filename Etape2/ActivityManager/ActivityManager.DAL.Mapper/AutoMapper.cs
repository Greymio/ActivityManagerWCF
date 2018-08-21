using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ActivityManager.DAL.Mapper
{
    public static class AutoMapper<T,U>
    {
        public static T Map(U element)
        {
            T retour = Activator.CreateInstance<T>();

            foreach (PropertyInfo item in typeof(U).GetProperties())
            {
                
                if(typeof(T).GetProperties().Where(p=>p.Name==item.Name).Count()>0)
                {
                    typeof(T).GetProperty(item.Name).SetValue(retour, item.GetValue(element));
                }


            }

            return retour;

        }

    }
}
