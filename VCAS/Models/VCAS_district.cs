//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VCAS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VCAS_district
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int FK_location { get; set; }
        public int FK_usersId { get; set; }
    
        public virtual VCAS_users VCAS_users { get; set; }
        public virtual VCAS_council VCAS_council { get; set; }
    }
}
