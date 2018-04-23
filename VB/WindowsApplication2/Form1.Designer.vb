Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication2
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.myWIzard1 = New WindowsApplication2.MyWizard()
			Me.welcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage()
			Me.wizardPage1 = New DevExpress.XtraWizard.WizardPage()
			Me.completionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup8 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup4 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup5 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup6 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup7 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
			CType(Me.myWIzard1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.myWIzard1.SuspendLayout()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myWIzard1
			' 
			Me.myWIzard1.Controls.Add(Me.welcomeWizardPage1)
			Me.myWIzard1.Controls.Add(Me.wizardPage1)
			Me.myWIzard1.Controls.Add(Me.completionWizardPage1)
			Me.myWIzard1.Name = "myWIzard1"
			Me.myWIzard1.NavBar = Me.navBarControl1
			Me.myWIzard1.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() { Me.welcomeWizardPage1, Me.wizardPage1, Me.completionWizardPage1})
			Me.myWIzard1.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero
'			Me.myWIzard1.Click += New System.EventHandler(Me.myWIzard1_Click);
			' 
			' welcomeWizardPage1
			' 
			Me.welcomeWizardPage1.Name = "welcomeWizardPage1"
			Me.welcomeWizardPage1.Size = New System.Drawing.Size(503, 402)
			' 
			' wizardPage1
			' 
			Me.wizardPage1.Name = "wizardPage1"
			Me.wizardPage1.Size = New System.Drawing.Size(503, 402)
			' 
			' completionWizardPage1
			' 
			Me.completionWizardPage1.Name = "completionWizardPage1"
			Me.completionWizardPage1.Size = New System.Drawing.Size(503, 402)
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup4
			Me.navBarControl1.ContentButtonHint = Nothing
			Me.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup4, Me.navBarGroup5, Me.navBarGroup6, Me.navBarGroup7, Me.navBarGroup8})
			Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5, Me.navBarItem6})
			Me.navBarControl1.Location = New System.Drawing.Point(0, 0)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 140
			Me.navBarControl1.Size = New System.Drawing.Size(150, 480)
			Me.navBarControl1.TabIndex = 10
			Me.navBarControl1.Text = "navBarControl1"
			Me.navBarControl1.View = New DevExpress.XtraNavBar.ViewInfo.SkinExplorerBarViewInfoRegistrator()
			' 
			' navBarGroup8
			' 
			Me.navBarGroup8.Caption = "navBarGroup8"
			Me.navBarGroup8.Expanded = True
			Me.navBarGroup8.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6)})
			Me.navBarGroup8.Name = "navBarGroup8"
			' 
			' navBarItem6
			' 
			Me.navBarItem6.Caption = "navBarItem6"
			Me.navBarItem6.Name = "navBarItem6"
			' 
			' navBarGroup4
			' 
			Me.navBarGroup4.Caption = "navBarGroup4"
			Me.navBarGroup4.Expanded = True
			Me.navBarGroup4.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1)})
			Me.navBarGroup4.Name = "navBarGroup4"
			' 
			' navBarItem1
			' 
			Me.navBarItem1.Caption = "navBarItem1"
			Me.navBarItem1.Name = "navBarItem1"
			' 
			' navBarGroup5
			' 
			Me.navBarGroup5.Caption = "navBarGroup5"
			Me.navBarGroup5.Expanded = True
			Me.navBarGroup5.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2)})
			Me.navBarGroup5.Name = "navBarGroup5"
			' 
			' navBarItem2
			' 
			Me.navBarItem2.Caption = "navBarItem2"
			Me.navBarItem2.Name = "navBarItem2"
			' 
			' navBarGroup6
			' 
			Me.navBarGroup6.Caption = "navBarGroup6"
			Me.navBarGroup6.Expanded = True
			Me.navBarGroup6.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4)})
			Me.navBarGroup6.Name = "navBarGroup6"
			' 
			' navBarItem4
			' 
			Me.navBarItem4.Caption = "navBarItem4"
			Me.navBarItem4.Name = "navBarItem4"
			' 
			' navBarGroup7
			' 
			Me.navBarGroup7.Caption = "navBarGroup7"
			Me.navBarGroup7.Expanded = True
			Me.navBarGroup7.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5)})
			Me.navBarGroup7.Name = "navBarGroup7"
			' 
			' navBarItem5
			' 
			Me.navBarItem5.Caption = "navBarItem5"
			Me.navBarItem5.Name = "navBarItem5"
			' 
			' navBarItem3
			' 
			Me.navBarItem3.Caption = "navBarItem3"
			Me.navBarItem3.Name = "navBarItem3"
			' 
			' navBarGroup1
			' 
			Me.navBarGroup1.Caption = "navBarGroup1"
			Me.navBarGroup1.Expanded = True
			Me.navBarGroup1.Name = "navBarGroup1"
			' 
			' navBarGroup2
			' 
			Me.navBarGroup2.Caption = "navBarGroup1"
			Me.navBarGroup2.Expanded = True
			Me.navBarGroup2.Name = "navBarGroup2"
			' 
			' navBarGroup3
			' 
			Me.navBarGroup3.Caption = "navBarGroup3"
			Me.navBarGroup3.Expanded = True
			Me.navBarGroup3.Name = "navBarGroup3"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(713, 564)
			Me.Controls.Add(Me.myWIzard1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myWIzard1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.myWIzard1.ResumeLayout(False)
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents myWIzard1 As MyWizard
		Private welcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
		Private wizardPage1 As DevExpress.XtraWizard.WizardPage
		Private completionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroup6 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem4 As DevExpress.XtraNavBar.NavBarItem
		Private navBarGroup4 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem
		Private navBarGroup5 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem
		Private navBarGroup7 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup8 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem5 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem6 As DevExpress.XtraNavBar.NavBarItem

	End Class
End Namespace

