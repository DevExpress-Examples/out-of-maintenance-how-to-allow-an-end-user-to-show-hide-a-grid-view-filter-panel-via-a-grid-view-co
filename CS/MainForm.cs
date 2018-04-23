using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FilterPanelCustomBenavior
{
    public partial class MainForm : Form
    {
        DataTable Customers = new DataTable();
        GridViewFilterPanelHandler newGridViewFilterHandler;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Customers.Columns.Add("FirstName", typeof(string));
            Customers.Columns.Add("SecondName", typeof(string));
            Customers.Columns.Add("BirthDay", typeof(DateTime));
            Customers.Columns.Add("Country", typeof(string));

            Customers.Rows.Add(new object[] { "Ivanov", "Ivan", new DateTime(1981, 10, 15), "Russia" });
            Customers.Rows.Add(new object[] { "Brown", "James", new DateTime(1975, 3, 11), "USA" });
            Customers.Rows.Add(new object[] { "Sidororv", "Mihail", new DateTime(1961, 11, 12), "Russia" });
            Customers.Rows.Add(new object[] { "Petrova", "Irina", new DateTime(1983, 11, 5), "Russia" });
            Customers.Rows.Add(new object[] { "Sheffild", "Monika", new DateTime(1979, 5, 26), "USA" });
            gridControlMain.DataSource = Customers;
            newGridViewFilterHandler = new GridViewFilterPanelHandler(gridViewMain);
            radioGroupFilterPanelBehavior.EditValue = true;
            checkEditHandlePopuMenu.EditValue = true;
        }

        private void radioGroup1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            newGridViewFilterHandler.ShowNewItemsOnlyInColumnPopupMenu = (bool)radioGroupFilterPanelBehavior.EditValue;
        }

        private void checkEditHandlePopuMenu_Properties_EditValueChanged(object sender, EventArgs e)
        {
            newGridViewFilterHandler.HandleViewPopuMenuShowing((bool)checkEditHandlePopuMenu.EditValue);
        }
    }
}
