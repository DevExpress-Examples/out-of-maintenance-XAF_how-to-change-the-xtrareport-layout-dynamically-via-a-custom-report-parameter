using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Reports;
using DevExpress.ExpressApp;

namespace WinSample.Module
{
    public class Updater : ModuleUpdater
    {
        public Updater(DevExpress.ExpressApp.IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            if (new XPCollection<DomainObject1>(Session).Count == 0) {
                double i = 1;
                double inc = 1.0 / 20.0;
                while (i < 3) {
                    DomainObject1 do1 = new DomainObject1(Session);
                    i += inc;
                    do1.Property1 = (int)i;
                    i += inc;
                    do1.Property2 = (int)i;
                    i += inc;
                    do1.Property3 = (int)i;
                    i += inc;
                    do1.Property4 = (int)i;
                    i += inc;
                    do1.Property5 = (int)i;
                    i += inc;
                    do1.Property6 = (int)i;
                    do1.Save();
                }
            }
            CreateReport("XafReport");
        }
        private void CreateReport(string reportName) {
            ReportData reportdata = Session.FindObject<ReportData>(new BinaryOperator("Name", reportName));
            if (reportdata == null) {
                reportdata = new ReportData(Session);
                XafReport rep = new XafReport();
                rep.ReportName = reportName;
                rep.ObjectSpace = new ObjectSpace(new UnitOfWork(Session.DataLayer), XafTypesInfo.Instance);
                rep.LoadLayout(GetType().Assembly.GetManifestResourceStream(
                   "WinSample.Module.Reports." + reportName + ".repx"));
                reportdata.SaveXtraReport(rep);
                reportdata.Save();
            }
        }
    }
}
