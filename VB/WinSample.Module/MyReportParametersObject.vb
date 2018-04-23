Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Data.Filtering

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation
Imports DevExpress.ExpressApp.Reports

Namespace WinSample.Module
	<NonPersistent> _
	Public Class MyReportParametersObject
		Inherits ReportParametersObjectBase
		Public Sub New(ByVal objectSpace As IObjectSpace, ByVal reportDataType As Type)
			MyBase.New(objectSpace, reportDataType)
		End Sub
		Public Overrides Function GetCriteria() As CriteriaOperator
			Return Nothing
		End Function
		Public Overrides Function GetSorting() As SortProperty()
			Return New SortProperty(){}
		End Function
		Private _GroupDepth As Integer
		Public Property GroupDepth() As Integer
			Get
				Return _GroupDepth
			End Get
			Set(ByVal value As Integer)
				_GroupDepth = value
			End Set
		End Property
	End Class

End Namespace