using BHYT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHYT.DAO
{
   public class DanhMucNhanSuDAO
    {
        private static DanhMucNhanSuDAO instance;

        public static DanhMucNhanSuDAO Instance
        {
            get
            {
                if (instance == null) instance = new DanhMucNhanSuDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        public DanhMucNhanSuDAO() { }
        public void InserNhanSu(string ma, string hoTen, string phanLoai)
        {
            KeNoiData.Instance.ExecuteNonQuery("exec sp_InsertDanhMucNhanSu @Ma , @Ten , @Loai", new object[] { ma, hoTen, phanLoai });
        }
        public List<DanhMucNhanSuDTO> LoadFull()
        {
            List<DanhMucNhanSuDTO> listfull = new List<DanhMucNhanSuDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery("SELECT *FROM dbo.HT_DMNhanSu");
            foreach (DataRow item in data.Rows)
            {
                DanhMucNhanSuDTO nhansu = new DanhMucNhanSuDTO(item);
                listfull.Add(nhansu);
            }
            return listfull;
        }
        public void DeleteNhanSu(string ma)
        {
            KeNoiData.Instance.ExecuteNonQuery("DELETE FROM dbo.HT_DMNhanSu where Ma= " + "'" + ma + "'");
        }
        public List<DanhMucNhanSuDTO> GetDanhSachNhanSuById(string id)
        {
            List<DanhMucNhanSuDTO> listnhansu = new List<DanhMucNhanSuDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery(" SELECT *FROM dbo.HT_DMNhanSu where Ma=" + "'" + id + "'");
            foreach (DataRow item in data.Rows)
            {
                DanhMucNhanSuDTO ns = new DanhMucNhanSuDTO(item);
                listnhansu.Add(ns);
            }
            return listnhansu;
        }
        public void UpdateNhanSu(string ma, string ten, string loai)
        {
            KeNoiData.Instance.ExecuteNonQuery("exec sp_UpdateNhanSu @Ma , @Ten , @Loai", new object[] { ma, ten, loai });
        }
    }
}
