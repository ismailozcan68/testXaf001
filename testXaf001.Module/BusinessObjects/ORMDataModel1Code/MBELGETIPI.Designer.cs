﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace testXaf001.Module.BusinessObjects.Muhasebe
{

    public partial class MBELGETIPI : XPLiteObject
    {
        string fBELGETIPI;
        [Key]
        [Size(20)]
        public string BELGETIPI
        {
            get { return fBELGETIPI; }
            set { SetPropertyValue<string>("BELGETIPI", ref fBELGETIPI, value); }
        }
        string fBELGETIPI_XML;
        [Size(20)]
        public string BELGETIPI_XML
        {
            get { return fBELGETIPI_XML; }
            set { SetPropertyValue<string>("BELGETIPI_XML", ref fBELGETIPI_XML, value); }
        }
    }

}
