Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Reports
Imports DevExpress.ExpressApp

Namespace WinSample.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal objectSpace As DevExpress.ExpressApp.IObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			If ObjectSpace.GetObjects(Of DomainObject1)().Count = 0 Then
				Dim i As Double = 1
				Dim inc As Double = 1.0 / 20.0
				Do While i < 3
					Dim do1 As DomainObject1 = ObjectSpace.CreateObject(Of DomainObject1)()
					i += inc
					do1.Property1 = CInt(Fix(i))
					i += inc
					do1.Property2 = CInt(Fix(i))
					i += inc
					do1.Property3 = CInt(Fix(i))
					i += inc
					do1.Property4 = CInt(Fix(i))
					i += inc
					do1.Property5 = CInt(Fix(i))
					i += inc
					do1.Property6 = CInt(Fix(i))
					do1.Save()
				Loop
			End If
			CreateReport("XafReport")
		End Sub
		Private Sub CreateReport(ByVal reportName As String)
			Dim reportdata As ReportData = ObjectSpace.FindObject(Of ReportData)(New BinaryOperator("Name", reportName))
			If reportdata Is Nothing Then
				reportdata = ObjectSpace.CreateObject(Of ReportData)()
				Dim rep As New XafReport()
				rep.ObjectSpace = ObjectSpace
				rep.LoadLayout(Me.GetType().Assembly.GetManifestResourceStream("Reports." & reportName & ".repx"))
				rep.ReportName = reportName
				reportdata.SaveReport(rep)
			End If

		End Sub
	End Class
End Namespace
