using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHYT.DTO
{
   public class BV_BenhNhanDTO
    {
        private string ma;
        private DateTime? ngay;
        private string hoTen;
        private int ngaySinh;
        private int thangSinh;
        private int namSinh;
        private string soDienThoai;
        private string gioiTinh;
        private string email;
        private string diaChi;
        private string soBHYT;
        private string maNoiDKBD;
        private DateTime? thoiGianTao;
        public BV_BenhNhanDTO(string hoTen, int namSinh,int ngaySinh,int thangSinh, string soDienThoai, string gioiTinh, string email, string diaChi, string soBHYT, string maNoiDKBD)
        {
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.ThangSinh = thangSinh;
            this.NamSinh = namSinh;
            this.SoDienThoai = soDienThoai;
            this.GioiTinh = gioiTinh;
            this.Email = email;
            this.DiaChi = diaChi;
            this.SoBHYT = soBHYT;
            this.MaNoiDKBD = maNoiDKBD;
        }
        public BV_BenhNhanDTO(DataRow row)
        {
            try
            {
                this.Ma = row["Ma"].ToString();
                this.Ngay = (DateTime?)Convert.ToDateTime(row["Ngay"].ToString());
                this.ThoiGianTao = (DateTime?)Convert.ToDateTime(row["ThoiGianTao"].ToString());
                this.HoTen = row["HoTen"].ToString();
                this.NgaySinh = (int)row["NgaySinh"];
                this.ThangSinh = (int)row["ThangSinh"];
                this.NamSinh = (int)row["NamSinh"];
                this.SoDienThoai = row["DienThoai"].ToString();
                this.GioiTinh = row["GioiTinh"].ToString();
                this.Email = row["Email"].ToString();
                this.DiaChi = row["DiaChi"].ToString();
                this.SoBHYT = row["SoBHYT"].ToString();
                this.MaNoiDKBD = row["MaNoiDKBHYT"].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Kiểm tra lại dữ liệu " + ex.Message);
            }
            
        }

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

        public int NamSinh
        {
            get
            {
                return namSinh;
            }

            set
            {
                namSinh = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
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

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string SoBHYT
        {
            get
            {
                return soBHYT;
            }

            set
            {
                soBHYT = value;
            }
        }

        public string MaNoiDKBD
        {
            get
            {
                return maNoiDKBD;
            }

            set
            {
                maNoiDKBD = value;
            }
        }

        public string Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
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

        public int NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public int ThangSinh
        {
            get
            {
                return thangSinh;
            }

            set
            {
                thangSinh = value;
            }
        }

        public DateTime? ThoiGianTao
        {
            get
            {
                return thoiGianTao;
            }

            set
            {
                thoiGianTao = value;
            }
        }
    }
}
