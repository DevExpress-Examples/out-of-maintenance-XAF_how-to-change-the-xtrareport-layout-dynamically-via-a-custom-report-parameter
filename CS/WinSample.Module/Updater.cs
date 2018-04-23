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
            if (ObjectSpace.GetObjects<DomainObject1>().Count == 0) {
                double i = 1;
                double inc = 1.0 / 20.0;
                while (i < 3) {
                    DomainObject1 do1 = ObjectSpace.CreateObject<DomainObject1>();
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
            ReportData reportdata = ObjectSpace.FindObject<ReportData>(new BinaryOperator("Name", reportName));
            if (reportdata == null) {
                reportdata = ObjectSpace.CreateObject<ReportData>();
                XafReport rep = new XafReport();
                rep.ObjectSpace = ObjectSpace;
                rep.LoadLayout(GetType().Assembly.GetManifestResourceStream(
                   "WinSample.Module.Reports." + reportName + ".repx"));
                rep.ReportName = reportName;
                reportdata.SaveXtraReport(rep);
            }

        }
    }
}
