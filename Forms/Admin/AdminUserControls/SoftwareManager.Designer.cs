namespace File_Acess_Management.Forms.Admin.AdminUserControls
{
    partial class SoftwareManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwareManager));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barAddBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barUpdateBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDeleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barResetBtn = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.resetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.updateBtn = new DevExpress.XtraEditors.SimpleButton();
            this.deleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.addBtn = new DevExpress.XtraEditors.SimpleButton();
            this.softwareNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.softwareIDTxt = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.SoftwareGridControl = new DevExpress.XtraGrid.GridControl();
            this.SoftwareGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.softwareNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareIDTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoftwareGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoftwareGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barAddBtn,
            this.barUpdateBtn,
            this.barDeleteBtn,
            this.barResetBtn});
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barAddBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barUpdateBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barDeleteBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barResetBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barAddBtn
            // 
            this.barAddBtn.Caption = "Add";
            this.barAddBtn.Id = 4;
            this.barAddBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAddBtn.ImageOptions.Image")));
            this.barAddBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barAddBtn.ImageOptions.LargeImage")));
            this.barAddBtn.Name = "barAddBtn";
            this.barAddBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBtn_Click);
            // 
            // barUpdateBtn
            // 
            this.barUpdateBtn.Caption = "Update";
            this.barUpdateBtn.Id = 5;
            this.barUpdateBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barUpdateBtn.ImageOptions.Image")));
            this.barUpdateBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barUpdateBtn.ImageOptions.LargeImage")));
            this.barUpdateBtn.Name = "barUpdateBtn";
            this.barUpdateBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.updateBtn_Click);
            // 
            // barDeleteBtn
            // 
            this.barDeleteBtn.Caption = "Delete";
            this.barDeleteBtn.Id = 6;
            this.barDeleteBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barDeleteBtn.ImageOptions.Image")));
            this.barDeleteBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barDeleteBtn.ImageOptions.LargeImage")));
            this.barDeleteBtn.Name = "barDeleteBtn";
            this.barDeleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_Click);
            // 
            // barResetBtn
            // 
            this.barResetBtn.Caption = "Reset";
            this.barResetBtn.Id = 7;
            this.barResetBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barResetBtn.ImageOptions.Image")));
            this.barResetBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barResetBtn.ImageOptions.LargeImage")));
            this.barResetBtn.Name = "barResetBtn";
            this.barResetBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.resetBtn_Click);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1357, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 760);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1357, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 736);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1357, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 736);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Add";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Delete";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Update";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Reset";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Location = new System.Drawing.Point(20, 73);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(285, 237);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Software Information";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.resetBtn);
            this.layoutControl1.Controls.Add(this.updateBtn);
            this.layoutControl1.Controls.Add(this.deleteBtn);
            this.layoutControl1.Controls.Add(this.addBtn);
            this.layoutControl1.Controls.Add(this.softwareNameTxt);
            this.layoutControl1.Controls.Add(this.softwareIDTxt);
            this.layoutControl1.Location = new System.Drawing.Point(6, 27);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(575, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(275, 184);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(12, 112);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(251, 22);
            this.resetBtn.StyleController = this.layoutControl1;
            this.resetBtn.TabIndex = 9;
            this.resetBtn.Text = "Reset";
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(12, 86);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(251, 22);
            this.updateBtn.StyleController = this.layoutControl1;
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(139, 60);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(124, 22);
            this.deleteBtn.StyleController = this.layoutControl1;
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 60);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(123, 22);
            this.addBtn.StyleController = this.layoutControl1;
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // softwareNameTxt
            // 
            this.softwareNameTxt.Location = new System.Drawing.Point(98, 36);
            this.softwareNameTxt.MenuManager = this.barManager1;
            this.softwareNameTxt.Name = "softwareNameTxt";
            this.softwareNameTxt.Size = new System.Drawing.Size(165, 20);
            this.softwareNameTxt.StyleController = this.layoutControl1;
            this.softwareNameTxt.TabIndex = 5;
            // 
            // softwareIDTxt
            // 
            this.softwareIDTxt.Enabled = false;
            this.softwareIDTxt.Location = new System.Drawing.Point(98, 12);
            this.softwareIDTxt.MenuManager = this.barManager1;
            this.softwareIDTxt.Name = "softwareIDTxt";
            this.softwareIDTxt.Size = new System.Drawing.Size(165, 20);
            this.softwareIDTxt.StyleController = this.layoutControl1;
            this.softwareIDTxt.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(275, 184);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.softwareIDTxt;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(255, 24);
            this.layoutControlItem1.Text = "Software ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(74, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 126);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(255, 38);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.softwareNameTxt;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(255, 24);
            this.layoutControlItem2.Text = "Software Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.addBtn;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(127, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.deleteBtn;
            this.layoutControlItem4.Location = new System.Drawing.Point(127, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(128, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.updateBtn;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(255, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.resetBtn;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 100);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(255, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(139, 86);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(74, 22);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "simpleButton3";
            // 
            // SoftwareGridControl
            // 
            gridLevelNode1.RelationName = "Level1";
            this.SoftwareGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.SoftwareGridControl.Location = new System.Drawing.Point(381, 73);
            this.SoftwareGridControl.MainView = this.SoftwareGrid;
            this.SoftwareGridControl.MenuManager = this.barManager1;
            this.SoftwareGridControl.Name = "SoftwareGridControl";
            this.SoftwareGridControl.Size = new System.Drawing.Size(633, 412);
            this.SoftwareGridControl.TabIndex = 5;
            this.SoftwareGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SoftwareGrid});
            // 
            // SoftwareGrid
            // 
            this.SoftwareGrid.GridControl = this.SoftwareGridControl;
            this.SoftwareGrid.Name = "SoftwareGrid";
            this.SoftwareGrid.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barAddBtn";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barAddBtn";
            this.barButtonItem6.Id = 4;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // SoftwareManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SoftwareGridControl);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SoftwareManager";
            this.Size = new System.Drawing.Size(1357, 780);
            this.Load += new System.EventHandler(this.SoftwareManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.softwareNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareIDTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoftwareGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoftwareGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barAddBtn;
        private DevExpress.XtraBars.BarButtonItem barUpdateBtn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barDeleteBtn;
        private DevExpress.XtraBars.BarButtonItem barResetBtn;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl SoftwareGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView SoftwareGrid;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton updateBtn;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
        private DevExpress.XtraEditors.SimpleButton addBtn;
        private DevExpress.XtraEditors.TextEdit softwareNameTxt;
        private DevExpress.XtraEditors.TextEdit softwareIDTxt;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton resetBtn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
    }
}
