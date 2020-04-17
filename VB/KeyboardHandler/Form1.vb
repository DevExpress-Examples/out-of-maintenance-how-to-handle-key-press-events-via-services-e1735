Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Portable.Input
#Region "#usings"
Imports DevExpress.Services
Imports DevExpress.XtraRichEdit
#End Region ' #usings

Namespace KeyboardHandler
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			labelControl1.Text = "CTRL-C, CTRL-INS, CTRL-X key combinations are blocked for the RichEdit control"
			richEditControl1.LoadDocument("sample_document.rtf", DocumentFormat.Rtf)
			SubstituteKeyboardService()
		End Sub
#Region "#substservice"
		' ...
		Private Sub SubstituteKeyboardService()
			Dim service As IKeyboardHandlerService = richEditControl1.GetService(Of IKeyboardHandlerService)()
			Dim wrapper As New MyKeyboardHandlerServiceWrapper(service)
			richEditControl1.RemoveService(GetType(IKeyboardHandlerService))
			richEditControl1.AddService(GetType(IKeyboardHandlerService), wrapper)
		End Sub
		'...
		#End Region ' #substservice
	End Class
	#Region "#myservice"
	Public Class MyKeyboardHandlerServiceWrapper
		Inherits KeyboardHandlerServiceWrapper

		Public Sub New(ByVal service As IKeyboardHandlerService)
			MyBase.New(service)
		End Sub

		Public Overrides Sub OnKeyDown(ByVal e As PortableKeyEventArgs)
			If ((e.KeyCode = PortableKeys.C) OrElse (e.KeyCode = PortableKeys.X) OrElse (e.KeyCode = PortableKeys.Insert)) AndAlso e.Control Then
				Return
			End If
			MyBase.OnKeyDown(e)
		End Sub
	End Class
	#End Region ' #myservice





End Namespace