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

    public partial class ZKILIT : XPLiteObject
    {
        string fIPNO;
        [Size(20)]
        public string IPNO
        {
            get { return fIPNO; }
            set { SetPropertyValue<string>("IPNO", ref fIPNO, value); }
        }
        string fKULLANICI;
        [Size(20)]
        public string KULLANICI
        {
            get { return fKULLANICI; }
            set { SetPropertyValue<string>("KULLANICI", ref fKULLANICI, value); }
        }
        DateTime fGDATE;
        public DateTime GDATE
        {
            get { return fGDATE; }
            set { SetPropertyValue<DateTime>("GDATE", ref fGDATE, value); }
        }
        public struct CompoundKey1Struct
        {
            [Persistent("IDNO")]
            public int IDNO { get; set; }
            [Size(5)]
            [Persistent("KAYITTURU")]
            public string KAYITTURU { get; set; }
        }
        [Key, Persistent]
        public CompoundKey1Struct CompoundKey1;
    }

}
