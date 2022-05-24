
namespace OphelliasOasis.Presentation.UI
{
    partial class MusterilerUI
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
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.tgsTema = new DevExpress.XtraEditors.ToggleSwitch();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgwMusteriler = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tgsTema.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCikis);
            this.panelControl1.Controls.Add(this.tgsTema);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1130, 37);
            this.panelControl1.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCikis.ImageOptions.SvgImage = global::OphelliasOasis.Presentation.Properties.Resources.del;
            this.btnCikis.Location = new System.Drawing.Point(1078, 2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCikis.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnCikis.Size = new System.Drawing.Size(50, 33);
            this.btnCikis.TabIndex = 23;
            // 
            // tgsTema
            // 
            this.tgsTema.Dock = System.Windows.Forms.DockStyle.Left;
            this.tgsTema.Location = new System.Drawing.Point(2, 2);
            this.tgsTema.Name = "tgsTema";
            this.tgsTema.Properties.OffText = "Off";
            this.tgsTema.Properties.OnText = "On";
            this.tgsTema.Size = new System.Drawing.Size(95, 33);
            this.tgsTema.TabIndex = 22;
            this.tgsTema.Toggled += new System.EventHandler(this.tgsTema_Toggled);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgwMusteriler);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 37);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1130, 723);
            this.panelControl2.TabIndex = 2;
            // 
            // dgwMusteriler
            // 
            this.dgwMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwMusteriler.Location = new System.Drawing.Point(2, 2);
            this.dgwMusteriler.MainView = this.gridView1;
            this.dgwMusteriler.Name = "dgwMusteriler";
            this.dgwMusteriler.Size = new System.Drawing.Size(1126, 719);
            this.dgwMusteriler.TabIndex = 2;
            this.dgwMusteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgwMusteriler;
            this.gridView1.Name = "gridView1";
            // 
            // MusterilerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 760);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusterilerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteriler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tgsTema.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ToggleSwitch tgsTema;
        protected internal DevExpress.XtraEditors.SimpleButton btnCikis;
        protected internal DevExpress.XtraGrid.GridControl dgwMusteriler;
    }
}