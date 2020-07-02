using BHYT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BHYT.DAO
{
    public class DanhMucDVDAO
    {
        private static DanhMucDVDAO instance;

        internal static DanhMucDVDAO Instance
        {
            get
            {
                if (instance == null) instance = new DanhMucDVDAO();
                return DanhMucDVDAO.instance;
            }

            set
            {
                instance = value;
            }
        }
        private DanhMucDVDAO() { }
        public void InsertDanhMucDV(string ma, string hoTen, string nhom, decimal donGia, string donVi, string tuKhoaTimKiem, string mauCLS)
        {
            KeNoiData.Instance.ExecuteNonQuery("exec sp_InserDanhMucDV @Ma , @Ten , @Nhom , @DonGia , @DonVi , @TuKhoaTimKiem , @MaCLS", new object[] { ma, hoTen, nhom, donGia, donVi, tuKhoaTimKiem, mauCLS });
        }
        public DataTable LoadDanhMucDV()
        {
            DataTable danhmuc = new DataTable();
            return danhmuc = KeNoiData.Instance.ExecuteQuery("SELECT*FROM HT_DanhMucThuoc_DQG");
        }
        //public DataTable LoadDanhMucDVByNhom(string nhom)
        //{
        //    DataTable danhmuc = new DataTable();
        //    return danhmuc = KeNoiData.Instance.ExecuteQuery("SELECT*FROM dbo.HT_DMDichvu Where Nhom="+"'"+nhom+"'");
        //}
        public DataTable LoadDMDonVi()
        {
            DataTable dmdv = new DataTable();
            return dmdv = KeNoiData.Instance.ExecuteQuery(" SELECT*FROM dbo.HT_DMDonVi");
        }
        public void DeleteDanhMucDV(string id)
        {
            KeNoiData.Instance.ExecuteNonQuery("DELETE FROM dbo.HT_DMDichvu where Ma= " + "'" + id + "'");
        }
        public List<DanhMucDVDTO> GetListDVFull()
        {
            List<DanhMucDVDTO> listdmDV2 = new List<DanhMucDVDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery("SELECT*FROM dbo.HT_DMDichvu ");
            foreach (DataRow item in data.Rows)
            {
                DanhMucDVDTO dm = new DanhMucDVDTO(item);
                listdmDV2.Add(dm);
            }
            return listdmDV2;
        }
        public List<DanhMucDVDTO> LoadDanhMucDVByNhom(string nhom)
        {
            List<DanhMucDVDTO> listdmDV2 = new List<DanhMucDVDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery("SELECT*FROM dbo.HT_DMDichvu Where Nhom like'%" + nhom + "%'");
            foreach (DataRow item in data.Rows)
            {
                DanhMucDVDTO dm = new DanhMucDVDTO(item);
                listdmDV2.Add(dm);
            }
            return listdmDV2;
        }
        public static int chieuDai = 25;
        public static int chieuRong = 200;
        public List<DanhMucDVDTO> GetDanhSachDVById(string id)
        {
            List<DanhMucDVDTO> listnhomDV = new List<DanhMucDVDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery("SELECT *FROM dbo.HT_DMDichvu where Ma=" + "'" + id + "'");
            foreach (DataRow item in data.Rows)
            {
                DanhMucDVDTO nhom = new DanhMucDVDTO(item);
                listnhomDV.Add(nhom);
            }
            return listnhomDV;

        }
        public void UpdateDMDV(string ma, string hoTen, string nhom, decimal donGia, string donVi, string tuKhoaTimKiem, string mauCLS)
        {
            KeNoiData.Instance.ExecuteQuery("exec sp_UpdateDanhMucDV @Ma , @Ten , @Nhom , @DonGia , @DonVi , @TuKhoaTimKiem , @MaCLS", new object[] { ma, hoTen, nhom, donGia, donVi, tuKhoaTimKiem, mauCLS });
        }
        public void InsertDanhMucThuoc(string ma, string ten, string tenviettat,string nhom, string hamluong, string donvi, string noisx, string nuocsx, string sodangky, string hoatchat, string medicalcode)
        {
            KeNoiData.Instance.ExecuteQuery("exec sp_InsertDMThuoc @Ma , @Ten , @TenVietTat , @Nhom , @HamLuong , @DonVi , @NoiSanXuat , @NuocSX , @SoDangKy , @HoatChat , @MedicalCode", new object[] { ma, ten, tenviettat,nhom, hamluong, donvi, noisx, nuocsx, sodangky, hoatchat, medicalcode});
        }
    }
}
