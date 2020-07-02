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
using DevExpress.Utils;

namespace BHYT
{
    public partial class DanhMucDV : Form
    { 
    public DanhMucDV()
        {
            InitializeComponent();
            LoadNhomDV();
            LoadDanhMucDV();
            LoadDMDonVi();
            LamRong();
    
        }
        string Ma;
      //  private readonly SuperToolTip serializableAppearanceObject4;

        private void LoadNhomDV()
        {
            comboBox1.DataSource = NhomDichVuDAO.Instance.LoadNhomDV();
            comboBox1.DisplayMember = "Ma";
            comboBox1.ValueMember = "Ma";
        }
        private void LoadDMDonVi()
        {
            cbbDonVi.DataSource = DanhMucDVDAO.Instance.LoadDMDonVi();
            cbbDonVi.DisplayMember = "Ten";
            cbbDonVi.ValueMember = "Ma";
        }
        private void LoadDanhMucDV()
        {
            gDanhSachDV.DataSource = DanhMucDVDAO.Instance.LoadDanhMucDV();
        }
        private void LamRong()
        {
            txtMaDV.Text = null;
            txtTenDV.Text = null;
            txtDonGia.Text = "0";
            cbbNhom.Text = null;
            cbbDonVi.Text = "Lần";
            cbbLoaiCLS.Text = null;
            txtTenTimKiem.Text = null;
            txtMaDV.Focus();
        }
        private void InsertDanhMucDV()
        {
            string Ma = txtMaDV.Text;
            string Ten = txtTenDV.Text;
            string Nhom = cbbNhom.Text;
            decimal DonGia = decimal.Parse(txtDonGia.Text);
            string DonVi = cbbDonVi.Text;
            string TuKhoaTimKiem = txtTenTimKiem.Text;
            string MauLCS = cbbLoaiCLS.Text;
            if( txtMaDV.Text!="")
            {
                List<DanhMucDVDTO> lisdanhsachdv = DanhMucDVDAO.Instance.GetListDVFull();
                if (lisdanhsachdv.Count<=0)
                {
                    DanhMucDVDAO.Instance.InsertDanhMucDV(Ma, Ten, Nhom, DonGia, DonVi, TuKhoaTimKiem, MauLCS);
                    XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhMucDV();
                    LamRong();
                    txtMaDV.Focus();
                }
                else
                {
                    if (lisdanhsachdv.Count(q => q.Ma == txtMaDV.Text) > 0)
                    {
                        XtraMessageBox.Show("Mã dịch vụ đã tồn tại, vui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DanhMucDVDAO.Instance.InsertDanhMucDV(Ma, Ten, Nhom, DonGia, DonVi, TuKhoaTimKiem, MauLCS);
                        XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhMucDV();
                        LamRong();
                        txtMaDV.Focus();
                    }
                }
                
            }
            else
            {
                XtraMessageBox.Show("Mã dịch vụ không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDV.Focus();
            }
        }

        private void DanhMucDV_Load(object sender, EventArgs e)
        {

        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            InsertDanhMucDV();
        }

        private void DanhMucDV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                bntAdd.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.N)
            {
                // bntNew.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.E)
            {
                bntEdit.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.D)
            {
                bntDelete.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.X)
            {
                bntExportExcell.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.I)
            {
                bntImportEX.PerformClick();
            }
        }

        private void bntXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int row = gridView1.FocusedRowHandle;
            string MaID = "Ma";
            object value = gridView1.GetRowCellValue(row, MaID);
            if (value != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa dịch vụ có mã " + value + " này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Ma = value.ToString();
                    DanhMucDVDAO.Instance.DeleteDanhMucDV(Ma);
                    LoadDanhMucDV();
                    XtraMessageBox.Show("Xóa thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else XtraMessageBox.Show("Vui lòng chọn dòng để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtTenTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bntAdd.Focus();
            }
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {

        }

        private void bntLuu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int row = gridView1.FocusedRowHandle;
            string MaID = "MaThuoc";
            string Ten = "TenThuoc";
            //string Nhom = "Nhom";
            string Nhom = comboBox1.Text;
            string DonGia = "DonGia";
            string DonVi = "MaDonVi";
            string MauCLS = "MauCLS";
            string TuKhoaTK = "TuKhoaTimKiem";
            string SoDangKy = "SoDangKy";
            string HoatChat = "HoatChat";
            string HamLuong = "HamLuong";
            string QuyCachDongGoi = "QuyCachDongGoi";
            string HangSanXuat = "HangSanXuat";
            string NuocSanXuat = "NuocSanXuat";
           
            object MaN = gridView1.GetRowCellValue(row, MaID);
            object TenN = gridView1.GetRowCellValue(row, Ten);
            object NhomN = gridView1.GetRowCellValue(row, Nhom);
            object DonGiaN = gridView1.GetRowCellValue(row, DonGia);
            object DonViN = gridView1.GetRowCellValue(row, DonVi);
            object MauCLSN = gridView1.GetRowCellValue(row, MauCLS);
            object TuKhoTKN = gridView1.GetRowCellValue(row, TuKhoaTK);
            object SoDangKyN = gridView1.GetRowCellValue(row, SoDangKy);
            object HoatChatN = gridView1.GetRowCellValue(row, HoatChat);
            object HamLuongN = gridView1.GetRowCellValue(row, HamLuong);
            object QuyCachDongGoiN = gridView1.GetRowCellValue(row, QuyCachDongGoi);
            object HangSanXuatN = gridView1.GetRowCellValue(row, HangSanXuat);
            object NuocSanXuatN = gridView1.GetRowCellValue(row, NuocSanXuat);
            
            if (MaN != null)
            {
                string ma = MaN.ToString();
                string ten = TenN.ToString();
               // string nhom = NhomN.ToString();
                //decimal donGia = decimal.Parse(DonGiaN.ToString());
                string donVi = DonViN.ToString();
                //string tuKhoaTimKiem = TuKhoTKN.ToString();
                string hamLuong = HamLuongN.ToString();
                string hangsx = HangSanXuatN.ToString();
                string nuocsx = NuocSanXuatN.ToString();
                string hoatChat = HoatChatN.ToString();
                string soDangKy = SoDangKyN.ToString();

                List<DanhMucDVDTO> listdm = DanhMucDVDAO.Instance.GetDanhSachDVById(ma);
                if (Nhom != null || Nhom !="")
                {
                    if (listdm.Count > 0)
                    {
                        XtraMessageBox.Show("Thuốc đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DanhMucDVDAO.Instance.InsertDanhMucThuoc(ma, ten, ten,Nhom, hamLuong, donVi, hangsx, nuocsx, soDangKy, hoatChat, ma);

                        XtraMessageBox.Show("Thêm thành công " + ma+"("+ten+")", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn nhóm trước khi chọn thuốc", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                /*
                List<DanhMucDVDTO> listdm = DanhMucDVDAO.Instance.GetDanhSachDVById(ma);
                foreach (DanhMucDVDTO item in listdm)
                {
                    if(ma==item.Ma&& ten != item.Ten || nhom != item.Nhom || donGia != item.DonGia || donVi != item.DonVi || tuKhoaTimKiem != item.TukhoaTimKiem || mauLCS != item.MaCLS)
                    {
                        DanhMucDVDAO.Instance.UpdateDMDV(ma, ten, nhom, donGia, donVi, tuKhoaTimKiem, mauLCS);
                        XtraMessageBox.Show("Sửa thành công " + ma, "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhMucDV();
                        LamRong();
                    }
                    else
                    {
                        if (ma != item.Ma)
                        {
                            XtraMessageBox.Show("Mã dịch vụ không được chỉnh sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (ten == item.Ten || nhom == item.Nhom||donGia==item.DonGia||donVi==item.DonVi||tuKhoaTimKiem==item.TukhoaTimKiem||mauLCS==item.MaCLS)
                        {
                            XtraMessageBox.Show("Chưa có gì thay đổi, hãy nhập chỉnh sửa cho dòng dịch vụ", "Chưa được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    
                    
                }
                if (listdm.Count == 0)
                {
                    XtraMessageBox.Show("Mã dịch vụ không được thay đổi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadDanhMucDV();
                }
                */
            }
            else
            {
                XtraMessageBox.Show("Mã dịch vụ không được thay đổi hoặc để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void tabPane1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
