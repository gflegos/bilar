//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Webbapplikation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Märken
    {
        public Märken()
        {
            this.Modeller = new HashSet<Modeller>();
        }
    
        public int id { get; set; }
        public string namn { get; set; }
        public int stadid { get; set; }
    
        public virtual ICollection<Modeller> Modeller { get; set; }
        public virtual Städer Städer { get; set; }
    }
}
