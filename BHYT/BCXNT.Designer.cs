namespace BHYT
{
    partial class fBCXNT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBCXNT));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gvXNT = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbKho = new System.Windows.Forms.ComboBox();
            this.cbKyKeToan = new System.Windows.Forms.ComboBox();
            this.bntExPortEX = new DevExpress.XtraEditors.SimpleButton();
            this.bntGet = new DevExpress.XtraEditors.SimpleButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvXNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kỳ kế toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(228, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kho";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gvXNT);
            this.panel2.Location = new System.Drawing.Point(3, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1345, 673);
            this.panel2.TabIndex = 8;
            // 
            // gvXNT
            // 
            this.gvXNT.Location = new System.Drawing.Point(3, 3);
            this.gvXNT.MainView = this.gridView1;
            this.gvXNT.Name = "gvXNT";
            this.gvXNT.Size = new System.Drawing.Size(1339, 667);
            this.gvXNT.TabIndex = 0;
            this.gvXNT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gvXNT;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbKho);
            this.panel1.Controls.Add(this.cbKyKeToan);
            this.panel1.Controls.Add(this.bntExPortEX);
            this.panel1.Controls.Add(this.bntGet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 55);
            this.panel1.TabIndex = 7;
            // 
            // cbKho
            // 
            this.cbKho.FormattingEnabled = true;
            this.cbKho.Location = new System.Drawing.Point(275, 14);
            this.cbKho.Name = "cbKho";
            this.cbKho.Size = new System.Drawing.Size(121, 21);
            this.cbKho.TabIndex = 5;
            // 
            // cbKyKeToan
            // 
            this.cbKyKeToan.FormattingEnabled = true;
            this.cbKyKeToan.Location = new System.Drawing.Point(74, 13);
            this.cbKyKeToan.Name = "cbKyKeToan";
            this.cbKyKeToan.Size = new System.Drawing.Size(121, 21);
            this.cbKyKeToan.TabIndex = 5;
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
            // fBCXNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fBCXNT";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BCXNT";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvXNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton bntExPortEX;
        private DevExpress.XtraEditors.SimpleButton bntGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gvXNT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbKho;
        private System.Windows.Forms.ComboBox cbKyKeToan;
    }
}