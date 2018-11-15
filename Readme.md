<!-- default file list -->
*Files to look at*:

* [MyReportParametersObject.cs](./CS/WinSample.Module/MyReportParametersObject.cs) (VB: [MyReportParametersObject.vb](./VB/WinSample.Module/MyReportParametersObject.vb))
* **[Updater.cs](./CS/WinSample.Module/Updater.cs) (VB: [Updater.vb](./VB/WinSample.Module/Updater.vb))**
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


