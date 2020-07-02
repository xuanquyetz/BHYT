using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHYT
{
    public partial class CauHinhCSDL : Form
    {
        public CauHinhCSDL()
        {
            InitializeComponent();
        }
      
        private void InsertConfig()
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            if (!Directory.Exists(path + @"\log"))
            {
                Directory.CreateDirectory(path + @"\log");
            }
            FileStream stream = new FileStream(Path.Combine(path, "log\\config.txt"), FileMode.Create);

            StreamWriter writer = new StreamWriter(stream, Encoding.Unicode);
            // writer.Write("[");
            writer.Write(txtIpSV.Text);
            writer.Write("\t");
            writer.Write(txtNameData.Text);
            writer.Write("\t");
            writer.Write(txtUser.Text);
            writer.Write("\t");
            writer.Write(txtPass.Text);
            writer.Close();
            stream.Close();
        }
        public void ReadConnect()
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            if (!Directory.Exists(path + @"\log"))
            {
                Directory.CreateDirectory(path + @"\log");
            }
            FileStream streamCLS = new FileStream(Path.Combine(path, "log\\config.txt"), FileMode.Open);
            StreamReader readCLS = new StreamReader(streamCLS, Encoding.Unicode);
            var chuoicls = readCLS.ReadLine();
            string[] araylistchuoi = chuoicls.Split(new char[] { '\t' });
            txtIpSV.Text = araylistchuoi[0];
            txtNameData.Text = araylistchuoi[1];
            txtUser.Text = araylistchuoi[2];
            txtPass.Text = araylistchuoi[3];
            readCLS.Close();
            streamCLS.Close();
        }
        private void LamRong()
        {
            txtIpSV.Text = "";
            txtNameData.Text = "";
            txtPass.Text = "";
            txtUser.Text = "";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           // ReadConnect();

        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            InsertConfig();
            XtraMessageBox.Show("Lưu cấu hình thành công! ", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XtraMessageBox.Show("Tắt phần mềm chạy lại để nhận cấu hình mới ", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //LamRong();
            this.Close();
        }

        private void CheckXemCauHinh_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckXemCauHinh.Checked == true)
            {
                ReadConnect();
            }
            else {
                LamRong();
                 }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
