Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraWizard
Imports DevExpress.XtraEditors
Imports System.Windows.Forms.Design
Imports DevExpress.XtraNavBar

Namespace WindowsApplication2
	Public Class MyWizard
		Inherits WizardControl


		Private _NavBar As NavBarControl
		Public Property NavBar() As NavBarControl
			Get
				Return _NavBar
			End Get
			Set(ByVal value As NavBarControl)
				_NavBar = value
			If value IsNot Nothing Then
				value.Parent = NavParentControl
			End If
			value.Dock = DockStyle.Fill
			End Set
		End Property

		Private Const defaultNavBarWidth As Integer = 150
		Protected _NavParentControl As PanelControl

		Public ReadOnly Property NavParentControl() As PanelControl
			Get
				Return _NavParentControl
			End Get

		End Property


		Public Sub New()
			CreateNavParentControl()
		End Sub

		Protected Overrides Function CreateViewInfo() As WizardViewInfo
			Return New MyWizardViewInfo(Me)

		End Function
		Private Sub CreateNavParentControl()
			_NavParentControl = New PanelControl()
			_NavParentControl.Parent = Me
			_NavParentControl.Width = defaultNavBarWidth
			_NavParentControl.BackColor = Color.PaleTurquoise
			_NavParentControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
		End Sub


	End Class
	<Designer(GetType(ParentControlDesigner))> _
	Public Class MyWizardViewInfo
		Inherits WizardViewInfo
		Public Sub New(ByVal control As WizardControl)
			MyBase.New(control)

		End Sub

		Protected Overrides Sub UpdatePagesBounds()
			MyBase.UpdatePagesBounds()
			Dim rect As Rectangle = Model.GetContentBounds()
			CType(WizardControl, MyWizard).NavParentControl.SetBounds(0, rect.Y, (CType(WizardControl, MyWizard)).NavParentControl.Width, rect.Height)
		End Sub

		Protected Overrides Function CreateWizardModelCore(ByVal style As WizardStyle) As WizardModelBase
			If style = WizardStyle.WizardAero Then
				Return New MyWizardAeroModel(Me)
			End If
			Return MyBase.CreateWizardModelCore(style)
		End Function
	End Class

	Public Class MyWizardAeroModel
		Inherits DevExpress.XtraWizard.WizardViewInfo.WizardAeroModel
		Public Sub New(ByVal viewInfo As WizardViewInfo)
			MyBase.New(viewInfo)

		End Sub

		Public Overrides Overloads Function GetContentBounds() As Rectangle
			Dim bounds As Rectangle = MyBase.GetContentBounds()
			Dim widht As Integer = (CType(Wizard, MyWizard)).NavParentControl.Width
			Return New Rectangle(bounds.X + widht, bounds.Y, bounds.Width - widht, bounds.Height)
		End Function

	End Class
End Namespace
