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
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Overrides Function GetCriteria() As CriteriaOperator
			Return Nothing
		End Function
		Public Overrides Function GetSorting() As SortingCollection
			Dim sorting As New SortingCollection()
			Return sorting
		End Function
		Private _GroupDepth As Integer
		Public Property GroupDepth() As Integer
			Get
				Return _GroupDepth
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue("GroupDepth", _GroupDepth, value)
			End Set
		End Property
	End Class

End Namespace