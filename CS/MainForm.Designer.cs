namespace FilterPanelCustomBenavior
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.radioGroupFilterPanelBehavior = new DevExpress.XtraEditors.RadioGroup();
            this.checkEditHandlePopuMenu = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupFilterPanelBehavior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHandlePopuMenu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlMain.Location = new System.Drawing.Point(0, 0);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.Size = new System.Drawing.Size(621, 287);
            this.gridControlMain.TabIndex = 0;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            // 
            // radioGroupFilterPanelBehavior
            // 
            this.radioGroupFilterPanelBehavior.Location = new System.Drawing.Point(12, 303);
            this.radioGroupFilterPanelBehavior.Name = "radioGroupFilterPanelBehavior";
            this.radioGroupFilterPanelBehavior.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Show filter panel behavior only in column popup menu"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Show filter panel behavior in any grid view popup menu")});
            this.radioGroupFilterPanelBehavior.Properties.EditValueChanged += new System.EventHandler(this.radioGroup1_Properties_EditValueChanged);
            this.radioGroupFilterPanelBehavior.Size = new System.Drawing.Size(600, 27);
            this.radioGroupFilterPanelBehavior.TabIndex = 1;
            // 
            // checkEditHandlePopuMenu
            // 
            this.checkEditHandlePopuMenu.Location = new System.Drawing.Point(14, 335);
            this.checkEditHandlePopuMenu.Name = "checkEditHandlePopuMenu";
            this.checkEditHandlePopuMenu.Properties.Caption = "Handle grid view popup menu showing event";
            this.checkEditHandlePopuMenu.Properties.EditValueChanged += new System.EventHandler(this.checkEditHandlePopuMenu_Properties_EditValueChanged);
            this.checkEditHandlePopuMenu.Size = new System.Drawing.Size(301, 19);
            this.checkEditHandlePopuMenu.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 359);
            this.Controls.Add(this.checkEditHandlePopuMenu);
            this.Controls.Add(this.radioGroupFilterPanelBehavior);
            this.Controls.Add(this.gridControlMain);
            this.Name = "MainForm";
            this.Text = "Application main form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupFilterPanelBehavior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHandlePopuMenu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraEditors.RadioGroup radioGroupFilterPanelBehavior;
        private DevExpress.XtraEditors.CheckEdit checkEditHandlePopuMenu;
    }
}

