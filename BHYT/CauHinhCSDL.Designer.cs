namespace BHYT
{
    partial class CauHinhCSDL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CauHinhCSDL));
            this.txtIpSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btConnect = new DevExpress.XtraEditors.SimpleButton();
            this.CheckXemCauHinh = new DevExpress.XtraEditors.CheckEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.CheckXemCauHinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIpSV
            // 
            this.txtIpSV.Location = new System.Drawing.Point(114, 45);
            this.txtIpSV.Name = "txtIpSV";
            this.txtIpSV.Size = new System.Drawing.Size(200, 20);
            this.txtIpSV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP SERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DATABASE";
            // 
            // txtNameData
            // 
            this.txtNameData.Location = new System.Drawing.Point(114, 82);
            this.txtNameData.Name = "txtNameData";
            this.txtNameData.Size = new System.Drawing.Size(200, 20);
            this.txtNameData.TabIndex = 2;
            this.txtNameData.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "USER";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(114, 117);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 20);
            this.txtUser.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PASS";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(114, 152);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(200, 20);
            this.txtPass.TabIndex = 6;
            // 
            // btConnect
            // 
            this.btConnect.Image = ((System.Drawing.Image)(resources.GetObject("btConnect.Image")));
            this.btConnect.Location = new System.Drawing.Point(114, 188);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(92, 34);
            this.btConnect.TabIndex = 8;
            this.btConnect.Text = "SAVE";
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // CheckXemCauHinh
            // 
            this.CheckXemCauHinh.Location = new System.Drawing.Point(114, 230);
            this.CheckXemCauHinh.Name = "CheckXemCauHinh";
            this.CheckXemCauHinh.Properties.Caption = "Xem cấu hình hiện tại";
            this.CheckXemCauHinh.Size = new System.Drawing.Size(127, 19);
            this.CheckXemCauHinh.TabIndex = 9;
            this.CheckXemCauHinh.CheckedChanged += new System.EventHandler(this.CheckXemCauHinh_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "CẤU HÌNH KẾT NỐI CSLD";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(222, 188);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(92, 34);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "EXIT";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // CauHinhCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 259);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CheckXemCauHinh);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIpSV);
            this.Name = "CauHinhCSDL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CauHinhCSDL";
            ((System.ComponentModel.ISupportInitialize)(this.CheckXemCauHinh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIpSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private DevExpress.XtraEditors.SimpleButton btConnect;
        private DevExpress.XtraEditors.CheckEdit CheckXemCauHinh;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}