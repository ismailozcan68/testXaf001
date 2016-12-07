using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Persistent.Base;

namespace testXaf001.Module.BusinessObjects.Muhasebe
{
    [DefaultClassOptions]
    public partial class Ben1
    {
        public Ben1(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
