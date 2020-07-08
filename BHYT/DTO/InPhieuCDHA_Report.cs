using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHYT.DTO
{
   public class InPhieuCDHA_Report
    {

        //Kieu Pro
        public string Ma { set; get; }
        public DateTime? Ngay { set; get; }
        public string HoTen { set; get; }
        public int NgaySinh { set; get; }
        public int ThangSinh { set; get; }
        public int NamSinh { set; get; }
        public string SoDienThoai { set; get; }
        public string GioiTinh { set; get; }
        public string Email { set; get; }
        public string DiaChi { set; get; }
        public string SoBHYT { set; get; }
        public string MaNoiDKBD { set; get; }
        public DateTime? ThoiGianTao { set; get; }
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
    }
}
