
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
    
public partial class VCAS_REF_forms
{

    public int Id { get; set; }

    public string txtInput_01 { get; set; }

    public string txtInput_02 { get; set; }

    public string txtInput_03 { get; set; }

    public string txtInput_04 { get; set; }

    public string txtInput_05 { get; set; }

    public string checkInput_01 { get; set; }

    public string checkInput_02 { get; set; }

    public string checkInput_03 { get; set; }

    public string selectInput_01 { get; set; }

    public string selectInput_02 { get; set; }

    public string selectInput_03 { get; set; }

    public string txtAreaInput_01 { get; set; }

    public string txtAreaInput_02 { get; set; }

    public string txtAreaInput_03 { get; set; }

    public string fileInput_01 { get; set; }

    public string fileInput_02 { get; set; }

    public string formBtn { get; set; }

    public int FK_formsId { get; set; }

    public string frmHeader { get; set; }

    public string frmFooter { get; set; }

    public string signatureBox { get; set; }



    public virtual VCAS_forms VCAS_forms { get; set; }

}

}
