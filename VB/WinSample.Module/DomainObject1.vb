Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel

Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace WinSample.Module
	<DefaultClassOptions> _
	Public Class DomainObject1
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private _Property1 As Integer
		Public Property Property1() As Integer
			Get
				Return _Property1
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue("Property1", _Property1, value)
			End Set
		End Property
		Private _Property2 As Integer
		Public Property Property2() As Integer
			Get
				Return _Property2
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue("Property2", _Property2, value)
			End Set
		End Property
		Private _Property3 As Integer
		Public Property Property3() As Integer
			Get
				Return _Property3
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue("Property3", _Property3, value)
			End Set
		End Property
		Private _Property4 As Integer
		Public Property Property4() As Integer
			Get
				Return _Property4
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue("Property4", _Property4, value)
			End Set
		End Property
		Private _Property5 As Integer
		Public Property Property5() As Integer
			Get
				Return _Property5
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue("Property5", _Property5, value)
			End Set
		End Property
		Private _Property6 As Integer
		Public Property Property6() As Integer
			Get
				Return _Property6
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue("Property6", _Property6, value)
			End Set
		End Property
	End Class
End Namespace
