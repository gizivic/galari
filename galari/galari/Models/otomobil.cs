//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace galari.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class otomobil
    {
        public int otoID { get; set; }
        public string otomarkasi { get; set; }
        public int müsteriID { get; set; }
        public bool satis { get; set; }
    
        public virtual müsteri müsteri { get; set; }
    }
}
