using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHYT.DTO
{
   public class QUANTRI
    {
        public QUANTRI(string hoTen,string dienThoai,string ghiChu,DateTime?ngay,string email,string trangThai, DateTime?ngayChayThu, DateTime? ngayChinhThuc, string sericeBase,string tenCoSoYTe, DateTime? ngayHetHan, decimal soTienThue)
        {
            this.HoTen = hoTen;
            this.DienThoai = dienThoai;
            this.GhiChu = ghiChu;
            this.Ngay = ngay;
            this.Email = email;
            this.TrangThai = trangThai;
            this.NgayChayThu = ngayChayThu;
            this.NgayChinhThuc = ngayChinhThuc;
            this.SericeBase = sericeBase;
            this.TenCoSoYTe = tenCoSoYTe;
            this.NgayHetHan = ngayHetHan;
            this.SoTienThue = soTienThue;
        }
        public QUANTRI(DataRow row)
        {
            this.HoTen = row["HoTen"].ToString();
            this.DienThoai = row["DienThoai"].ToString();
            this.GhiChu = row["GhiChu"].ToString();
            this.Ngay =(DateTime?)Convert.ToDateTime (row["Ngay"].ToString());
            this.Email = row["Email"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
            this.NgayChayThu=(DateTime ?)Convert.ToDateTime(row["NgayChayThu"].ToString());
            this.NgayChinhThuc= (DateTime?)Convert.ToDateTime(row["NgayChinhThuc"].ToString());
            this.SericeBase = row["ServiceBase"].ToString();
            this.TenCoSoYTe = row["TenCoSoYTe"].ToString();
            this.NgayHetHan= (DateTime?)Convert.ToDateTime(row["NgayHetHan"].ToString());
            this.SoTienThue = (decimal)row["SoTienThue"];
           // this.SoTienThue = (decimal)Convert.ToDouble(row["SoTienThue"].ToString());
        }
        private string hoTen;
        private string dienThoai;
        private string ghiChu;
        private DateTime? ngay;
        private string email;
        private string trangThai;
        private DateTime? ngayChayThu;
        private DateTime? ngayChinhThuc;
        private string sericeBase;
        private string tenCoSoYTe;
        private DateTime? ngayHetHan;
        private decimal soTienThue;

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string DienThoai
        {
            get
            {
                return dienThoai;
            }

            set
            {
                dienThoai = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }

        public DateTime? Ngay
        {
            get
            {
                return ngay;
            }

            set
            {
                ngay = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }

        public DateTime? NgayChayThu
        {
            get
            {
                return ngayChayThu;
            }

            set
            {
                ngayChayThu = value;
            }
        }

        public DateTime? NgayChinhThuc
        {
            get
            {
                return ngayChinhThuc;
            }

            set
            {
                ngayChinhThuc = value;
            }
        }

        public string SericeBase
        {
            get
            {
                return sericeBase;
            }

            set
            {
                sericeBase = value;
            }
        }

        public string TenCoSoYTe
        {
            get
            {
                return tenCoSoYTe;
            }

            set
            {
                tenCoSoYTe = value;
            }
        }

        public DateTime? NgayHetHan
        {
            get
            {
                return ngayHetHan;
            }

            set
            {
                ngayHetHan = value;
            }
        }

        public decimal SoTienThue
        {
            get
            {
                return soTienThue;
            }

            set
            {
                soTienThue = value;
            }
        }
    }
}
