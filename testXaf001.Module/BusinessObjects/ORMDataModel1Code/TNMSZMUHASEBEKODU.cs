using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace testXaf001.Module.BusinessObjects.Muhasebe
{

    public partial class TNMSZMUHASEBEKODU
    {
        public TNMSZMUHASEBEKODU(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
