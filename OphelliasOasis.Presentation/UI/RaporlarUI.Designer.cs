
namespace OphelliasOasis.Presentation.UI
{
    partial class RaporlarUI
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
            this.components = new System.ComponentModel.Container();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.dgwRapor = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManagerKaydet = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnKaydetPDF = new DevExpress.XtraBars.BarButtonItem();
            this.btnKaydetEXCEL = new DevExpress.XtraBars.BarButtonItem();
            this.btnKaydet = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenuKaydet = new DevExpress.XtraBars.PopupMenu(this.components);
            this.panelUst = new DevExpress.XtraEditors.PanelControl();
            this.btnYazdir = new DevExpress.XtraEditors.DropDownButton();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnBeklenenDolulukRaporu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnBeklenenOdaGelirRaporu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTesvikRaporu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnGunlukGelenlerRaporu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnGunlukDolulukRaporu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.tgsTema = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraFolderBrowserDialog = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelUst)).BeginInit();
            this.panelUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.dgwRapor);
            this.fluentDesignFormContainer1.Controls.Add(this.panelUst);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(360, 25);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(933, 680);
            this.fluentDesignFormContainer1.TabIndex = 1;
            // 
            // dgwRapor
            // 
            this.dgwRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwRapor.Location = new System.Drawing.Point(0, 45);
            this.dgwRapor.MainView = this.gridView2;
            this.dgwRapor.MenuManager = this.barManagerKaydet;
            this.dgwRapor.Name = "dgwRapor";
            this.dgwRapor.Size = new System.Drawing.Size(933, 635);
            this.dgwRapor.TabIndex = 2;
            this.dgwRapor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.dgwRapor;
            this.gridView2.Name = "gridView2";
            // 
            // barManagerKaydet
            // 
            this.barManagerKaydet.DockControls.Add(this.barDockControlTop);
            this.barManagerKaydet.DockControls.Add(this.barDockControlBottom);
            this.barManagerKaydet.DockControls.Add(this.barDockControlLeft);
            this.barManagerKaydet.DockControls.Add(this.barDockControlRight);
            this.barManagerKaydet.Form = this;
            this.barManagerKaydet.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnKaydetPDF,
            this.btnKaydetEXCEL});
            this.barManagerKaydet.MaxItemId = 14;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 25);
            this.barDockControlTop.Manager = this.barManagerKaydet;
            this.barDockControlTop.Size = new System.Drawing.Size(1293, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 705);
            this.barDockControlBottom.Manager = this.barManagerKaydet;
            this.barDockControlBottom.Size = new System.Drawing.Size(1293, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManagerKaydet;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 680);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1293, 25);
            this.barDockControlRight.Manager = this.barManagerKaydet;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 680);
            // 
            // btnKaydetPDF
            // 
            this.btnKaydetPDF.Caption = "PDF";
            this.btnKaydetPDF.Id = 2;
            this.btnKaydetPDF.ImageOptions.SvgImage = global::OphelliasOasis.Presentation.Properties.Resources.exporttopdf;
            this.btnKaydetPDF.Name = "btnKaydetPDF";
            this.btnKaydetPDF.Tag = "pdf";
            // 
            // btnKaydetEXCEL
            // 
            this.btnKaydetEXCEL.Caption = "EXCEL";
            this.btnKaydetEXCEL.Id = 7;
            this.btnKaydetEXCEL.ImageOptions.SvgImage = global::OphelliasOasis.Presentation.Properties.Resources.exporttoxlsx;
            this.btnKaydetEXCEL.Name = "btnKaydetEXCEL";
            this.btnKaydetEXCEL.Tag = "xlsx";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.AutoSize = true;
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKaydet.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.btnKaydet.DropDownControl = this.popupMenuKaydet;
            this.btnKaydet.ImageOptions.SvgImage = global::OphelliasOasis.Presentation.Properties.Resources.save;
            this.btnKaydet.Location = new System.Drawing.Point(718, 2);
            this.btnKaydet.MenuManager = this.barManagerKaydet;
            this.btnKaydet.Name = "btnKaydet";
            this.barManagerKaydet.SetPopupContextMenu(this.btnKaydet, this.popupMenuKaydet);
            this.btnKaydet.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnKaydet.Size = new System.Drawing.Size(110, 41);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            // 
            // popupMenuKaydet
            // 
            this.popupMenuKaydet.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnKaydetPDF),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnKaydetEXCEL)});
            this.popupMenuKaydet.Manager = this.barManagerKaydet;
            this.popupMenuKaydet.Name = "popupMenuKaydet";
            // 
            // panelUst
            // 
            this.panelUst.Controls.Add(this.btnKaydet);
            this.panelUst.Controls.Add(this.btnYazdir);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(933, 45);
            this.panelUst.TabIndex = 1;
            // 
            // btnYazdir
            // 
            this.btnYazdir.AutoSize = true;
            this.btnYazdir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnYazdir.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.btnYazdir.ImageOptions.SvgImage = global::OphelliasOasis.Presentation.Properties.Resources.actions_print;
            this.btnYazdir.Location = new System.Drawing.Point(828, 2);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnYazdir.Size = new System.Drawing.Size(103, 41);
            this.btnYazdir.TabIndex = 3;
            this.btnYazdir.Text = "Yazdır";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accordionControl1.Appearance.AccordionControl.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Hovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.accordionControl1.Appearance.Group.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.accordionControl1.Appearance.Group.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Hovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Pressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.accordionControl1.Appearance.Item.Pressed.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2});
            this.accordionControl1.Location = new System.Drawing.Point(0, 25);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Padding = new System.Windows.Forms.Padding(5);
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            this.accordionControl1.Size = new System.Drawing.Size(360, 680);
            this.accordionControl1.TabIndex = 2;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnBeklenenDolulukRaporu,
            this.btnBeklenenOdaGelirRaporu,
            this.btnTesvikRaporu});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Raporlar (Yönetici)";
            // 
            // btnBeklenenDolulukRaporu
            // 
            this.btnBeklenenDolulukRaporu.Name = "btnBeklenenDolulukRaporu";
            this.btnBeklenenDolulukRaporu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnBeklenenDolulukRaporu.Tag = "beklenenDolulukRapor";
            this.btnBeklenenDolulukRaporu.Text = "Beklenen Doluluk Raporu";
            // 
            // btnBeklenenOdaGelirRaporu
            // 
            this.btnBeklenenOdaGelirRaporu.Name = "btnBeklenenOdaGelirRaporu";
            this.btnBeklenenOdaGelirRaporu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnBeklenenOdaGelirRaporu.Tag = "beklenenOdaGelirRaporu";
            this.btnBeklenenOdaGelirRaporu.Text = "Beklenen Oda Gelir Raporu";
            // 
            // btnTesvikRaporu
            // 
            this.btnTesvikRaporu.Name = "btnTesvikRaporu";
            this.btnTesvikRaporu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTesvikRaporu.Tag = "tesvikRaporu";
            this.btnTesvikRaporu.Text = "Teşvik Raporu";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnGunlukGelenlerRaporu,
            this.btnGunlukDolulukRaporu});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Raporlar (Çalışan)";
            // 
            // btnGunlukGelenlerRaporu
            // 
            this.btnGunlukGelenlerRaporu.Name = "btnGunlukGelenlerRaporu";
            this.btnGunlukGelenlerRaporu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnGunlukGelenlerRaporu.Tag = "gunlukGelenlerRaporu";
            this.btnGunlukGelenlerRaporu.Text = "Günlük Gelenler Raporu";
            // 
            // btnGunlukDolulukRaporu
            // 
            this.btnGunlukDolulukRaporu.Name = "btnGunlukDolulukRaporu";
            this.btnGunlukDolulukRaporu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnGunlukDolulukRaporu.Tag = "gunlukDolulukOrani";
            this.btnGunlukDolulukRaporu.Text = "Günlük Doluluk Raporu";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(237, 87);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Yazdır";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.tgsTema});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1293, 25);
            this.fluentDesignFormControl1.TabIndex = 3;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.tgsTema);
            // 
            // tgsTema
            // 
            this.tgsTema.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.tgsTema.Caption = "Gece Modu";
            this.tgsTema.Id = 0;
            this.tgsTema.Name = "tgsTema";
            this.tgsTema.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.tgsTema_CheckedChanged);
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // xtraFolderBrowserDialog
            // 
            this.xtraFolderBrowserDialog.SelectedPath = "xtraFolderBrowserDialog1";
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
            // RaporlarUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 705);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.Name = "RaporlarUI";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRapor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelUst)).EndInit();
            this.panelUst.ResumeLayout(false);
            this.panelUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.BarToggleSwitchItem tgsTema;
        protected internal DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        protected internal DevExpress.XtraBars.Navigation.AccordionControlElement btnBeklenenDolulukRaporu;
        protected internal DevExpress.XtraBars.Navigation.AccordionControlElement btnBeklenenOdaGelirRaporu;
        protected internal DevExpress.XtraBars.Navigation.AccordionControlElement btnTesvikRaporu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        protected internal DevExpress.XtraBars.Navigation.AccordionControlElement btnGunlukGelenlerRaporu;
        protected internal DevExpress.XtraBars.Navigation.AccordionControlElement btnGunlukDolulukRaporu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        protected internal DevExpress.XtraEditors.XtraFolderBrowserDialog xtraFolderBrowserDialog;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManagerKaydet;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl panelUst;
        protected internal DevExpress.XtraGrid.GridControl dgwRapor;
        protected internal DevExpress.XtraBars.PopupMenu popupMenuKaydet;
        protected internal DevExpress.XtraBars.BarButtonItem btnKaydetPDF;
        protected internal DevExpress.XtraBars.BarButtonItem btnKaydetEXCEL;
        private DevExpress.XtraBars.Bar bar3;
        protected internal DevExpress.XtraEditors.DropDownButton btnKaydet;
        protected internal DevExpress.XtraEditors.DropDownButton btnYazdir;
    }
}