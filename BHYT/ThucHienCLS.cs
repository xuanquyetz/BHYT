using BHYT.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraEditors;
using BHYT.DTO;
using DevExpress.XtraReports.UI;
using System.IO;

namespace BHYT
{
    public partial class ThucHienCLS : Form
    {
        private FilterInfoCollection cameras;
        private VideoCaptureDevice cam;
        public string Ma="";
        private DateTime? tuNgay = DateTime.Now;
        private DateTime? denNgay = DateTime.Now;
        
        public ThucHienCLS()
        {
            InitializeComponent();
            ReadConnect();
            LoadListPhieuCDHA(dateEditTuNgay.DateTime,dateEditDenNgay.DateTime.AddDays(1));
            Camrera();
            PlayCamera();
            LoadNhomDV();
            LoadDichVuCDNhanh();
            LoadNhanSu();
            LoadMauCLS();
            
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
        void Camrera()
        {
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in cameras)
            {
                cbChonMay.Items.Add(item.Name);
            }
            cbChonMay.SelectedIndex = 0;
        }
        void PlayCamera()
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
            cam = new VideoCaptureDevice(cameras[cbChonMay.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
        }
        private void ThucHienCLS_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        void ThongTinRong()
        {
            txtMaBenhNhan.EditValue=null;
            txtHoTen.EditValue = null;
            txtNamSinh.Text = "1990";
            txtNgaySinh.Text = "01";
            txtThangSinh.Text = "01";
            txtGioiTinh.EditValue = null;
            txtEmail.EditValue = null;
            txtSoDienThoai.EditValue = null;
            txtSoBHYT.EditValue = null;
            txtMaDKBD.EditValue = null;
            txtDiaChi.EditValue = null;
            lbHoTen.Text = "";
            lbCD.Text = "";
            lbNamSinh.Text = "";
            cbMauCLS.Text = "";
            mmChanDoan.Text = "";
            rtDeNghi.Text = "";
            rtKetLuan.Text = "";
            rtMauCLS.Text = "";
        }
        
        void Insert_Update_BenhNhan()
        {
            string Ma = txtMaBenhNhan.Text;
            string HoTen = txtHoTen.Text;
            int NgaySinh = int.Parse(txtNgaySinh.Text);
            int ThangSinh = int.Parse(txtThangSinh.Text);
            int NamSinh = int.Parse(txtNamSinh.Text);
            string DienThoai = txtSoDienThoai.Text;
            string GioiTinh = txtGioiTinh.Text;
            string Email = txtEmail.Text;
            string DiaChi = txtDiaChi.Text;
            string SoBHYT = txtSoBHYT.Text;
            string MaNoiDKBD = txtMaDKBD.Text;
            if (txtHoTen.Text != "" && txtNamSinh.Text != "" && txtGioiTinh.Text != "")
            {
                if (txtGioiTinh.Text == "Nam" || txtGioiTinh.Text == "Nữ")
                { 
                    var bn2 = BV_BenhNhanDAO.Instance.GetListFullBV_BenhNhan().Where(q => q.Ma == Ma);
                    if (bn2.Count(q=>q.Ma==Ma)<=0)
                    {
                        BV_BenhNhanDAO.Instance.InsertBenhNhan(HoTen, NgaySinh, ThangSinh, NamSinh, DienThoai, GioiTinh, Email, DiaChi, SoBHYT, MaNoiDKBD);
                        var listBn = BV_BenhNhanDAO.Instance.GetListFullBV_BenhNhan().OrderByDescending(k => k.ThoiGianTao).First();
                        string maBN = listBn.Ma;
                        BV_PhieuCDHADAO.Instance.InsertBV_PhieuCDHA(cbKhoaPhong.Text, maBN,cbDichVu.SelectedValue.ToString(), cbTenBs.SelectedValue.ToString(), rtMauCLS.Text, "", rtKetLuan.Text, rtDeNghi.Text, 1, "", mmChanDoan.Text, "DaThucHien", cbMauCLS.SelectedValue.ToString(), 1, 0);
                        XtraMessageBox.Show("Thêm thành công " + HoTen, "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ThongTinRong();
                    }
                    else
                    {
                        BV_BenhNhanDAO.Instance.UpdateBenhNhan(HoTen, NgaySinh, ThangSinh, NamSinh, DienThoai, GioiTinh, Email, DiaChi, SoBHYT, MaNoiDKBD, Ma);
                        XtraMessageBox.Show("Cập Nhật Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CloseCombox();
                    }
                    
                }
                else MessageBox.Show("Vui lòng nhập đúng giới tính 'Nam'hoặc 'Nữ'");
            }
            else MessageBox.Show("Vui lòng kiểm tra lại Họ Tên, Năm Sinh, Giới Tính không được để trống");
        }
        //private void UpdateBanhNhan()
        //{
        //    string Ma = txtMaBenhNhan.Text;
        //    string HoTen = txtHoTen.Text;
        //    int NgaySinh = int.Parse(txtNgaySinh.Text);
        //    int ThangSinh = int.Parse(txtThangSinh.Text);
        //    int NamSinh = int.Parse(txtNamSinh.Text);
        //    string DienThoai = txtSoDienThoai.Text;
        //    string GioiTinh = txtGioiTinh.Text;
        //    string Email = txtEmail.Text;
        //    string DiaChi = txtDiaChi.Text;
        //    string SoBHYT = txtSoBHYT.Text;
        //    string MaNoiDKBD = txtMaDKBD.Text;
        //    if (txtMaBenhNhan.Text == "" || txtMaBenhNhan.Text == null) 
        //    {
        //        BV_BenhNhanDAO.Instance.UpdateBenhNhan(HoTen, NgaySinh, ThangSinh, NamSinh, DienThoai, GioiTinh, Email, DiaChi, SoBHYT, MaNoiDKBD, Ma);
        //        XtraMessageBox.Show("Cập Nhật Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        CloseCombox();
        //    }
        //}
       
        private void OpenCombox()
        {
            txtHoTen.Enabled = true;
            txtNamSinh.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtThangSinh.Enabled = true;
            txtSoDienThoai.Enabled = true;
            txtSoBHYT.Enabled = true;
            txtMaDKBD.Enabled = true;
            txtGioiTinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
        }
        private void CloseCombox()
        {
            txtHoTen.Enabled = false;
            txtNamSinh.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtThangSinh.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtSoBHYT.Enabled = false;
            txtMaDKBD.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
        }
       
        private void LoadNhomDV()
        {
            cbNhomDV.DataSource = NhomDichVuDAO.Instance.LoadNhomDV();
            cbNhomDV.DisplayMember = "Ten";
            cbNhomDV.ValueMember = "Ma";
        }
        private void LoadMauCLS()
        {
            cbMauCLS.DataSource = MauCLSDAO.Instance.LoadFullMauCLS();
            cbMauCLS.DisplayMember = "Ten";
            cbMauCLS.ValueMember = "Ma";
       }
        private void LoadDVByNhom(string nhom)
        {
            List<DanhMucDVDTO> ds = DanhMucDVDAO.Instance.LoadDanhMucDVByNhom(nhom);
            cbDichVu.DisplayMember = "Ten";
            cbDichVu.ValueMember = "Ma";
            cbDichVu.DataSource = ds;
        }
        private void LoadNhanSu()
        {
            cbTenBs.DataSource = DanhMucNhanSuDAO.Instance.LoadFull();
            cbTenBs.DisplayMember = "HoTen";
            cbTenBs.ValueMember = "Ma";
        }
        private void LoadDichVuCDNhanh()
        {
            List<DanhMucDVDTO> dsfull = DanhMucDVDAO.Instance.GetListDVFull();
            foreach (var item in dsfull)
            {
                Button bt = new Button()
                 { Width = DanhMucDVDAO.chieuRong, Height = DanhMucDVDAO.chieuDai };
                bt.ImageAlign = ContentAlignment.MiddleCenter;
                bt.TextAlign = ContentAlignment.TopCenter;
                var i = item.DonGia;
                bt.Text = item.Ten + " (" + string.Format("{0:n0}", i) + ")";
                bt.ForeColor = Color.White;
                bt.Click += bt_Click;
                bt.Tag = item.Ma;
                bt.Tag = item;
                bt.BackColor = Color.DodgerBlue;
               // bt.Focus(bt.BackColor=Color.Green);
                flDanhSachDV.Controls.Add(bt);
            }
        }
        //private void LoadBenhNhan(DateTime? tuNgay, DateTime? denNgay)
        //{
        //    gridDanhSach.DataSource = BV_BenhNhanDAO.Instance.LoadBenhNhanByNgay(tuNgay, denNgay);
        //    dataGridView1.DataSource = BV_BenhNhanDAO.Instance.LoadBenhNhanByNgay(tuNgay, denNgay);
        //}
        private void LoadListPhieuCDHA(DateTime? tuNgay, DateTime? denNgay)
        {
            var listCDHA = BV_PhieuCDHADAO.Instance.GetListFullBV_PhieuCDHA().Where(q => q.ThoiGian >= tuNgay && q.ThoiGian < denNgay);
            var listBN = BV_BenhNhanDAO.Instance.GetListFullBV_BenhNhan();
            //var listDMHH = DanhMucDVDAO.Instance.GetListDVFull();
            var listChung = listCDHA.Join(listBN,
                o => o.MaBN,
                p => p.Ma,
                (o, p) => new
                {
                    Ma=o.Id,
                    HoTen = p.HoTen,
                    NgaySinh = p.NgaySinh + "/" + p.ThangSinh + "/" + p.NamSinh,
                    MaDV = o.MaDV,
                    Ngay = o.ThoiGian
                });
            gridDanhSach.DataSource = listChung;

        }
        #region Even
        private void bt_Click(object sender, EventArgs e)
        {
            string Ten = ((sender as Button).Tag as DanhMucDVDTO).Ten;
            lbCD.Text = Ten;
        }
        

        private void bntSave_Click(object sender, EventArgs e)
        {
            //InsertEditBenhNhan();
            //InsertBenhNhan();
            Insert_Update_BenhNhan();
            LoadListPhieuCDHA(dateEditTuNgay.DateTime, dateEditDenNgay.DateTime.AddDays(1));
        }

        private void bntGet_Click(object sender, EventArgs e)
        {
            LoadListPhieuCDHA(dateEditTuNgay.DateTime, dateEditDenNgay.DateTime.AddDays(1));
        }

        private void txtNamSinh_Click(object sender, EventArgs e)
        {
            txtNamSinh.Text = "";
        }

        private void txtNamSinh_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtNamSinh_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void bntPlay_Click(object sender, EventArgs e)
        {
            //if (cam != null && cam.IsRunning)
            //{
            //    cam.Stop();
            //}
            //cam = new VideoCaptureDevice(cameras[cbChonMay.SelectedIndex].MonikerString);
            //cam.NewFrame += Cam_NewFrame;
            //cam.Start();
            PlayCamera();
        }

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitmap;
        }

        private void bntStop_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void bntLayHinh_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.InitialDirectory = "C:\\hinh";
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    pictureBox1.Image.Save(saveFileDialog1.FileName);
            //}
            int name = 1;

            // pictureBox1.Image.Save(saveFileDialog1.FileName = "C:\\hinh\\2.png");
            int chieuRong = 190;
            int chieuDai = 110;
            PictureBox pic = new PictureBox()
            { Width = chieuRong, Height = chieuDai };
            pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            flListPicture.Controls.Add(pic);
            pic.Image = pictureBox1.Image;
            CheckBox check = new CheckBox();
            check.Checked = true;
            check.Text = "Select";
            flListPicture.Controls.Add(check);
            CheckButton button = new CheckButton();
            //{ Width = 23, Height = 23 };
            button.Text = "DELETE";
            button.Image = BHYT.XRDesignRibbonControllerResources.RibbonUserDesigner_HtmlStop;
            button.Click += Button_Click;
            flListPicture.Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Đã Xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridDanhSach_Click(object sender, EventArgs e)
        {
            //Focus();
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void gridView1_FocusedRowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {
         
            txtHoTen.EditValue = lbHoTen;
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
           // FillDataUpdate();
        }
        private void gridDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = new DataGridViewRow();
            //row = dataGridView1.Rows[e.RowIndex];
            //txtHoTen.Text = row.Cells[1].Value.ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txtHoTen.Text = row.Cells[1].Value.ToString();
        }

        private void bntDelete_Click(object sender, EventArgs e)
       // private void bntDelete_Click(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {
           
            ThongTinRong();
            OpenCombox();
            txtHoTen.Focus();
        }
      private void bntEdit_Click(object sender, EventArgs e)
        {
            //gridView1
            //tileView1
            OpenCombox();
            int row = cardView1.FocusedRowHandle;
            string MaID = "Ma";
            object value = cardView1.GetRowCellValue(row, MaID);
            if (value != null)
            {
                Ma = value.ToString();
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn bệnh nhân cần sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //OpenCombox();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           // FillDataUpdate();
        }

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int row = cardView1.FocusedRowHandle;
            string MaID = "Ma";
            object value = cardView1.GetRowCellValue(row, MaID);
            if (value != null)
            {
                Ma = value.ToString();
                CloseCombox();
                lbHoTen.Text = txtHoTen.Text;
                //char.ToUpper(char.Parse(lbHoTen.Text));
                lbNamSinh.Text = txtNamSinh.Text;
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn bệnh nhân cần sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bntNew_Click(object sender, EventArgs e)
        {
            OpenCombox();
            ThongTinRong();
        }
       

        private void ThucHienCLS_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control==true&& e.KeyCode==Keys.S)
            {
                bntSave.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.N)
            {
                 bntNew.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.E)
            {
                bntEdit.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.D)
            {
                bntDelete.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.P)
            {
                bntPrint.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.R)
            {
                bntReport.PerformClick();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        private void cbNhomDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id ="";
            System.Windows.Forms.ComboBox cb = sender as System.Windows.Forms.ComboBox;
            if (cb.SelectedItem == null)
                return;
            NhomDVDTO selected = cb.SelectedItem as NhomDVDTO;
            LoadDVByNhom(id);
          //  id = selected.Ten;
           // string ma = selected.Ten;
            LoadDVByNhom(id);
            
        }

        private void cbDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string ten;
            System.Windows.Forms.ComboBox cb = sender as System.Windows.Forms.ComboBox;
            if (cb.SelectedItem == null)
                return;
            DanhMucDVDTO selected = cb.SelectedItem as DanhMucDVDTO;
            lbCD.Text = selected.Ten;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntDanhMuc_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.ShowDialog();
        }

        private void cbMauCLS_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox cb = sender as System.Windows.Forms.ComboBox;
            if (cb.SelectedItem == null)
                return;
            DanhMucMauCLSDTO selected = cb.SelectedItem as DanhMucMauCLSDTO;
            rtMauCLS.Text = selected.NoiDung;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_RowClick_2(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int row = gridView1.FocusedRowHandle;
            string MaID = "Ma";
            object value = gridView1.GetRowCellValue(row, MaID);
            string _ma = value.ToString();
            if (_ma != "")
            {
                var listCDHA = BV_PhieuCDHADAO.Instance.GetListFullBV_PhieuCDHA().Where(q=>q.Id==_ma);
                var listBN = BV_BenhNhanDAO.Instance.GetListFullBV_BenhNhan();
                //var listDMHH = DanhMucDVDAO.Instance.GetListDVFull();
                var listChung = listCDHA.Join(listBN,
                    o => o.MaBN,
                    p => p.Ma,
                    (o, p) => new
                    {
                        Ma=p.Ma,
                        HoTen=p.HoTen,
                        NgaySinh=p.NgaySinh,
                        ThangSinh=p.ThangSinh,
                        NamSinh=p.NamSinh,
                        GioiTinh=p.GioiTinh,
                        DiaChi=p.DiaChi,
                        SoDienThoai=p.SoDienThoai,
                        Email=p.Email,
                        NguoiThucHien=o.NguoiThucHien,
                        ChanDoan=o.ChanDoan,
                        KhoaPhong=o.KhoaPhong,
                        MaDV=o.MaDV,
                        MaMauCLS=o.MaMauCLS,
                        DeNghi=o.DeNghi,
                        KetLuan=o.KetLuan,
                        NoiDung=o.NoiDung,
                        HinhAnhJson=o.HinhAnhjson,
                        SoAnhDaChon=o.SoAnhDaChon,
                   }).ToList();
                var list2 = listChung.SingleOrDefault();
                txtMaBenhNhan.EditValue = list2.Ma;
                txtHoTen.EditValue = list2.HoTen;
                txtNgaySinh.EditValue = list2.NgaySinh.ToString();
                txtThangSinh.EditValue = list2.ThangSinh.ToString();
                txtNamSinh.EditValue = list2.NamSinh.ToString();
                txtGioiTinh.EditValue = list2.GioiTinh;
                txtDiaChi.EditValue = list2.DiaChi;
                txtSoDienThoai.EditValue = list2.SoDienThoai;
                txtEmail.EditValue = list2.Email;
                cbTenBs.Text = list2.NguoiThucHien;
                mmChanDoan.Text = list2.ChanDoan;
                cbKhoaPhong.Text = list2.KhoaPhong;
                cbMauCLS.Text = list2.MaMauCLS;
                cbDichVu.Text = list2.MaDV;
                rtDeNghi.Text = list2.DeNghi;
                rtKetLuan.Text = list2.KetLuan;
                rtMauCLS.Text = list2.NoiDung;
            }
        }

        private void bntPrint_Click(object sender, EventArgs e)
        {

            InPhieuCDHA inreport = new InPhieuCDHA();
            inreport.ShowPreviewDialog();
        }
    }
}
