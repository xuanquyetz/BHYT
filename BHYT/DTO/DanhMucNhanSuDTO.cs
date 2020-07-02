using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHYT.DTO
{
 public  class DanhMucNhanSuDTO
    {
      private  string ma;
      private string hoTen;
      private string phanLoai;
        public DanhMucNhanSuDTO(string ma, string hoTen,string phanLoai)
        {
            this.ma = Ma;
            this.hoTen = HoTen;
            this.phanLoai = PhanLoai;
        }
        public DanhMucNhanSuDTO(DataRow row)
        {
            this.Ma = row["Ma"].ToString();
            this.HoTen = row["Ten"].ToString();
            this.PhanLoai = row["Loai"].ToString();
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

        public string PhanLoai
        {
            get
            {
                return phanLoai;
            }

            set
            {
                phanLoai = value;
            }
        }
    }
}
