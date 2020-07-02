using BHYT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHYT.DAO
{
   public class NhomDichVuDAO
    {
        private static NhomDichVuDAO instance;

        internal static NhomDichVuDAO Instance
        {
            get
            {
                if (instance == null) instance = new NhomDichVuDAO();
                return NhomDichVuDAO.instance;
            }

            set
            {
                instance = value;
            }
        }
        public NhomDichVuDAO() { }
        public DataTable LoadNhomDV()
        {
            DataTable nhomdv = new DataTable();
            return nhomdv = KeNoiData.Instance.ExecuteQuery("SELECT*FROM dbo.HT_DMNhomDichVu");
        }
        public void InsertNhomDV(string ma,string ten, string phanLoai)
        {
            KeNoiData.Instance.ExecuteNonQuery("exec sp_InsertNhomDV @Ma , @Ten , @PhanLoai", new object[] { ma, ten, phanLoai});
        }
        public List<NhomDVDTO>GetDanhSachNhomById(string id)
        {
            List<NhomDVDTO> listnhomDV = new List<NhomDVDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery(" SELECT *FROM dbo.HT_DMNhomDichVu where Ma="+"'"+id+"'");
            foreach (DataRow item in data.Rows)
            {
                NhomDVDTO nhom = new NhomDVDTO(item);
                listnhomDV.Add(nhom);
            }
            return listnhomDV;
        }
        public List<NhomDVDTO>GetListNhomDVFull()
        {
            List<NhomDVDTO> listnhomDV2 = new List<NhomDVDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery("SELECT *FROM dbo.HT_DMNhomDichVu ");
            foreach (DataRow item in data.Rows)
            {
                NhomDVDTO nhom = new NhomDVDTO(item);
                listnhomDV2.Add(nhom);
            }
            return listnhomDV2;

        }
        public void DeleteNhomDV(string id)
        {
            KeNoiData.Instance.ExecuteNonQuery("DELETE FROM dbo.HT_DMNhomDichVu where Ma= " + "'" + id + "'");
        }
        public void EditNhomDV(string ma, string ten, string phanLoai)
        {
            KeNoiData.Instance.ExecuteNonQuery("exec UpdateNhomDV @ma , @ten , @phanLoai ", new object[] { ma, ten, phanLoai });
        }

    }
}
