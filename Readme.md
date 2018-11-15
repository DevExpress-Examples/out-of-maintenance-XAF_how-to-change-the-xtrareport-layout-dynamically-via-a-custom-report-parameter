<!-- default file list -->
*Files to look at*:

* [Model.DesignedDiffs.xafml](./CS/WinSample.Module.Win/Model.DesignedDiffs.xafml) (VB: [Model.DesignedDiffs.xafml](./VB/WinSample.Module.Win/Model.DesignedDiffs.xafml))
* [Updater.cs](./CS/WinSample.Module.Win/Updater.cs) (VB: [Updater.vb](./VB/WinSample.Module.Win/Updater.vb))
* [WinModule.cs](./CS/WinSample.Module.Win/WinModule.cs) (VB: [WinModule.vb](./VB/WinSample.Module.Win/WinModule.vb))
* [DomainObject1.cs](./CS/WinSample.Module/DomainObject1.cs) (VB: [DomainObject1.vb](./VB/WinSample.Module/DomainObject1.vb))
* [Model.DesignedDiffs.xafml](./CS/WinSample.Module/Model.DesignedDiffs.xafml) (VB: [Model.DesignedDiffs.xafml](./VB/WinSample.Module/Model.DesignedDiffs.xafml))
* [Module.cs](./CS/WinSample.Module/Module.cs) (VB: [Module.vb](./VB/WinSample.Module/Module.vb))
* [MyReportParametersObject.cs](./CS/WinSample.Module/MyReportParametersObject.cs) (VB: [MyReportParametersObject.vb](./VB/WinSample.Module/MyReportParametersObject.vb))
* [Updater.cs](./CS/WinSample.Module/Updater.cs) (VB: [Updater.vb](./VB/WinSample.Module/Updater.vb))
* [Model.xafml](./CS/WinSample.Win/Model.xafml) (VB: [Model.xafml](./VB/WinSample.Win/Model.xafml))
* [Program.cs](./CS/WinSample.Win/Program.cs) (VB: [Program.vb](./VB/WinSample.Win/Program.vb))
* [WinApplication.cs](./CS/WinSample.Win/WinApplication.cs) (VB: [WinApplication.vb](./VB/WinSample.Win/WinApplication.vb))
<!-- default file list end -->
# How to change the XtraReport layout dynamically via a custom Report Parameters Object


<p>The Report Parameters Object feature is introduced to show the custom filter dialog before previewing XafReport. But, since it can be accessed via the report's scripts (see <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2790">Access Report Filter Parameters in Scripts</a>), it is possible to customize other things, depending on the user's choice, with the help of this feature. This example demonstrates how to manage the grouping depth in XtraReport. The value, passed by the end-user via the dialog shown before the Report Preview, is used to change the visibility of group headers, used for grouping, as shown in the following code:<br />


```cs
<newline/>
using DevExpress.ExpressApp.Reports;<newline/>
using WinSample.Module;<newline/>
<newline/>
private void OnBeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {<newline/>
MyReportParametersObject reportParametersObject = ((XafReport)xafReport1).ReportParametersObject as MyReportParametersObject;<newline/>
if (reportParametersObject != null){<newline/>
  switch (reportParametersObject.GroupDepth){<newline/>
    case 0:<newline/>
      GroupHeader1.Visible = false;<newline/>
      goto case 1;<newline/>
    case 1:<newline/>
      GroupHeader2.Visible = false;<newline/>
      goto case 2;<newline/>
    case 2:<newline/>
      GroupHeader3.Visible = false;<newline/>
      goto case 3;<newline/>
    case 3:<newline/>
      GroupHeader4.Visible = false;<newline/>
      goto case 4;<newline/>
    case 4:<newline/>
      GroupHeader5.Visible = false;<newline/>
      break;<newline/>
  }<newline/>
}<newline/>
}<newline/>

```

<strong>See Also:</strong><br />
<a href="http://documentation.devexpress.com/#XtraReports/CustomDocument2615">Scripting Overview</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E1396">How to use custom ReportParametersObject to filter detail reports ( DetailReportBand )</a></p>

<br/>


