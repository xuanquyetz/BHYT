using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BHYT.DAO
{
    public class BV_BenhNhanDAO
    {
        private static BV_BenhNhanDAO instance;

        public static BV_BenhNhanDAO Instance
        {
            get
            {
                if (instance == null) instance = new BV_BenhNhanDAO();
               return BV_BenhNhanDAO.instance ;
            }

          set
            {
               instance = value;
            }
        }
        //private ThucHienCLSDAO() { }
        public void InsertBenhNhan(string hoTen,int ngaySinh,int thangSinh, int namSinh, string soDienThoai, string gioiTinh, string email, string diaChi, string soBHYT, string maNoiDKBD)
        {
            KeNoiData.Instance.ExecuteNonQuery("exec sp_InsertBenhNhan @HoTen , @NgaySinh , @ThangSinh , @NamSinh , @SoDienThoai , @GioiTinh , @Email , @DiaChi , @SoBHYT , @MaNoiDKBHYT", new object[] { hoTen,ngaySinh,thangSinh, namSinh, soDienThoai, gioiTinh, email, diaChi, soBHYT, maNoiDKBD });
        }
        public  DataTable LoadBenhNhanByNgay(DateTime? tuNgay, DateTime? denNgay)
        {
          return KeNoiData.Instance.ExecuteQuery("exec sp_LoadDanhSach @TuNgay , @DenNgay", new object[] { tuNgay, denNgay });
        }
        public DataTable LoadFull()
        {
            DataTable danhsach = new DataTable();
            return danhsach = KeNoiData.Instance.ExecuteQuery("SELECT * FROM dbo.BV_BenhNhan");
        }
        public void UpdateBenhNhan(string hoTen, int ngaySinh, int thangSinh, int namSinh, string soDienThoai, string gioiTinh, string email, string diaChi, string soBHYT, string maNoiDKBD,string Ma)
        {
            KeNoiData.Instance.ExecuteNonQuery("exec sp_UpdateBenhNhan  @HoTen , @NgaySinh , @ThangSinh , @NamSinh , @SoDienThoai , @GioiTinh , @Email , @DiaChi , @SoBHYT , @MaNoiDKBHYT , @Ma", new object[] { hoTen, ngaySinh, thangSinh, namSinh, soDienThoai, gioiTinh, email, diaChi, soBHYT, maNoiDKBD, Ma});
        }
    }
    
}
