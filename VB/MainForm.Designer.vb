Imports Microsoft.VisualBasic
Imports System
Namespace FilterPanelCustomBenavior
	Partial Public Class MainForm
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
			Me.gridControlMain = New DevExpress.XtraGrid.GridControl()
			Me.gridViewMain = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.radioGroupFilterPanelBehavior = New DevExpress.XtraEditors.RadioGroup()
			Me.checkEditHandlePopuMenu = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.gridControlMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioGroupFilterPanelBehavior.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditHandlePopuMenu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControlMain
			' 
			Me.gridControlMain.Dock = System.Windows.Forms.DockStyle.Top
			Me.gridControlMain.Location = New System.Drawing.Point(0, 0)
			Me.gridControlMain.MainView = Me.gridViewMain
			Me.gridControlMain.Name = "gridControlMain"
			Me.gridControlMain.Size = New System.Drawing.Size(621, 287)
			Me.gridControlMain.TabIndex = 0
			Me.gridControlMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridViewMain})
			' 
			' gridViewMain
			' 
			Me.gridViewMain.GridControl = Me.gridControlMain
			Me.gridViewMain.Name = "gridViewMain"
			' 
			' radioGroupFilterPanelBehavior
			' 
			Me.radioGroupFilterPanelBehavior.Location = New System.Drawing.Point(12, 303)
			Me.radioGroupFilterPanelBehavior.Name = "radioGroupFilterPanelBehavior"
			Me.radioGroupFilterPanelBehavior.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Show filter panel behavior only in column popup menu"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Show filter panel behavior in any grid view popup menu")})
'			Me.radioGroupFilterPanelBehavior.Properties.EditValueChanged += New System.EventHandler(Me.radioGroup1_Properties_EditValueChanged);
			Me.radioGroupFilterPanelBehavior.Size = New System.Drawing.Size(600, 27)
			Me.radioGroupFilterPanelBehavior.TabIndex = 1
			' 
			' checkEditHandlePopuMenu
			' 
			Me.checkEditHandlePopuMenu.Location = New System.Drawing.Point(14, 335)
			Me.checkEditHandlePopuMenu.Name = "checkEditHandlePopuMenu"
			Me.checkEditHandlePopuMenu.Properties.Caption = "Handle grid view popup menu showing event"
'			Me.checkEditHandlePopuMenu.Properties.EditValueChanged += New System.EventHandler(Me.checkEditHandlePopuMenu_Properties_EditValueChanged);
			Me.checkEditHandlePopuMenu.Size = New System.Drawing.Size(301, 19)
			Me.checkEditHandlePopuMenu.TabIndex = 2
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(621, 359)
			Me.Controls.Add(Me.checkEditHandlePopuMenu)
			Me.Controls.Add(Me.radioGroupFilterPanelBehavior)
			Me.Controls.Add(Me.gridControlMain)
			Me.Name = "MainForm"
			Me.Text = "Application main form"
'			Me.Load += New System.EventHandler(Me.MainForm_Load);
			CType(Me.gridControlMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridViewMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioGroupFilterPanelBehavior.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditHandlePopuMenu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControlMain As DevExpress.XtraGrid.GridControl
		Private gridViewMain As DevExpress.XtraGrid.Views.Grid.GridView
		Private WithEvents radioGroupFilterPanelBehavior As DevExpress.XtraEditors.RadioGroup
		Private WithEvents checkEditHandlePopuMenu As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace

