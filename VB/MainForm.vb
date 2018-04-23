Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace FilterPanelCustomBenavior
	Partial Public Class MainForm
		Inherits Form
		Private Customers As New DataTable()
		Private newGridViewFilterHandler As GridViewFilterPanelHandler
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Customers.Columns.Add("FirstName", GetType(String))
			Customers.Columns.Add("SecondName", GetType(String))
			Customers.Columns.Add("BirthDay", GetType(DateTime))
			Customers.Columns.Add("Country", GetType(String))

			Customers.Rows.Add(New Object() { "Ivanov", "Ivan", New DateTime(1981, 10, 15), "Russia" })
			Customers.Rows.Add(New Object() { "Brown", "James", New DateTime(1975, 3, 11), "USA" })
			Customers.Rows.Add(New Object() { "Sidororv", "Mihail", New DateTime(1961, 11, 12), "Russia" })
			Customers.Rows.Add(New Object() { "Petrova", "Irina", New DateTime(1983, 11, 5), "Russia" })
			Customers.Rows.Add(New Object() { "Sheffild", "Monika", New DateTime(1979, 5, 26), "USA" })
			gridControlMain.DataSource = Customers
			newGridViewFilterHandler = New GridViewFilterPanelHandler(gridViewMain)
			radioGroupFilterPanelBehavior.EditValue = True
			checkEditHandlePopuMenu.EditValue = True
		End Sub

		Private Sub radioGroup1_Properties_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroupFilterPanelBehavior.Properties.EditValueChanged
			newGridViewFilterHandler.ShowNewItemsOnlyInColumnPopupMenu = CBool(radioGroupFilterPanelBehavior.EditValue)
		End Sub

		Private Sub checkEditHandlePopuMenu_Properties_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditHandlePopuMenu.Properties.EditValueChanged
			newGridViewFilterHandler.HandleViewPopuMenuShowing(CBool(checkEditHandlePopuMenu.EditValue))
		End Sub
	End Class
End Namespace
