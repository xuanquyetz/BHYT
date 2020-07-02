using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHYT
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void bntCLS_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ThucHienCLS cls = new ThucHienCLS();
                cls.ShowDialog();
        }

        private void bntDanhMucDV_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            DanhMucDV dmdv = new DanhMucDV();
            dmdv.ShowDialog();
        }

        private void bntNhomDV_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            NhomDV nhomdv = new NhomDV();
            nhomdv.ShowDialog();
        }

        private void bntNhanSu_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            fDMNhanSu nhansu = new fDMNhanSu();
            nhansu.ShowDialog();
        }

        private void bntDMMauCLS_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            fMauCLS cls = new fMauCLS();
            cls.ShowDialog();
        }
    }
}
