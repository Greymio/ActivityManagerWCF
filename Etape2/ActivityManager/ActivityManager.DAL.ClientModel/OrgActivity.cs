
namespace ActivityManager.DAL.ClientModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrgActivity
    {
        public int IdActivity { get; set; }
        public int IdOrganisateur { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
    
    }
}
