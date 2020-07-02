using DevExpress.XtraSplashScreen;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            ReadConnect();
        }
        public void ReadConnect()
        {
            try
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
                BienToanCuc.IpSV = araylistchuoi[0];
                BienToanCuc.DataBaseName = araylistchuoi[1];
                BienToanCuc.User = araylistchuoi[2];
                BienToanCuc.Pass = araylistchuoi[3];
                readCLS.Close();
                streamCLS.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
        public static class BienToanCuc
        {
            private static string ipSV;
            private static string dataBaseName;
            private static string user;
            private static string pass;

            public static string IpSV
            {
                get
                {
                    return ipSV;
                }

                set
                {
                    ipSV = value;
                }
            }

            public static string DataBaseName
            {
                get
                {
                    return dataBaseName;
                }

                set
                {
                    dataBaseName = value;
                }
            }

            public static string User
            {
                get
                {
                    return user;
                }

                set
                {
                    user = value;
                }
            }

            public static string Pass
            {
                get
                {
                    return pass;
                }

                set
                {
                    pass = value;
                }
            }
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Form1 fBhyt = new Form1();
            fBhyt.ShowDialog();
        }

        private void tileItem16_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            XEMLOG fxlog = new XEMLOG();
            fxlog.ShowDialog();
        }

        private void tileItem10_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            fBCXNT fxnt = new fBCXNT();
            fxnt.ShowDialog();
        }

        private void fThemKhachHang_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FormThemThongTinKhachHang ftt = new FormThemThongTinKhachHang();
            FormMain fmm = new FormMain();
            fmm.Hide();
            ftt.ShowDialog();
      
        }

        private void DMDQG_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(SplashScreen1));
            //SplashScreenManager.Default.SetWaitFormCaption("Đã lấy xong");
           
            DanhMucDV dmdv = new DanhMucDV();
            SplashScreenManager.CloseForm();
            dmdv.ShowDialog();
        }

        private void tileItem22_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            CauHinhCSDL ch = new CauHinhCSDL();
            ch.ShowDialog();
        }

        private void tileItem24_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ThucHienCLS th = new ThucHienCLS();
            th.ShowDialog();
        }
    }
}
