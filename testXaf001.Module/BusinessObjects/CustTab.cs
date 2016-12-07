using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace testXaf001.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class CustTab : XPObject
    {
        public CustTab(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _custab;
        private string _custabdesc;
        
        public string Custab
        {
            get { return _custab; }
            set { SetPropertyValue("Custab", ref _custab, value); }
        }

        public string Custabdesc
        {
            get { return _custabdesc; }
            set { SetPropertyValue("Custabdesc", ref _custabdesc, value); }
        }

        [Association]
        public XPCollection<Customer> Customer
        {
            get { return GetCollection<Customer>("Customer"); }
        }
    }
}