//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Release_Info
    {
        public int I_ID { get; set; }
        public int E_ID { get; set; }
        public int E_Quantity { get; set; }
        public System.DateTime I_ProdDate { get; set; }
        public string I_Expire { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Release Release { get; set; }
    }
}