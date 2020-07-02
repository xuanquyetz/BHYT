using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;
using BHYT.DTO;
using BHYT.DAO;

namespace BHYT
{
    public partial class FormThemThongTinKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public FormThemThongTinKhachHang()
        {
            InitializeComponent();
            LoadKhachHang();
        }
       void LamMoi()
        {
            txtHoTen.Text = "";
            txtSoDT.Text = "";
            txtDiaChi.Text = "";
            txtGhiChu.Text = "";
            txtNgay.Text = "";
            txtEmail.Text = "";
            txtTrangThai.Text = "Đang_chạy_thử";
            txtNgayChayThu.Text = "";
            txtNgayChinhThuc.Text = "";
            txtLink.Text = "";
            txtTenCoSo.Text = "";
            txtNgayHethan.Text = "";
            txtSoTienThue.Text = "";
        }
        private void LoadKhachHang()
        {
            gridDanhSach.DataSource = QUANTRIDAO.Instance.LoadKhachHang();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            string HoTen = txtHoTen.Text;
            string DienThoai = txtSoDT.Text;
            string DiaChi = txtDiaChi.Text;
            string GhiChu = txtGhiChu.Text;
            string Ngay = txtNgay.Text;
            string Email = txtEmail.Text;
            string TrangThai = txtTrangThai.Text;
            string NgayChayThu = txtNgayChayThu.Text;
            string NgayChinhThuc = txtNgayChinhThuc.Text;
            string ServiceBase = txtLink.Text;
            string TenCoSo = txtTenCoSo.Text;
            string NgayHetHan = txtNgayHethan.Text;
            decimal SoTienThue =  decimal.Parse(txtSoTienThue.Text);
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal Stienthue= decimal.Parse(txtSoTienThue.Text, System.Globalization.NumberStyles.AllowThousands);
            txtSoTienThue.Text= String.Format(culture, "{0:N0}",Stienthue);

            if (ServiceBase!="" && NgayHetHan!=""&&TenCoSo!=""&&NgayChayThu!=""&&NgayChinhThuc!="")
            {
                QUANTRIDAO.Instance.ThemKhachHang(HoTen, DienThoai, DiaChi, GhiChu, Ngay, Email, TrangThai, NgayChayThu, NgayChinhThuc, ServiceBase, TenCoSo, NgayHetHan, SoTienThue);
                MessageBox.Show("Thêm thành công");
                LamMoi();
                LoadKhachHang();
            }
            else
            {
                MessageBox.Show("Các thông tin không được để trống");
            }
        }

        private void bntAdd1Day_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int row = gridView1.FocusedRowHandle;
            string MaID = "ID";
            string NgayHetHan = "NgayHetHan";
            string TenCoSoYTe = "TenCoSoYTe";
            object IdN = gridView1.GetRowCellValue(row, MaID);
            object NgayHetHanN= gridView1.GetRowCellValue(row, NgayHetHan);
            object TenCoSoYTeN = gridView1.GetRowCellValue(row,TenCoSoYTe);
            DateTime NgayHetHanDay = Convert.ToDateTime(NgayHetHanN).AddDays(1);
            //DateTime NgayHetHanAdd1 = NgayHetHanDay.AddDays(1);
            string NgayHetHanCong1 = Convert.ToString(NgayHetHanDay);
            string Id = IdN.ToString();
            string TenCS = TenCoSoYTeN.ToString();
            if(IdN!=null && NgayHetHanN != null) 
            {
                if (XtraMessageBox.Show("Bạn có muốn gia hạn thêm 1 ngày sử dụng cho " + TenCS + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QUANTRIDAO.Instance.UpdateDate(NgayHetHanDay, Id);
                    XtraMessageBox.Show("Ngày hết hạn tiếp theo của khách hàng: " + TenCS+" là: "+NgayHetHanCong1, "GIA HẠN THÀNH CÔNG 1 NGÀY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
                }
            }
            else XtraMessageBox.Show("Vui lòng kiểm tra lại khách hàng cần gia hạn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bntAdd1Month_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int row = gridView1.FocusedRowHandle;
            string MaID = "ID";
            string NgayHetHan = "NgayHetHan";
            string TenCoSoYTe = "TenCoSoYTe";
            object IdN = gridView1.GetRowCellValue(row, MaID);
            object NgayHetHanN = gridView1.GetRowCellValue(row, NgayHetHan);
            object TenCoSoYTeN = gridView1.GetRowCellValue(row, TenCoSoYTe);
            DateTime NgayHetHanDay = Convert.ToDateTime(NgayHetHanN).AddMonths(1);
            //DateTime NgayHetHanAdd1 = NgayHetHanDay.AddDays(1);
            string NgayHetHanCong1 = Convert.ToString(NgayHetHanDay);
            string Id = IdN.ToString();
            string TenCS = TenCoSoYTeN.ToString();
            if (IdN != null && NgayHetHanN != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn gia hạn thêm 1 tháng sử dụng cho " + TenCS + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QUANTRIDAO.Instance.UpdateDate(NgayHetHanDay, Id);
                    XtraMessageBox.Show("Ngày hết hạn tiếp theo của khách hàng " + TenCS + " là " + NgayHetHanCong1, "GIA HẠN THÀNH CÔNG 1 THÁNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
                }
            }
            else XtraMessageBox.Show("Vui lòng kiểm tra lại khách hàng cần gia hạn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bntAddQuy_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int row = gridView1.FocusedRowHandle;
            string MaID = "ID";
            string NgayHetHan = "NgayHetHan";
            string TenCoSoYTe = "TenCoSoYTe";
            object IdN = gridView1.GetRowCellValue(row, MaID);
            object NgayHetHanN = gridView1.GetRowCellValue(row, NgayHetHan);
            object TenCoSoYTeN = gridView1.GetRowCellValue(row, TenCoSoYTe);
            DateTime NgayHetHanDay = Convert.ToDateTime(NgayHetHanN).AddMonths(3);
            //DateTime NgayHetHanAdd1 = NgayHetHanDay.AddDays(1);
            string NgayHetHanCong1 = Convert.ToString(NgayHetHanDay);
            string Id = IdN.ToString();
            string TenCS = TenCoSoYTeN.ToString();
            if (IdN != null && NgayHetHanN != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn gia hạn thêm 1 quý sử dụng cho " + TenCS + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QUANTRIDAO.Instance.UpdateDate(NgayHetHanDay, Id);
                    XtraMessageBox.Show("Ngày hết hạn tiếp theo của khách hàng " + TenCS + " là " + NgayHetHanCong1, "GIA HẠN THÀNH CÔNG 1 QUÝ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
                }
            }
            else XtraMessageBox.Show("Vui lòng kiểm tra lại khách hàng cần gia hạn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bntAddYear_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int row = gridView1.FocusedRowHandle;
            string MaID = "ID";
            string NgayHetHan = "NgayHetHan";
            string TenCoSoYTe = "TenCoSoYTe";
            object IdN = gridView1.GetRowCellValue(row, MaID);
            object NgayHetHanN = gridView1.GetRowCellValue(row, NgayHetHan);
            object TenCoSoYTeN = gridView1.GetRowCellValue(row, TenCoSoYTe);
            DateTime NgayHetHanDay = Convert.ToDateTime(NgayHetHanN).AddYears(1);
            //DateTime NgayHetHanAdd1 = NgayHetHanDay.AddDays(1);
            string NgayHetHanCong1 = Convert.ToString(NgayHetHanDay);
            string Id = IdN.ToString();
            string TenCS = TenCoSoYTeN.ToString();
            if (IdN != null && NgayHetHanN != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn gia hạn thêm 1 năm sử dụng cho " + TenCS + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QUANTRIDAO.Instance.UpdateDate(NgayHetHanDay, Id);
                    XtraMessageBox.Show("Ngày hết hạn tiếp theo của khách hàng " + TenCS + " là " + NgayHetHanCong1, "GIA HẠN THÀNH CÔNG 1 NĂM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
                }
            }
            else XtraMessageBox.Show("Vui lòng kiểm tra lại khách hàng cần gia hạn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bntSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int row = gridView1.FocusedRowHandle;
            string MaID = "ID";
            string HoTen = "HoTen";
            string DienThoai = "DienThoai";
            string DiaChi = "DiaChi";
            string GhiChu = "GhiChu";
            string Ngay = "Ngay";
            //DateTime? Ngayd = Convert.ToDateTime(Ngay);
            string ThoiGian = "ThoiGian";
            string Email = "Email";
            string TrangThai = "TrangThai";
            string NgayChayThu = "NgayChayThu";
            string NgayChayChinhThuc = "NgayChayChinhThuc";
            string ServiceBase = "ServiceBase";
            string SoTienThue = "SoTienThue";
            string NgayHetHan = "NgayHetHan";
            string TenCoSoYTe = "TenCoSoYTe";
            object IdN = gridView1.GetRowCellValue(row, MaID);
            object HoTenN = gridView1.GetRowCellValue(row, HoTen);
            object DienThoaiN = gridView1.GetRowCellValue(row, DienThoai);
            object DiaChiN = gridView1.GetRowCellValue(row, DiaChi);
            object GhiChuN = gridView1.GetRowCellValue(row, GhiChu);
            object NgayN = gridView1.GetRowCellValue(row, Ngay);
            object NgayHetHanN = gridView1.GetRowCellValue(row, NgayHetHan);
            object ThoiGianN = gridView1.GetRowCellValue(row, ThoiGian);
            object EmailN = gridView1.GetRowCellValue(row, Email);
            object TrangThaiN = gridView1.GetRowCellValue(row, TrangThai);
            object NgayChayThuN = gridView1.GetRowCellValue(row, NgayChayThu);
            object NgayChayChinhThucN = gridView1.GetRowCellValue(row, NgayChayChinhThuc);
            object ServiceBaseN = gridView1.GetRowCellValue(row, ServiceBase);
            object SoTienThueN = gridView1.GetRowCellValue(row, SoTienThue);
            object TenCoSoYTeN = gridView1.GetRowCellValue(row, TenCoSoYTe);

            string id = IdN.ToString();
            string hoten = HoTenN.ToString();
            string dienthoai = DienThoaiN.ToString();
            string diachi = DiaChiN.ToString();
            string ghichu = GhiChuN.ToString();
            string ngay = NgayN.ToString(); DateTime? ngayd = Convert.ToDateTime(ngay);
            string ngayhethan = NgayHetHanN.ToString(); DateTime? ngayhethand = Convert.ToDateTime(ngayhethan);
            string thoigian = ThoiGianN.ToString();DateTime? thoigiand = Convert.ToDateTime(thoigian);
            string email = EmailN.ToString();
            string trangthai = TrangThaiN.ToString();
            string ngaychaythu = NgayChayThuN.ToString();
            DateTime? ngaychaythud = Convert.ToDateTime(ngaychaythu);
            string ngaychaychinhthuc = NgayChayChinhThucN.ToString();
            DateTime? ngaychaychinhthucd = Convert.ToDateTime(ngaychaychinhthuc);
            string serviceBase = ServiceBaseN.ToString();
            string sotienthue = SoTienThueN.ToString();
            decimal sotienthued = Convert.ToDecimal(sotienthue);
            string tencosoyte = TenCoSoYTeN.ToString();
            if (id != "")
            {
                if (XtraMessageBox.Show("Bạn có muốn sửa khách hàng: " + tencosoyte + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QUANTRIDAO.Instance.UpdateDateFull(id, hoten, dienthoai, diachi, ghichu, ngayd, thoigiand, email, trangthai, ngaychaythud, ngaychaychinhthucd, serviceBase, tencosoyte, ngayhethand, sotienthued);
                    XtraMessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
                }
            }
        }

        private void bntDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int row = gridView1.FocusedRowHandle;
            string MaID = "ID";
            string TenCoSoYTe = "TenCoSoYTe";
            object IdN = gridView1.GetRowCellValue(row, MaID);
            object TenCoSoYTeN = gridView1.GetRowCellValue(row, TenCoSoYTe);
            string id = IdN.ToString();
            string tencosoyte = TenCoSoYTeN.ToString();
            if (id != "")
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa khách hàng: " + tencosoyte + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QUANTRIDAO.Instance.Delete(id);
                    XtraMessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
                }
            }
        }
    }
}