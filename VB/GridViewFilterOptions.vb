Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Namespace FilterPanelCustomBenavior
	Friend Class GridViewFilterPanelHandler
		Private ViewSender As GridView
		Private showNewItemsOnlyInColumnPopupMenu_ As Boolean
		Public Sub New(ByVal currentGridView As GridView)
			ViewSender = currentGridView
			If ViewSender IsNot Nothing Then
				ViewSender.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
			End If
			showNewItemsOnlyInColumnPopupMenu_ = True
		End Sub

		Public WriteOnly Property ShowNewItemsOnlyInColumnPopupMenu() As Boolean
			Set(ByVal value As Boolean)
				showNewItemsOnlyInColumnPopupMenu_ = value
			End Set
		End Property

		Private Function CreateFilterMenuItem(ByVal caption As String) As DXMenuCheckItem
			Dim item As New DXMenuCheckItem(caption, False, Nothing, New EventHandler(AddressOf OnFilterPanelItemClick))
			Return item
		End Function

		' Menu item click handler.
		Private Sub OnFilterPanelItemClick(ByVal sender As Object, ByVal e As EventArgs)
			ViewSender.OptionsView.ShowFilterPanelMode = If(ViewSender.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.ShowAlways, ShowFilterPanelMode.Never, ShowFilterPanelMode.ShowAlways)
		End Sub

		Private Sub ViewSender_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
			If showNewItemsOnlyInColumnPopupMenu_ Then
				If e.MenuType = GridMenuType.Column Then
					e.Menu.Items.Add(CreateFilterMenuItem(GetCurrentCaptionForMenuItem()))
				End If
			Else
				If e.Menu IsNot Nothing Then
					e.Menu.Items.Add(CreateFilterMenuItem(GetCurrentCaptionForMenuItem()))
				End If
			End If
		End Sub

		Private Function GetCurrentCaptionForMenuItem() As String
			If ViewSender.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never Then
				Return "Show filter panel"
			Else
				Return "Hide filter panel"
			End If
		End Function

		Public Sub HandleViewPopuMenuShowing(ByVal handlePopuMenuShowing As Boolean)
			If handlePopuMenuShowing Then
				AddHandler ViewSender.PopupMenuShowing, AddressOf ViewSender_PopupMenuShowing
			Else
				RemoveHandler ViewSender.PopupMenuShowing, AddressOf ViewSender_PopupMenuShowing
			End If
		End Sub
	End Class
End Namespace
