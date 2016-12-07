using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Persistent.Base;

namespace testXaf001.Module.BusinessObjects.Muhasebe
{
    [DefaultClassOptions]
    public partial class MBELGETIPI
    {
        public MBELGETIPI(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
