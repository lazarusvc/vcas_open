
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
    
public partial class VCAS_orders
{

    public int Id { get; set; }

    public System.DateTime datetime { get; set; }

    public Nullable<double> quantity { get; set; }

    public int FK_order_statusId { get; set; }

    public int FK_customerId { get; set; }

    public int FK_inventoryId { get; set; }

    public Nullable<int> FK_location { get; set; }

    public string comment { get; set; }



    public virtual VCAS_council VCAS_council { get; set; }

    public virtual VCAS_customer VCAS_customer { get; set; }

    public virtual VCAS_inventory VCAS_inventory { get; set; }

    public virtual VCAS_REF_order_status VCAS_REF_order_status { get; set; }

}

}
