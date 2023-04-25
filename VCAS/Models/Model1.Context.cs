﻿

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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Linq;


public partial class ModelContainer : DbContext
{
    public ModelContainer()
        : base("name=ModelContainer")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<VCAS_debitTrans> VCAS_debitTrans1 { get; set; }

    public virtual DbSet<VCAS_creditTrans> VCAS_creditTrans1 { get; set; }

    public virtual DbSet<VCAS_REF_payment_type> VCAS_REF_payment_type { get; set; }

    public virtual DbSet<VCAS_REF_bank_details> VCAS_REF_bank_details { get; set; }

    public virtual DbSet<VCAS_REF_receiverID_Types> VCAS_REF_receiverID_Types { get; set; }

    public virtual DbSet<VCAS_users> VCAS_users { get; set; }

    public virtual DbSet<VCAS_REF_userRoles> VCAS_REF_userRoles { get; set; }

    public virtual DbSet<VCAS_reports> VCAS_reports { get; set; }

    public virtual DbSet<VCAS_district> VCAS_district { get; set; }

    public virtual DbSet<VCAS_supportDocs> VCAS_supportDocs { get; set; }

    public virtual DbSet<VCAS_expenses> VCAS_expenses { get; set; }

    public virtual DbSet<VCAS_issuedChecks> VCAS_issuedChecks { get; set; }

    public virtual DbSet<VCAS_session> VCAS_session { get; set; }

    public virtual DbSet<VCAS_REF_items_location> VCAS_REF_items_location { get; set; }

    public virtual DbSet<VCAS_REF_expense_location> VCAS_REF_expense_location { get; set; }

    public virtual DbSet<VCAS_REF_reports_params> VCAS_REF_reports_params { get; set; }

    public virtual DbSet<VCAS_customer> VCAS_customer { get; set; }

    public virtual DbSet<VCAS_REF_order_status> VCAS_REF_order_status { get; set; }

    public virtual DbSet<VCAS_REF_items> VCAS_REF_items { get; set; }

    public virtual DbSet<VCAS_forms> VCAS_forms { get; set; }

    public virtual DbSet<VCAS_council> VCAS_council { get; set; }

    public virtual DbSet<VCAS_REF_forms> VCAS_REF_forms { get; set; }

    public virtual DbSet<VCAS_inventory> VCAS_inventory { get; set; }

    public virtual DbSet<VCAS_orders> VCAS_orders { get; set; }

    public virtual DbSet<VCAS_capture_payments> VCAS_capture_payments { get; set; }

    public virtual DbSet<VCAS_debitAccounts> VCAS_debitAccounts { get; set; }

    public virtual DbSet<VCAS_reconcile> VCAS_reconcile { get; set; }

    public virtual DbSet<VCAS_deposit> VCAS_deposit { get; set; }

    public virtual DbSet<VCAS_undepositedFunds> VCAS_undepositedFunds { get; set; }


    public virtual int usp_DebitReducingbalance(Nullable<double> amt, Nullable<short> icID, Nullable<short> daID)
    {

        var amtParameter = amt.HasValue ?
            new ObjectParameter("amt", amt) :
            new ObjectParameter("amt", typeof(double));


        var icIDParameter = icID.HasValue ?
            new ObjectParameter("icID", icID) :
            new ObjectParameter("icID", typeof(short));


        var daIDParameter = daID.HasValue ?
            new ObjectParameter("daID", daID) :
            new ObjectParameter("daID", typeof(short));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_DebitReducingbalance", amtParameter, icIDParameter, daIDParameter);
    }


    public virtual int usp_DeleteCapturedReceipt(Nullable<int> id)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("Id", id) :
            new ObjectParameter("Id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_DeleteCapturedReceipt", idParameter);
    }


    public virtual int usp_VoidCapturedReceipt(Nullable<int> id)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("Id", id) :
            new ObjectParameter("Id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_VoidCapturedReceipt", idParameter);
    }


    public virtual int usp_UpdateSession(Nullable<int> rol, Nullable<int> loc, string usr)
    {

        var rolParameter = rol.HasValue ?
            new ObjectParameter("rol", rol) :
            new ObjectParameter("rol", typeof(int));


        var locParameter = loc.HasValue ?
            new ObjectParameter("loc", loc) :
            new ObjectParameter("loc", typeof(int));


        var usrParameter = usr != null ?
            new ObjectParameter("usr", usr) :
            new ObjectParameter("usr", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UpdateSession", rolParameter, locParameter, usrParameter);
    }


    public virtual ObjectResult<usp_SelectCreditChart_Result> usp_SelectCreditChart(Nullable<int> loc)
    {

        var locParameter = loc.HasValue ?
            new ObjectParameter("loc", loc) :
            new ObjectParameter("loc", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_SelectCreditChart_Result>("usp_SelectCreditChart", locParameter);
    }


    public virtual ObjectResult<usp_BulkDownloadPayments_Result> usp_BulkDownloadPayments(Nullable<int> loc, string startDate, string endDate)
    {

        var locParameter = loc.HasValue ?
            new ObjectParameter("loc", loc) :
            new ObjectParameter("loc", typeof(int));


        var startDateParameter = startDate != null ?
            new ObjectParameter("startDate", startDate) :
            new ObjectParameter("startDate", typeof(string));


        var endDateParameter = endDate != null ?
            new ObjectParameter("endDate", endDate) :
            new ObjectParameter("endDate", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_BulkDownloadPayments_Result>("usp_BulkDownloadPayments", locParameter, startDateParameter, endDateParameter);
    }


    public virtual ObjectResult<usp_SelectRecon_Result> usp_SelectRecon(Nullable<int> dAccount)
    {

        var dAccountParameter = dAccount.HasValue ?
            new ObjectParameter("dAccount", dAccount) :
            new ObjectParameter("dAccount", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_SelectRecon_Result>("usp_SelectRecon", dAccountParameter);
    }


    public virtual ObjectResult<usp_InsertDeposit_Result> usp_InsertDeposit(Nullable<int> location)
    {

        var locationParameter = location.HasValue ?
            new ObjectParameter("location", location) :
            new ObjectParameter("location", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_InsertDeposit_Result>("usp_InsertDeposit", locationParameter);
    }


    public virtual ObjectResult<usp_SelectDeposit_Result> usp_SelectDeposit(Nullable<int> loc)
    {

        var locParameter = loc.HasValue ?
            new ObjectParameter("loc", loc) :
            new ObjectParameter("loc", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_SelectDeposit_Result>("usp_SelectDeposit", locParameter);
    }


    public virtual int usp_UpdateAcctAmt(Nullable<double> amt, Nullable<int> id)
    {

        var amtParameter = amt.HasValue ?
            new ObjectParameter("amt", amt) :
            new ObjectParameter("amt", typeof(double));


        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UpdateAcctAmt", amtParameter, idParameter);
    }


    public virtual int usp_UpdateUndepositedFundsStatus(Nullable<int> loc)
    {

        var locParameter = loc.HasValue ?
            new ObjectParameter("loc", loc) :
            new ObjectParameter("loc", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UpdateUndepositedFundsStatus", locParameter);
    }


    public virtual int usp_UpdateUndepositedFundsStatus1(Nullable<int> loc, Nullable<int> dID)
    {

        var locParameter = loc.HasValue ?
            new ObjectParameter("loc", loc) :
            new ObjectParameter("loc", typeof(int));


        var dIDParameter = dID.HasValue ?
            new ObjectParameter("dID", dID) :
            new ObjectParameter("dID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UpdateUndepositedFundsStatus1", locParameter, dIDParameter);
    }


    public virtual int usp_UpdateStock(Nullable<int> item, Nullable<int> loc, Nullable<int> id)
    {

        var itemParameter = item.HasValue ?
            new ObjectParameter("item", item) :
            new ObjectParameter("item", typeof(int));


        var locParameter = loc.HasValue ?
            new ObjectParameter("loc", loc) :
            new ObjectParameter("loc", typeof(int));


        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UpdateStock", itemParameter, locParameter, idParameter);
    }

}

}

