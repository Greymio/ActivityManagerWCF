//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ActivityManager.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrgActivity
    {
        public int IdActivity { get; set; }
        public int IdOrganisateur { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual Organisator Organisator { get; set; }
    }
}
