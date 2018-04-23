using System;

using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.Reports;

namespace WinSample.Module {
    [NonPersistent]
    public class MyReportParametersObject : ReportParametersObjectBase {
        public MyReportParametersObject(Session session) : base(session) { }
        public override CriteriaOperator GetCriteria() {
            return null;
        }
        public override SortingCollection GetSorting() {
            SortingCollection sorting = new SortingCollection();
            return sorting;
        }
        private int _GroupDepth;
        public int GroupDepth {
            get { return _GroupDepth; }
            set { SetPropertyValue("GroupDepth", ref _GroupDepth, value); }
        }
    }

}