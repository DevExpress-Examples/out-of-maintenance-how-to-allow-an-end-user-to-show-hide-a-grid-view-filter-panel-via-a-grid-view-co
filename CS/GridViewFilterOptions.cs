using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;

namespace FilterPanelCustomBenavior
{
    class GridViewFilterPanelHandler
    {
        GridView ViewSender;
        bool showNewItemsOnlyInColumnPopupMenu_;
        public GridViewFilterPanelHandler(GridView currentGridView)
        {
            ViewSender = currentGridView;
            if (ViewSender != null)
            {                
                ViewSender.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            }
            showNewItemsOnlyInColumnPopupMenu_ = true;
        }

        public bool ShowNewItemsOnlyInColumnPopupMenu
        {
            set { showNewItemsOnlyInColumnPopupMenu_ = value; }    
        }

        DXMenuCheckItem CreateFilterMenuItem(string caption)
        {
            DXMenuCheckItem item = new DXMenuCheckItem(caption, false, null, new EventHandler(OnFilterPanelItemClick));
            return item;
        }

        // Menu item click handler.
        void OnFilterPanelItemClick(object sender, EventArgs e)
        {
            ViewSender.OptionsView.ShowFilterPanelMode = ViewSender.OptionsView.ShowFilterPanelMode == ShowFilterPanelMode.ShowAlways ? ShowFilterPanelMode.Never : ShowFilterPanelMode.ShowAlways;
        }

        void ViewSender_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (showNewItemsOnlyInColumnPopupMenu_)
            {
                if (e.MenuType == GridMenuType.Column)
                    e.Menu.Items.Add(CreateFilterMenuItem(GetCurrentCaptionForMenuItem()));
            }
            else
            {
                if (e.Menu != null)
                {
                    e.Menu.Items.Add(CreateFilterMenuItem(GetCurrentCaptionForMenuItem()));
                }
            }
        }

        string GetCurrentCaptionForMenuItem()
        {
            if (ViewSender.OptionsView.ShowFilterPanelMode == ShowFilterPanelMode.Never)
                return "Show filter panel";
            else
                return "Hide filter panel";
        }

        public void HandleViewPopuMenuShowing(bool handlePopuMenuShowing)
        { 
            if (handlePopuMenuShowing)
                ViewSender.PopupMenuShowing += new PopupMenuShowingEventHandler(ViewSender_PopupMenuShowing);
            else
                ViewSender.PopupMenuShowing -= new PopupMenuShowingEventHandler(ViewSender_PopupMenuShowing);
        }
    }
}
