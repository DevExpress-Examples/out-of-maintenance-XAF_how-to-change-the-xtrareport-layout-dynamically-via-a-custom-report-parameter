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
        public MyReportParametersObject(IObjectSpace objectSpace, Type reportDataType) : base(objectSpace, reportDataType) { }
        public override CriteriaOperator GetCriteria() {
            return null;
        }
        public override SortProperty[] GetSorting() {
            return new SortProperty[0];
        }
        private int _GroupDepth;
        public int GroupDepth {
            get { return _GroupDepth; }
            set { _GroupDepth = value; }
        }
    }

}