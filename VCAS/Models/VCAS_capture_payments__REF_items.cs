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
    
    public partial class VCAS_capture_payments__REF_items
    {
        public int Id { get; set; }
        public int FK_capture_paymentsId { get; set; }
        public int FK_inventoryId { get; set; }
    
        public virtual VCAS_capture_payments VCAS_capture_payments { get; set; }
        public virtual VCAS_inventory VCAS_inventory { get; set; }
    }
}
