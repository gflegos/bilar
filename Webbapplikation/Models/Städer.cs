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
    
    public partial class Städer
    {
        public Städer()
        {
            this.Märken = new HashSet<Märken>();
        }
    
        public int id { get; set; }
        public string namn { get; set; }
        public int landid { get; set; }
    
        public virtual Länder Länder { get; set; }
        public virtual ICollection<Märken> Märken { get; set; }
    }
}
