using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace WinSample.Module {
    [DefaultClassOptions]
    public class DomainObject1 : BaseObject {
        public DomainObject1(Session session) : base(session) { }
        private int _Property1;
        public int Property1 {
            get { return _Property1; }
            set { SetPropertyValue("Property1", ref _Property1, value); }
        }
        private int _Property2;
        public int Property2 {
            get { return _Property2; }
            set { SetPropertyValue("Property2", ref _Property2, value); }
        }
        private int _Property3;
        public int Property3 {
            get { return _Property3; }
            set { SetPropertyValue("Property3", ref _Property3, value); }
        }
        private int _Property4;
        public int Property4 {
            get { return _Property4; }
            set { SetPropertyValue("Property4", ref _Property4, value); }
        }
        private int _Property5;
        public int Property5 {
            get { return _Property5; }
            set { SetPropertyValue("Property5", ref _Property5, value); }
        }
        private int _Property6;
        public int Property6 {
            get { return _Property6; }
            set { SetPropertyValue("Property6", ref _Property6, value); }
        }
    }
}
