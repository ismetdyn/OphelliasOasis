
namespace OphelliasOasis.Presentation.UI
{
    partial class RezervasyonlarUI
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCheckin = new DevExpress.XtraEditors.SimpleButton();
            this.btnCheckout = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.tgsTema = new DevExpress.XtraEditors.ToggleSwitch();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgwRezervasyonlar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tgsTema.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRezervasyonlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnCheckin);
            this.panelControl1.Controls.Add(this.btnCheckout);
            this.panelControl1.Controls.Add(this.btnCikis);
            this.panelControl1.Controls.Add(this.tgsTema);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1234, 46);
            this.panelControl1.TabIndex = 0;
            // 
            // btnCheckin
            // 
            this.btnCheckin.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCheckin.Appearance.Options.UseFont = true;
            this.btnCheckin.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCheckin.AppearanceHovered.Options.UseFont = true;
            this.btnCheckin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCheckin.ImageOptions.SvgImage = global::OphelliasOasis.Presentation.Properties.Resources.actions_arrow4right;
            this.btnCheckin.Location = new System.Drawing.Point(95, 0);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCheckin.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnCheckin.Size = new System.Drawing.Size(156, 46);
            this.btnCheckin.TabIndex = 24;
            this.btnCheckin.Text = "Checkin";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCheckout.Appearance.Options.UseFont = true;
            this.btnCheckout.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCheckout.AppearanceHovered.Options.UseFont = true;
            this.btnCheckout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCheckout.ImageOptions.SvgImage = global::OphelliasOasis.Presentation.Properties.Resources.actions_arrow4right;
            this.btnCheckout.Location = new System.Drawing.Point(1021, 0);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCheckout.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnCheckout.Size = new System.Drawing.Size(163, 46);
            this.btnCheckout.TabIndex = 23;
            this.btnCheckout.Text = "Checkout";
            // 
            // btnCikis
            // 
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCikis.ImageOptions.SvgImage = global::OphelliasOasis.Presentation.Properties.Resources.del;
            this.btnCikis.Location = new System.Drawing.Point(1184, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCikis.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnCikis.Size = new System.Drawing.Size(50, 46);
            this.btnCikis.TabIndex = 22;
            // 
            // tgsTema
            // 
            this.tgsTema.Dock = System.Windows.Forms.DockStyle.Left;
            this.tgsTema.Location = new System.Drawing.Point(0, 0);
            this.tgsTema.Name = "tgsTema";
            this.tgsTema.Properties.OffText = "Off";
            this.tgsTema.Properties.OnText = "On";
            this.tgsTema.Size = new System.Drawing.Size(95, 46);
            this.tgsTema.TabIndex = 21;
            this.tgsTema.Toggled += new System.EventHandler(this.tgsTema_Toggled);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.dgwRezervasyonlar);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 46);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1234, 668);
            this.panelControl2.TabIndex = 1;
            // 
            // dgwRezervasyonlar
            // 
            this.dgwRezervasyonlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwRezervasyonlar.Location = new System.Drawing.Point(0, 0);
            this.dgwRezervasyonlar.MainView = this.gridView1;
            this.dgwRezervasyonlar.Name = "dgwRezervasyonlar";
            this.dgwRezervasyonlar.Size = new System.Drawing.Size(1234, 668);
            this.dgwRezervasyonlar.TabIndex = 19;
            this.dgwRezervasyonlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgwRezervasyonlar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // RezervasyonlarUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCikis;
            this.ClientSize = new System.Drawing.Size(1234, 714);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RezervasyonlarUI";
            this.Text = "Rezervasyonlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tgsTema.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRezervasyonlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ToggleSwitch tgsTema;
        protected internal DevExpress.XtraEditors.SimpleButton btnCikis;
        protected internal DevExpress.XtraEditors.SimpleButton btnCheckout;
        protected internal DevExpress.XtraEditors.SimpleButton btnCheckin;
        protected internal DevExpress.XtraGrid.GridControl dgwRezervasyonlar;
    }
}