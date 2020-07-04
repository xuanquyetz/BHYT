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
