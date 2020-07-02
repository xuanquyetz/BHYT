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
    public partial class fDMNhanSu : Form
    {
        public fDMNhanSu()
        {
            InitializeComponent();
            Loadfull();
        }
        #region Methort
        private void InsertDanhMucNhanSu()
        {
            string ma = txtMaBS.Text;
            string hoTen = txtTenBs.Text;
            string phanLoai = txtPhanLoaiBs.Text;
            List<DanhMucNhanSuDTO> listnhansu = DanhMucNhanSuDAO.Instance.LoadFull();
            if (listnhansu.Count <= 0)
            {
                DanhMucNhanSuDAO.Instance.InserNhanSu(ma, hoTen, phanLoai);
                XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Loadfull();
                LoadEmpty();
            }
            else
            {
                if (listnhansu.Count(q => q.Ma == txtMaBS.Text) > 0)
                {
                    XtraMessageBox.Show("Mã " + txtMaBS.Text + " đã tồn tại vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadEmpty();
                }
                else
                {
                    DanhMucNhanSuDAO.Instance.InserNhanSu(ma, hoTen, phanLoai);
                    XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Loadfull();
                    LoadEmpty();
                }
            }
        }
        private void Loadfull()
        {
            gDanhSachDSBS.DataSource = DanhMucNhanSuDAO.Instance.LoadFull();
        }
        private void LoadEmpty()
        {
            txtMaBS.EditValue = null;
            txtPhanLoaiBs.EditValue = null;
            txtTenBs.EditValue = null;
        }
        #endregion

        private void bntAdd_Click(object sender, EventArgs e)
        {
            InsertDanhMucNhanSu();
        }

        private void bntXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int row = gridView1.FocusedRowHandle;
            string MaID = "Ma";
            object value = gridView1.GetRowCellValue(row, MaID);
            if (value != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa nhân sự có mã " + value + " này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                  string  Ma = value.ToString();
                    DanhMucNhanSuDAO.Instance.DeleteNhanSu(Ma);
                    Loadfull();
                    XtraMessageBox.Show("Xóa thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else XtraMessageBox.Show("Vui lòng chọn dòng để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bntSua2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int row = gridView1.FocusedRowHandle;
            string MaID = "Ma";
            string Ten = "HoTen";
            string Loai = "PhanLoai";
            object MaN = gridView1.GetRowCellValue(row, MaID);
            object TenN = gridView1.GetRowCellValue(row, Ten);
            object LoaiN = gridView1.GetRowCellValue(row, Loai);
            if (MaN != null)
            {
                string ma = MaN.ToString();
                string ten = TenN.ToString();
                string loai = LoaiN.ToString();
                List<DanhMucNhanSuDTO> listns = DanhMucNhanSuDAO.Instance.GetDanhSachNhanSuById(ma);
                foreach (DanhMucNhanSuDTO item in listns)
                {
                    if(ma==item.Ma && ten != item.HoTen || loai!= item.PhanLoai)
                    {
                        DanhMucNhanSuDAO.Instance.UpdateNhanSu(ma,ten,loai);
                        XtraMessageBox.Show("Sửa thành công " + ma, "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Loadfull();
                    }
                    else
                    {
                        if (ma != item.Ma)
                        {
                            XtraMessageBox.Show("Mã nhân sự không được chỉnh sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (ten == item.HoTen || loai == item.PhanLoai)
                        {
                            XtraMessageBox.Show("Chưa có gì thay đổi, hãy nhập chỉnh sửa cho bạn chọn", "Chưa được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                if (listns.Count == 0)
                {
                    XtraMessageBox.Show("Mã nhân sự không được thay đổi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Loadfull();
                }
            }
            else
            {
                XtraMessageBox.Show("Mã nhân sự không được thay đổi hoặc để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
