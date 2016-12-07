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
    [DefaultProperty("cust001")]

    public class Customer : BaseObject //XPObject 
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Customer(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string _ledgerCode;
        private string _ledgerName;
        private string _fullname;
        private string _desc;

        public string LedgerCode
        {
            get { return _ledgerCode; }
            set { SetPropertyValue("PersistentProperty", ref _ledgerCode, value); }
        }
        public string LedgeName
        {
            get { return _ledgerName; }
            set { SetPropertyValue("PersistentProperty", ref _ledgerName, value); }
        }

        public string FullName
        {
            get { return _fullname; }
            set { SetPropertyValue<string>("FullName", ref _fullname, value); }
        }

        [Size(2048)]
        public string Desc
        {
            get { return _fullname; }
            set { SetPropertyValue<string>("Desc", ref _desc, value); }
        }


        //ismail ekledi
        [Action(Caption = "Birleştir", ConfirmationMessage = "Emin msiniz ?", ImageName = "Attention", AutoCommit = true)]
        public void ActionMethod()
        {
            this.FullName = this.LedgerCode + this.LedgeName;
        }

        [Action(Caption = "Birleştir2", ConfirmationMessage = "Emin msiniz ?", ImageName = "Attention", AutoCommit = false)]
        public void denemeMethod()
        {
            this.FullName = this.LedgerCode + this.LedgeName + " iso";
        }


        //baglnti
        [Association]
        public XPCollection<CustomerDetail> CustomerDetail
        {
            get { return GetCollection<CustomerDetail>("CustomerDetail"); }
        }

        [Association]
        public XPCollection<CustTab> CustTab
        {
            get { return GetCollection<CustTab>("CustTab"); }
        }

    }
}