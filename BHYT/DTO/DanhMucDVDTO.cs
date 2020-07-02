using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHYT.DTO
{
   public class DanhMucDVDTO
    {
        private string ma;
        private string ten;
        private string nhom;
        private decimal donGia;
        private string donVi;
        private string tukhoaTimKiem;
        private string maCLS;
        public DanhMucDVDTO(string ma,string ten,string nhom, decimal donGia, string donVi, string tuKhoaTimKiem, string mauCLS)
        {
            this.ma = Ma;
            this.ten = Ten;
            this.nhom = Nhom;
            this.donGia = DonGia;
            this.donVi = DonVi;
            this.tukhoaTimKiem = TukhoaTimKiem;
            this.maCLS = MaCLS;
        }
        public DanhMucDVDTO(DataRow row)
        {
            this.Ma = row["Ma"].ToString();
            this.Ten = row["Ten"].ToString();
            this.Nhom = row["Nhom"].ToString();
           // this.DonGia = (decimal)row["DonGia"];
            this.DonVi = row["DonVi"].ToString();
            this.TukhoaTimKiem = row["TuKhoaTimKiem"].ToString();
            this.MaCLS = row["MauCLS"].ToString();
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

        public string Nhom
        {
            get
            {
                return nhom;
            }

            set
            {
                nhom = value;
            }
        }

        public decimal DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        public string DonVi
        {
            get
            {
                return donVi;
            }

            set
            {
                donVi = value;
            }
        }

        public string TukhoaTimKiem
        {
            get
            {
                return tukhoaTimKiem;
            }

            set
            {
                tukhoaTimKiem = value;
            }
        }

        public string MaCLS
        {
            get
            {
                return maCLS;
            }

            set
            {
                maCLS = value;
            }
        }
    }
}
