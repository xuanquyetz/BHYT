using BHYT;
using BHYT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BHYT.DAO
{
   public class QUANTRIDAO
    {
        private static QUANTRIDAO instance;

        public static QUANTRIDAO Instance
        {
            get
            {
                if (instance == null) instance = new QUANTRIDAO();
                return QUANTRIDAO.instance;
            }

            set
            {
                instance = value;
            }
        }

        public void ThemKhachHang(string hoTen, string dienThoai, string diaChi, string ghiChu, string ngay, string email, string trangThai, string ngayChayThu, string ngayChayChinhThuc, string serviceBase, string tenCoSoYTe, string ngayHetHan, decimal soTienThue)
        {
            KeNoiData.Instance.ExecuteQuery("exec Usp_ThemKhachHang @HoTen , @SoDienThoai , @DiaChi , @GhiChu , @Ngay , @Email , @TrangThai , @NgayChayThu , @NgayChayChinhThuc , @ServiceBase , @TenCoSoYTe , @NgayHetHan , @SoTienThue" , new object[] { hoTen, dienThoai, diaChi, ghiChu, ngay, email, trangThai, ngayChayThu, ngayChayChinhThuc, serviceBase, tenCoSoYTe, ngayHetHan, soTienThue });
        }
        public DataTable LoadKhachHang()
        {
            DataTable ttt = new DataTable();
          return ttt= KeNoiData.Instance.ExecuteQuery("SELECT*FROM dbo.AD_KhachHang");
        }
        public void UpdateDate(DateTime? ngayHetHan,string id)
        {
            KeNoiData.Instance.ExecuteNonQuery("UPDATE dbo.AD_KhachHang SET NgayHetHan=" + "'" + ngayHetHan + "'" + "WHERE ID like'%" + id + "%'");
        }
        public void UpdateDateFull(string id,string hoTen, string dienThoai,string diaChi,string ghiChu, DateTime? ngay, DateTime? thoiGian,string email, string trangThai, DateTime? ngayChayThu, DateTime? ngayChayChinhThuc, string serviceBase, string tenCoSoYTe, DateTime? ngayHetHan, decimal soTienThue)
        {
            KeNoiData.Instance.ExecuteQuery("exec sp_SuaKhachHang @ID , @HoTen , @DienThoai , @DiaChi , @GhiChu , @Ngay , @ThoiGian , @Email , @TrangThai , @NgayChayThu , @NgayChayChinhThuc , @ServiceBase , @TenCoSoYTe , @NgayHetHan , @SoTienThue", new object[] { id,hoTen,dienThoai,diaChi,ghiChu,ngay,thoiGian,email,trangThai,ngayChayThu,ngayChayChinhThuc,serviceBase,tenCoSoYTe,ngayHetHan,soTienThue});
        }
        public void Delete(string id)
        {
            KeNoiData.Instance.ExecuteNonQuery("  DELETE FROM dbo.AD_KhachHang WHERE ID like'%" + id + "%'");
        }
    }
}
