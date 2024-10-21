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
    
    public partial class VCAS_debitAccounts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VCAS_debitAccounts()
        {
            this.VCAS_debitTrans1 = new HashSet<VCAS_debitTrans>();
            this.VCAS_issuedChecks = new HashSet<VCAS_issuedChecks>();
            this.VCAS_reconcile = new HashSet<VCAS_reconcile>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
        public string acctNum { get; set; }
        public Nullable<double> amount { get; set; }
        public int FK_payment_Type { get; set; }
        public string remittance { get; set; }
        public string payee { get; set; }
        public System.DateTime datetime { get; set; }
        public string attach_statement { get; set; }
        public int FK_location { get; set; }
        public string starting_balance { get; set; }
        public string type { get; set; }
        public string active { get; set; }
    
        public virtual VCAS_council VCAS_council { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VCAS_debitTrans> VCAS_debitTrans1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VCAS_issuedChecks> VCAS_issuedChecks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VCAS_reconcile> VCAS_reconcile { get; set; }
        public virtual VCAS_REF_payment_type VCAS_REF_payment_type { get; set; }
    }
}
