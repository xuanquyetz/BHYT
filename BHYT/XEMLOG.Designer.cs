namespace BHYT
{
    partial class XEMLOG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XEMLOG));
            this.bntExPortEX = new DevExpress.XtraEditors.SimpleButton();
            this.pDenNgay = new System.Windows.Forms.DateTimePicker();
            this.pTuNgay = new System.Windows.Forms.DateTimePicker();
            this.bntGet = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gvlog = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvlog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntExPortEX
            // 
            this.bntExPortEX.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExPortEX.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.bntExPortEX.Appearance.Options.UseFont = true;
            this.bntExPortEX.Appearance.Options.UseForeColor = true;
            this.bntExPortEX.Image = ((System.Drawing.Image)(resources.GetObject("bntExPortEX.Image")));
            this.bntExPortEX.Location = new System.Drawing.Point(580, 5);
            this.bntExPortEX.Name = "bntExPortEX";
            this.bntExPortEX.Size = new System.Drawing.Size(131, 36);
            this.bntExPortEX.TabIndex = 4;
            this.bntExPortEX.Text = "EXPORT EXCELL";
            // 
            // pDenNgay
            // 
            this.pDenNgay.Location = new System.Drawing.Point(318, 10);
            this.pDenNgay.Name = "pDenNgay";
            this.pDenNgay.Size = new System.Drawing.Size(135, 20);
            this.pDenNgay.TabIndex = 3;
            // 
            // pTuNgay
            // 
            this.pTuNgay.Location = new System.Drawing.Point(82, 10);
            this.pTuNgay.Name = "pTuNgay";
            this.pTuNgay.Size = new System.Drawing.Size(135, 20);
            this.pTuNgay.TabIndex = 3;
            // 
            // bntGet
            // 
            this.bntGet.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntGet.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.bntGet.Appearance.Options.UseFont = true;
            this.bntGet.Appearance.Options.UseForeColor = true;
            this.bntGet.Image = ((System.Drawing.Image)(resources.GetObject("bntGet.Image")));
            this.bntGet.Location = new System.Drawing.Point(477, 5);
            this.bntGet.Name = "bntGet";
            this.bntGet.Size = new System.Drawing.Size(75, 36);
            this.bntGet.TabIndex = 2;
            this.bntGet.Text = "GET";
            this.bntGet.Click += new System.EventHandler(this.bntGet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(237, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến Ngày";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pTuNgay);
            this.panel1.Controls.Add(this.bntExPortEX);
            this.panel1.Controls.Add(this.pDenNgay);
            this.panel1.Controls.Add(this.bntGet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 55);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đến Ngày";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gvlog);
            this.panel2.Location = new System.Drawing.Point(2, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1345, 673);
            this.panel2.TabIndex = 6;
            // 
            // gvlog
            // 
            this.gvlog.Location = new System.Drawing.Point(3, 3);
            this.gvlog.MainView = this.gridView1;
            this.gvlog.Name = "gvlog";
            this.gvlog.Size = new System.Drawing.Size(1339, 667);
            this.gvlog.TabIndex = 0;
            this.gvlog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gvlog;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // XEMLOG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "XEMLOG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XEMLOG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvlog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bntExPortEX;
        private System.Windows.Forms.DateTimePicker pDenNgay;
        private System.Windows.Forms.DateTimePicker pTuNgay;
        private DevExpress.XtraEditors.SimpleButton bntGet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gvlog;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}