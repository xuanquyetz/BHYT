using BHYT.DAO;
using BHYT.DTO;
using DevExpress.XtraEditors;
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
    public partial class fMauCLS : Form
    {
        public fMauCLS()
        {
            InitializeComponent();
            LoadDanhSachMau();
        }
        string Ma = "";
        private void LoadDanhSachMau()
        {
            gridDanhSach.DataSource = MauCLSDAO.Instance.LoadFullMauCLS();
        }
        private void FillData()
        {
            if (Ma != null)
            {
                var dongCLS = MauCLSDAO.Instance.LoadFullMauCLS();
                var q2 = dongCLS.Where(q => q.Ma == Ma).SingleOrDefault();
                if (q2 != null)
                {
                    txtMa.EditValue = q2.Ma;
                    txtTen.EditValue = q2.Ten;
                    txtTieuDeIn.EditValue = q2.TieuDeIn;
                    cbLoai.Text = q2.Loai;
                    memoDeNghi.EditValue = q2.DeNghi;
                    memoKetLuan.EditValue = q2.KetLuan;
                    rtNoiDung.Text = q2.NoiDung;

                }
            }
        }
        private void LoadEmpty()
        {
            txtMa.EditValue = null;
            txtTen.EditValue = null;
            txtTieuDeIn.EditValue = null;
            cbLoai.Text = null;
            rtNoiDung.Text = null;
            memoKetLuan.Text = null;
            memoDeNghi.Text = null;
        }
        private void UpdateMauCLS()
        {
            var dongCLS = MauCLSDAO.Instance.LoadFullMauCLS();
            var q2 = dongCLS.Where(q => q.Ma == Ma).SingleOrDefault();
            if(q2.Ma==txtMa.Text&&q2.Ten!=txtTen.Text||q2.NoiDung!=rtNoiDung.Text||q2.Loai!=cbLoai.Text||q2.TieuDeIn!=txtTieuDeIn.Text||q2.KetLuan!=memoKetLuan.Text||q2.DeNghi!=memoDeNghi.Text)
            {
                
            }
        }
        private void InsertMauCLS()
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string noiDung = rtNoiDung.Text;
            string loai = cbLoai.Text;
            string tieuDeIn = txtTieuDeIn.Text;
            string ketLuan = memoKetLuan.Text;
            string deNghi = memoDeNghi.Text;
            List<DanhMucMauCLSDTO> listCLS = MauCLSDAO.Instance.LoadFullMauCLS();
            if (listCLS.Count <= 0)
            {
                MauCLSDAO.Instance.InsertMauCLS(ma,ten,noiDung,loai,tieuDeIn,ketLuan,deNghi);
                XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachMau();
                LoadEmpty();
            }
            else
            {
                var dongCLS = MauCLSDAO.Instance.LoadFullMauCLS();
                var q2 = dongCLS.Where(q => q.Ma == Ma).SingleOrDefault();
                if (listCLS.Count(q => q.Ma == txtMa.Text) > 0)
                {

                    if (q2.Ma == txtMa.Text && q2.Ten != txtTen.Text || q2.NoiDung != rtNoiDung.Text || q2.Loai != cbLoai.Text || q2.TieuDeIn != txtTieuDeIn.Text || q2.KetLuan != memoKetLuan.Text || q2.DeNghi != memoDeNghi.Text)
                    {
                        MauCLSDAO.Instance.UpdateMauCLS(ma, ten, noiDung, loai, tieuDeIn, ketLuan, deNghi);
                        XtraMessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachMau();
                    }
                    else
                    {
                        if (ma != q2.Ma)
                        {
                            XtraMessageBox.Show("Mã " + txtMa.Text + " không được thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (q2.Ten == txtTen.Text || q2.NoiDung == rtNoiDung.Text || q2.Loai == cbLoai.Text || q2.TieuDeIn == txtTieuDeIn.Text || q2.KetLuan == memoKetLuan.Text || q2.DeNghi == memoDeNghi.Text)
                            XtraMessageBox.Show("Mã " + txtMa.Text + " chưa có gì thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                else
                {
                        MauCLSDAO.Instance.InsertMauCLS(ma, ten, noiDung, loai, tieuDeIn, ketLuan, deNghi);
                        XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachMau();
                        LoadEmpty();

                }
            }
        }
        private void DeleteMauClS()
        {
            if(txtMa.EditValue!=null||txtMa.Text!="")
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa nhân sự có mã này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MauCLSDAO.Instance.DeleteMauCLS(txtMa.Text);
                    XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachMau();
                    LoadEmpty();
                }
            }
            else XtraMessageBox.Show("Vui lòng chọn dòng để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fMauCLS_Load(object sender, EventArgs e)
        {

        }

        private void gridView1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int row = gridView1.FocusedRowHandle;
            string MaID = "Ma";
            object value = gridView1.GetRowCellValue(row, MaID);
            if (value != null)
            {
                Ma = value.ToString();
                FillData();
            }
            else XtraMessageBox.Show("Vui lòng chọn bệnh nhân cần sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            InsertMauCLS();
        }

        private void bntNew_Click(object sender, EventArgs e)
        {
            LoadEmpty();
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            DeleteMauClS();
        }
    }
}
