using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHYT.DTO
{
   public class BV_PhieuCDHADTO
    {
        public string Id { get; set; }
        public string KhoaPhong { get; set; }
        public string MaBN { get; set; }
        public string MaDV { get; set; }
        public string NguoiThucHien { get; set; }
        public string NoiDung { get; set; }
        public string HinhAnhjson { get; set; }
        public DateTime? ThoiGian { get; set; }
        public string KetLuan { get; set; }
        public string DeNghi { get; set; }
        public int Loai { get; set; }
        public string LoaiCLS { get; set; }
        public string ChanDoan { get; set; }
        public string TrangThai { get; set; }
        public string MaMauCLS { get; set; }
        public int SoAnhDaChon { get; set; }
        public int STT { get; set; }

        public BV_PhieuCDHADTO(string id, string khoaPhong, string maBN, string maDV, string nguoiThucHien, string noiDung, string hinhAnhjson, DateTime? thoiGian, string ketLuan, string deNghi, int loai, string loaiCLS, string chanDoan, string trangThai, string maMauCLS, int soAnhDaChon, int sTT)
        {
            this.Id = id;
            this.KhoaPhong = khoaPhong;
            this.MaBN = maBN;
            this.MaDV = maDV;
            this.NguoiThucHien = nguoiThucHien;
            this.NoiDung = noiDung;
            this.HinhAnhjson = hinhAnhjson;
            this.ThoiGian = thoiGian;
            this.KetLuan = ketLuan;
            this.DeNghi = deNghi;
            this.Loai = loai;
            this.LoaiCLS = loaiCLS;
            this.ChanDoan = chanDoan;
            this.TrangThai = trangThai;
            this.MaMauCLS = maMauCLS;
            this.SoAnhDaChon = soAnhDaChon;
            this.STT = sTT;
        }
        public BV_PhieuCDHADTO(DataRow row)
        {
            try
            {
                this.Id = row["ID"].ToString();
                this.ThoiGian = (DateTime?)Convert.ToDateTime(row["ThoiGian"].ToString());
                this.KhoaPhong = row["KhoaPhong"].ToString();
                this.Loai = (Int16)row["Loai"];
                this.SoAnhDaChon = (Int16)row["SoAnhChonIn"];
                this.STT = (int)row["STT"];
                this.MaBN = row["MaBN"].ToString();
                this.MaDV = row["MaDV"].ToString();
                this.NguoiThucHien = row["NguoiThucHien"].ToString();
                this.NoiDung = row["NoiDung"].ToString();
                this.HinhAnhjson = row["HinhAnhjson"].ToString();
                this.KetLuan = row["KetLuan"].ToString();
                this.DeNghi = row["DeNghi"].ToString();
                this.LoaiCLS = row["LoaiCLS"].ToString();
                this.ChanDoan = row["ChanDoanTruocPT"].ToString();
                this.TrangThai = row["TrangThai"].ToString();
                this.MaMauCLS = row["MaMauCLS"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểm tra lại dữ liệu DTO " + ex.Message);
            }
            
        }
    }

}
