using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHYT.DTO
{
  public  class BCBHYT
    {
        private string maDV;
        private string tenBHYT;
        private int soLuong;
        private decimal dongiaBHYT;
        private DateTime? tungay;
        private DateTime? denngay;
        private DateTime? ngay;
        private decimal thanhTien;

        public BCBHYT(string mDV,string tenBHYT,int soLuong, decimal dongiaBHYT, DateTime? ngay,DateTime? tungay,DateTime? denngay,decimal thanhTien)
        {
            this.MaDV = maDV;
            this.TenBHYT = tenBHYT;
            this.SoLuong = soLuong;
            this.DongiaBHYT = dongiaBHYT;
            //this.Ngay = ngay;
            this.Tungay = tungay;
            this.Denngay = denngay;
            this.ThanhTien = thanhTien;

            

        }
        public BCBHYT(DataRow row)
        {
            this.MaDV = row["MaDV"].ToString();
            this.TenBHYT = row["TenBH"].ToString();
            this.SoLuong = (int)row["SL_NGOAITRU"];
            this.DongiaBHYT = (decimal)row["DonGiaBH"];
            this.ThanhTien = (decimal)row["ThanhTien"];
            //this.Ngay = (DateTime?) row["Ngay"];
            //var datengayTemp = row["Ngay"];
            //if (datengayTemp.ToString() != "")
            //    this.Tungay = (DateTime?)datengayTemp;
            //this.Denngay= (DateTime?)datengayTemp;

        }
        public string MaDV
        {
            get
            {
                return maDV;
            }

            set
            {
                maDV = value;
            }
        }

        public string TenBHYT
        {
            get
            {
                return tenBHYT;
            }

            set
            {
                tenBHYT = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public decimal DongiaBHYT
        {
            get
            {
                return dongiaBHYT;
            }

            set
            {
                dongiaBHYT = value;
            }
        }

        public DateTime? Tungay
        {
            get
            {
                return tungay;
            }

            set
            {
                tungay = value;
            }
        }

        public DateTime? Denngay
        {
            get
            {
                return denngay;
            }

            set
            {
                denngay = value;
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

        public decimal ThanhTien
        {
            get
            {
                return thanhTien;
            }

            set
            {
                thanhTien = value;
            }
        }
    }
}
