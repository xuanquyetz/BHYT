using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHYT.DTO
{
   public class DanhMucMauCLSDTO
    {
        private string ma;
        private string ten;
        private string noiDung;
        private string loai;
        private string tieuDeIn;
        private string ketLuan;
        private string deNghi;
        public DanhMucMauCLSDTO(string ma, string ten, string noiDung, string loai,string tieuDeIn, string ketLuan, string deNghi)
        {
            this.ma = Ma;
            this.ten = Ten;
            this.noiDung = NoiDung;
            this.loai = Loai;
            this.tieuDeIn = TieuDeIn;
            this.ketLuan = KetLuan;
            this.deNghi = DeNghi;
        }
        public DanhMucMauCLSDTO(DataRow row)
        {
            this.Ma = row["Ma"].ToString();
            this.Ten = row["Ten"].ToString();
            this.NoiDung = row["NoiDung"].ToString();
            this.Loai = row["Loai"].ToString();
            this.TieuDeIn = row["TieuDeIn"].ToString();
            this.KetLuan = row["KetLuan"].ToString();
            this.DeNghi = row["DeNghi"].ToString();
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

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public string NoiDung
        {
            get
            {
                return noiDung;
            }

            set
            {
                noiDung = value;
            }
        }

        public string Loai
        {
            get
            {
                return loai;
            }

            set
            {
                loai = value;
            }
        }

        public string TieuDeIn
        {
            get
            {
                return tieuDeIn;
            }

            set
            {
                tieuDeIn = value;
            }
        }

        public string KetLuan
        {
            get
            {
                return ketLuan;
            }

            set
            {
                ketLuan = value;
            }
        }

        public string DeNghi
        {
            get
            {
                return deNghi;
            }

            set
            {
                deNghi = value;
            }
        }
    }
}
