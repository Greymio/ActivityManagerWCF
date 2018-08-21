namespace ActivityManager.DAL.ClientModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activity
    {
           
        public int IdActivity { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public Nullable<int> IdSubActivity { get; set; }
        public string Adress { get; set; }
        public int Num { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
    
    }
}
