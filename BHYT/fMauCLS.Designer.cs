namespace BHYT
{
    partial class fMauCLS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMauCLS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntDelete = new DevExpress.XtraEditors.SimpleButton();
            this.bntSave = new DevExpress.XtraEditors.SimpleButton();
            this.bntNew = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTieuDeIn = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rtNoiDung = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.memoDeNghi = new DevExpress.XtraEditors.MemoEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.memoKetLuan = new DevExpress.XtraEditors.MemoEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTieuDeIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoDeNghi.Properties)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoKetLuan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bntDelete);
            this.panel1.Controls.Add(this.bntSave);
            this.panel1.Controls.Add(this.bntNew);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 58);
            this.panel1.TabIndex = 0;
            // 
            // bntDelete
            // 
            this.bntDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bntDelete.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.bntDelete.Appearance.Options.UseFont = true;
            this.bntDelete.Appearance.Options.UseForeColor = true;
            this.bntDelete.Image = ((System.Drawing.Image)(resources.GetObject("bntDelete.Image")));
            this.bntDelete.Location = new System.Drawing.Point(242, 3);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(97, 47);
            this.bntDelete.TabIndex = 2;
            this.bntDelete.Text = "XÓA";
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // bntSave
            // 
            this.bntSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bntSave.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.bntSave.Appearance.Options.UseFont = true;
            this.bntSave.Appearance.Options.UseForeColor = true;
            this.bntSave.Image = ((System.Drawing.Image)(resources.GetObject("bntSave.Image")));
            this.bntSave.Location = new System.Drawing.Point(127, 3);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(97, 47);
            this.bntSave.TabIndex = 1;
            this.bntSave.Text = "SAVE";
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // bntNew
            // 
            this.bntNew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bntNew.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.bntNew.Appearance.Options.UseFont = true;
            this.bntNew.Appearance.Options.UseForeColor = true;
            this.bntNew.Image = ((System.Drawing.Image)(resources.GetObject("bntNew.Image")));
            this.bntNew.Location = new System.Drawing.Point(8, 3);
            this.bntNew.Name = "bntNew";
            this.bntNew.Size = new System.Drawing.Size(97, 47);
            this.bntNew.TabIndex = 0;
            this.bntNew.Text = "NEW";
            this.bntNew.Click += new System.EventHandler(this.bntNew_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.gridDanhSach);
            this.panel2.Location = new System.Drawing.Point(3, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 539);
            this.panel2.TabIndex = 1;
            // 
            // gridDanhSach
            // 
            this.gridDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gridDanhSach.MainView = this.gridView1;
            this.gridDanhSach.Name = "gridDanhSach";
            this.gridDanhSach.Size = new System.Drawing.Size(316, 537);
            this.gridDanhSach.TabIndex = 2;
            this.gridDanhSach.UseEmbeddedNavigator = true;
            this.gridDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcTen,
            this.gridLoai,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridDanhSach;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsPrint.PrintFilterInfo = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // gcTen
            // 
            this.gcTen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gcTen.AppearanceHeader.ForeColor = System.Drawing.Color.Blue;
            this.gcTen.AppearanceHeader.Options.UseFont = true;
            this.gcTen.AppearanceHeader.Options.UseForeColor = true;
            this.gcTen.AppearanceHeader.Options.UseTextOptions = true;
            this.gcTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcTen.Caption = "TÊN MẪU";
            this.gcTen.FieldName = "Ten";
            this.gcTen.Name = "gcTen";
            this.gcTen.OptionsColumn.AllowEdit = false;
            this.gcTen.OptionsColumn.AllowFocus = false;
            this.gcTen.Visible = true;
            this.gcTen.VisibleIndex = 0;
            this.gcTen.Width = 190;
            // 
            // gridLoai
            // 
            this.gridLoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridLoai.AppearanceHeader.ForeColor = System.Drawing.Color.Blue;
            this.gridLoai.AppearanceHeader.Options.UseFont = true;
            this.gridLoai.AppearanceHeader.Options.UseForeColor = true;
            this.gridLoai.AppearanceHeader.Options.UseTextOptions = true;
            this.gridLoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridLoai.Caption = "LOẠI";
            this.gridLoai.FieldName = "Loai";
            this.gridLoai.Name = "gridLoai";
            this.gridLoai.OptionsColumn.AllowEdit = false;
            this.gridLoai.OptionsColumn.AllowFocus = false;
            this.gridLoai.Visible = true;
            this.gridLoai.VisibleIndex = 1;
            this.gridLoai.Width = 77;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "Ma";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtTieuDeIn);
            this.panel3.Controls.Add(this.txtTen);
            this.panel3.Controls.Add(this.txtMa);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cbLoai);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(341, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(985, 45);
            this.panel3.TabIndex = 2;
            // 
            // txtTieuDeIn
            // 
            this.txtTieuDeIn.Location = new System.Drawing.Point(766, 10);
            this.txtTieuDeIn.Name = "txtTieuDeIn";
            this.txtTieuDeIn.Size = new System.Drawing.Size(201, 20);
            this.txtTieuDeIn.TabIndex = 10;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(301, 13);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(189, 20);
            this.txtTen.TabIndex = 9;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(75, 13);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(131, 20);
            this.txtMa.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(703, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tiêu Đề In";
            // 
            // cbLoai
            // 
            this.cbLoai.AllowDrop = true;
            this.cbLoai.AutoCompleteCustomSource.AddRange(new string[] {
            "Siêu Âm",
            "Nội Soi",
            "X- Quang",
            "Điên Tim",
            "Điện Não",
            "Khác"});
            this.cbLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(571, 9);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(121, 21);
            this.cbLoai.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(538, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(245, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Mẫu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Mẫu";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.rtNoiDung);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(341, 264);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(985, 341);
            this.panel4.TabIndex = 3;
            // 
            // rtNoiDung
            // 
            this.rtNoiDung.Location = new System.Drawing.Point(75, 9);
            this.rtNoiDung.Name = "rtNoiDung";
            this.rtNoiDung.Size = new System.Drawing.Size(892, 331);
            this.rtNoiDung.TabIndex = 6;
            this.rtNoiDung.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "NỘI DUNG";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.memoDeNghi);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(341, 117);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(985, 63);
            this.panel5.TabIndex = 4;
            // 
            // memoDeNghi
            // 
            this.memoDeNghi.Location = new System.Drawing.Point(75, 3);
            this.memoDeNghi.Name = "memoDeNghi";
            this.memoDeNghi.Size = new System.Drawing.Size(892, 55);
            this.memoDeNghi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ĐỀ NGHỊ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.memoKetLuan);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(341, 186);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(985, 72);
            this.panel6.TabIndex = 5;
            // 
            // memoKetLuan
            // 
            this.memoKetLuan.Location = new System.Drawing.Point(75, 3);
            this.memoKetLuan.Name = "memoKetLuan";
            this.memoKetLuan.Size = new System.Drawing.Size(892, 64);
            this.memoKetLuan.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(9, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "KẾT LUẬN";
            // 
            // button1
            // 
            this.button1.Image = global::BHYT.XRDesignRibbonControllerResources.RibbonUserDesigner_HtmlStop;
            this.button1.Location = new System.Drawing.Point(567, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fMauCLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 617);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fMauCLS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMauCLS";
            this.Load += new System.EventHandler(this.fMauCLS_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTieuDeIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoDeNghi.Properties)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoKetLuan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton bntSave;
        private DevExpress.XtraEditors.SimpleButton bntNew;
        private DevExpress.XtraEditors.SimpleButton bntDelete;
        private DevExpress.XtraGrid.GridControl gridDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gcTen;
        private DevExpress.XtraGrid.Columns.GridColumn gridLoai;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox rtNoiDung;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.MemoEdit memoDeNghi;
        private DevExpress.XtraEditors.MemoEdit memoKetLuan;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtTieuDeIn;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private System.Windows.Forms.Button button1;
    }
}