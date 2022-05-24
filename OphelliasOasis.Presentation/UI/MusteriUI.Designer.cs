
namespace OphelliasOasis.Presentation.UI
{
    partial class MusteriUI
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
            DevExpress.Utils.ContextButton contextButton2 = new DevExpress.Utils.ContextButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriUI));
            this.tgsTema = new DevExpress.XtraEditors.ToggleSwitch();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnYoneticiGiris = new DevExpress.XtraBars.BarButtonItem();
            this.btnCalisanGiris = new DevExpress.XtraBars.BarButtonItem();
            this.btnRezervasyonIslemleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnRezervasyonIptal = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.slider = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)(this.tgsTema.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // tgsTema
            // 
            this.tgsTema.Location = new System.Drawing.Point(5, 6);
            this.tgsTema.Name = "tgsTema";
            this.tgsTema.Properties.OffText = "Off";
            this.tgsTema.Properties.OnText = "On";
            this.tgsTema.Size = new System.Drawing.Size(95, 20);
            this.tgsTema.TabIndex = 1;
            this.tgsTema.Toggled += new System.EventHandler(this.tgsTema_Toggled);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnYoneticiGiris),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCalisanGiris),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRezervasyonIslemleri)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // btnYoneticiGiris
            // 
            this.btnYoneticiGiris.Caption = "Yönetici Girişi";
            this.btnYoneticiGiris.Id = 0;
            this.btnYoneticiGiris.ImageOptions.SvgImage = global::OphelliasOasis.Presentation.Properties.Resources.bo_lead;
            this.btnYoneticiGiris.Name = "btnYoneticiGiris";
            // 
            // btnCalisanGiris
            // 
            this.btnCalisanGiris.Caption = "Çalışan Girişi";
            this.btnCalisanGiris.Id = 1;
            this.btnCalisanGiris.ImageOptions.SvgImage = global::OphelliasOasis.Presentation.Properties.Resources.bo_position;
            this.btnCalisanGiris.Name = "btnCalisanGiris";
            // 
            // btnRezervasyonIslemleri
            // 
            this.btnRezervasyonIslemleri.Caption = "Rezervasyon İslemleri";
            this.btnRezervasyonIslemleri.Id = 2;
            this.btnRezervasyonIslemleri.ImageOptions.SvgImage = global::OphelliasOasis.Presentation.Properties.Resources.editnames;
            this.btnRezervasyonIslemleri.Name = "btnRezervasyonIslemleri";
            // 
            // btnRezervasyonIptal
            // 
            this.btnRezervasyonIptal.Caption = "Rezervasyon İptal et";
            this.btnRezervasyonIptal.Id = 3;
            this.btnRezervasyonIptal.ImageOptions.SvgImage = global::OphelliasOasis.Presentation.Properties.Resources.deletedatasource;
            this.btnRezervasyonIptal.Name = "btnRezervasyonIptal";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnYoneticiGiris,
            this.btnCalisanGiris,
            this.btnRezervasyonIslemleri,
            this.btnRezervasyonIptal});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(833, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 589);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(833, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 589);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(833, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 589);
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dropDownButton1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.dropDownButton1.DropDownControl = this.popupMenu1;
            this.dropDownButton1.Location = new System.Drawing.Point(677, 2);
            this.dropDownButton1.Name = "dropDownButton1";
            this.barManager1.SetPopupContextMenu(this.dropDownButton1, this.popupMenu1);
            this.dropDownButton1.Size = new System.Drawing.Size(154, 27);
            this.dropDownButton1.TabIndex = 15;
            this.dropDownButton1.Text = "Sisteme Giriş Yap";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dropDownButton1);
            this.panelControl1.Controls.Add(this.tgsTema);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(833, 31);
            this.panelControl1.TabIndex = 3;
            // 
            // slider
            // 
            this.slider.AllowLooping = true;
            this.slider.AnimationTime = 5000;
            this.slider.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.slider.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.slider.ContextButtonOptions.AnimationType = DevExpress.Utils.ContextAnimationType.None;
            contextButton2.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center;
            contextButton2.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Center;
            contextButton2.AppearanceHover.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            contextButton2.AppearanceHover.ForeColor = System.Drawing.Color.White;
            contextButton2.AppearanceHover.Options.UseFont = true;
            contextButton2.AppearanceHover.Options.UseForeColor = true;
            contextButton2.AppearanceHover.Options.UseTextOptions = true;
            contextButton2.AppearanceHover.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            contextButton2.AppearanceNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            contextButton2.AppearanceNormal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            contextButton2.AppearanceNormal.Options.UseFont = true;
            contextButton2.AppearanceNormal.Options.UseForeColor = true;
            contextButton2.AppearanceNormal.Options.UseTextOptions = true;
            contextButton2.AppearanceNormal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            contextButton2.Caption = "Rezervasyon Yap";
            contextButton2.Id = new System.Guid("99298486-9028-47a8-8d5f-8fa46f6fc499");
            contextButton2.MaxWidth = 1200;
            contextButton2.Name = "btnRezervasyonYap";
            this.slider.ContextButtons.Add(contextButton2);
            this.slider.CurrentImageIndex = 0;
            this.slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slider.Images.Add(((System.Drawing.Image)(resources.GetObject("slider.Images"))));
            this.slider.Images.Add(((System.Drawing.Image)(resources.GetObject("slider.Images1"))));
            this.slider.Images.Add(((System.Drawing.Image)(resources.GetObject("slider.Images2"))));
            this.slider.Images.Add(((System.Drawing.Image)(resources.GetObject("slider.Images3"))));
            this.slider.Images.Add(((System.Drawing.Image)(resources.GetObject("slider.Images4"))));
            this.slider.Location = new System.Drawing.Point(0, 31);
            this.slider.Name = "slider";
            this.slider.ScrollButtonFadeAnimationTime = 1;
            this.slider.Size = new System.Drawing.Size(833, 558);
            this.slider.TabIndex = 5;
            // 
            // MusteriUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 589);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriUI";
            this.Load += new System.EventHandler(this.MusteriUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tgsTema.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.ToggleSwitch tgsTema;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        protected internal DevExpress.XtraEditors.Controls.ImageSlider slider;
        protected internal DevExpress.XtraBars.BarButtonItem btnYoneticiGiris;
        protected internal DevExpress.XtraBars.BarButtonItem btnCalisanGiris;
        protected internal DevExpress.XtraBars.BarButtonItem btnRezervasyonIslemleri;
        protected internal DevExpress.XtraBars.BarButtonItem btnRezervasyonIptal;
    }
}