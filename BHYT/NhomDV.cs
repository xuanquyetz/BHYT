using BHYT.DAO;
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
    public partial class NhomDV : Form
    {
        public NhomDV()
        {
            InitializeComponent();
            LoadNhomDV();
            txtMa.Focus();
            
        }
        public string Ma = "";

        private void FillDataNhom()
        {
            if (Ma != "")
            {
               // string id = txtMa.Text;
                List<DTO.NhomDVDTO> listdsnhom = NhomDichVuDAO.Instance.GetDanhSachNhomById(Ma);
                foreach (DTO.NhomDVDTO item in listdsnhom)
                {
                    txtMa.EditValue = item.Ma;
                    txtTen.EditValue = item.Ten;
                    txtPhanLoai.EditValue = item.PhanLoai;

                }
            }
        }
        private void LoadNhomDV()
        {
            gDanhSachDV.DataSource= NhomDichVuDAO.Instance.LoadNhomDV();
        }

        private void LamRong()
        {
            txtMa.Text = null;
            txtTen.Text = null;
            txtPhanLoai.Text = null;
            txtSTT.Text = null;
        }
        private void InsertNhomDV()
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string phanLoai = txtPhanLoai.Text;
          //  int stt = int.Parse(txtSTT.Text);
            if(txtMa.Text!="")
            {
                //List<DTO.NhomDVDTO> listdsnhom = NhomDichVuDAO.Instance.GetDanhSachNhomById(Ma);

                //foreach (DTO.NhomDVDTO item in listdsnhom2)
                //{
                //    if(txtMa.Text==item.Ma)
                //    {

                //        XtraMessageBox.Show("Mã " + item.Ma + " đã tồn tại vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    }
                //    else
                //    {
                //        NhomDichVuDAO.Instance.InsertNhomDV(ma, ten, phanLoai);
                //        XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        continue;
                //    }

                //}
                List<DTO.NhomDVDTO> listdsnhom2 = NhomDichVuDAO.Instance.GetListNhomDVFull();
                if (listdsnhom2.Count <= 0)
                {
                    NhomDichVuDAO.Instance.InsertNhomDV(ma, ten, phanLoai);
                    XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (listdsnhom2.Count(q => q.Ma == txtMa.Text) > 0)

                    {
                        XtraMessageBox.Show("Mã " + txtMa.Text + " đã tồn tại vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        NhomDichVuDAO.Instance.InsertNhomDV(ma, ten, phanLoai);
                        XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
              
                LamRong();
                txtMa.Focus();
                LoadNhomDV();
            }
            
            else {
                XtraMessageBox.Show("Mã không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                 }
        }
 
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void NhomDV_Load(object sender, EventArgs e)
        {

        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            InsertNhomDV();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int row = gridView1.FocusedRowHandle;
            string MaID = "Ma";
            object value = gridView1.GetRowCellValue(row, MaID);
            if (value != null)
            {
                Ma = value.ToString();
               // FillDataNhom();
                
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn dịch vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NhomDV_KeyDown(object sender, KeyEventArgs e)
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
                if (XtraMessageBox.Show("Bạn có muốn xóa nhóm có mã " + value + " này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Ma = value.ToString();
                    NhomDichVuDAO.Instance.DeleteNhomDV(Ma);
                    LoadNhomDV();
                    XtraMessageBox.Show("Xóa thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else XtraMessageBox.Show("Vui lòng chọn dòng để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bntSua2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int row = gridView1.FocusedRowHandle;
            string MaID = "Ma";
            string Ten = "Ten";
            string PhanLoai = "PhanLoai";
           // string STT = "STT";
            object MaN = gridView1.GetRowCellValue(row,MaID);
            object TenN = gridView1.GetRowCellValue(row, Ten);
            object PhanLoaiN = gridView1.GetRowCellValue(row, PhanLoai);
            //LoadNhomDV();
            //int row2 = gridView1.FocusedRowHandle;
            //string MaID2 = "Ma";
            //object MaN2 = gridView1.GetRowCellValue(row2, MaID2);
            // object STTN = gridView1.GetRowCellValue(row,STT );
            if (MaN != null)
            {
                //string ma2 = MaN2.ToString();
                string ma = MaN.ToString();
                string ten = TenN.ToString();
                string phanLoai = PhanLoaiN.ToString();
                //int stt = int.Parse(STTN.ToString());
                List<DTO.NhomDVDTO> listdsnhom = NhomDichVuDAO.Instance.GetDanhSachNhomById(ma);
                foreach (DTO.NhomDVDTO item in listdsnhom)
                {
                    if((ten!=item.Ten || phanLoai!=item.PhanLoai) && ma==item.Ma)
                    {
                        NhomDichVuDAO.Instance.EditNhomDV(ma, ten, phanLoai);
                        XtraMessageBox.Show("Sửa thành công "+ma, "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNhomDV();
                    }
                    else
                    {
                        if(ma!=item.Ma)
                        {
                            XtraMessageBox.Show("Mã nhóm không được chỉnh sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if(ten == item.Ten || phanLoai == item.PhanLoai)
                        {
                            XtraMessageBox.Show("Chưa có gì thay đổi, hãy nhập chỉnh sửa cho dòng dịch vụ", "Chưa được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                if(listdsnhom.Count==0)
                {
                    XtraMessageBox.Show("Mã nhóm không được thay đổi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadNhomDV();
                }
                    
            }
            else
            {
                XtraMessageBox.Show("Mã dịch vụ không được thay đổi hoặc để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPhanLoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bntAdd.Focus();
            }
        }
    }
}
