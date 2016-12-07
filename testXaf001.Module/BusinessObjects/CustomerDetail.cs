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
    public class CustomerDetail : BaseObject
    {
        public CustomerDetail(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private Customer _customer;
        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetPropertyValue("Email", ref _email, value); }
        }

    
        [Association]
        public Customer xcustomer
        {
            get { return _customer; }
            set { SetPropertyValue("Customer", ref _customer, value); }
        }



    }
}