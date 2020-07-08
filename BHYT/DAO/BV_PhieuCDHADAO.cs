using BHYT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHYT.DAO
{
   public class BV_PhieuCDHADAO
    {
        private static BV_PhieuCDHADAO instance;

        public static BV_PhieuCDHADAO Instance
        {
            get
            {
                if (instance == null) instance = new BV_PhieuCDHADAO();
                return BV_PhieuCDHADAO.instance;
            }

            set
            {
                instance = value;
            }
        }
        public BV_PhieuCDHADAO() { }
        public List<BV_PhieuCDHADTO> GetListFullBV_PhieuCDHA()
        {
            List<BV_PhieuCDHADTO> listcdha = new List<BV_PhieuCDHADTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery("SELECT *FROM dbo.BV_PhieuCDHA");
            foreach (DataRow item in data.Rows)
            {
                BV_PhieuCDHADTO pt = new BV_PhieuCDHADTO(item);
                listcdha.Add(pt);
            }
            return listcdha;
        }
        public void InsertBV_PhieuCDHA( string khoaPhong, string maBN, string maDV, string nguoiThucHien, string noiDung, string hinhAnhjson, string ketLuan, string deNghi, int loai, string loaiCLS, string chanDoan, string trangThai, string maMauCLS, int soAnhDaChon, int sTT)
        {
            //KeNoiData.Instance.ExecuteNonQuery("INSERT INTO [dbo].[BV_PhieuCDHA]([ID] , [KhoaPhong] , [MaBN] , [MaDV] , [NguoiThucHien] , [NoiDung]  , [HinhAnhJson] , [ThoiGian] , [KetLuan] , [DeNghi] , [Loai] , [LoaiCLS] , [ChanDoanTruocPT] , [TrangThai] , [MaMauCLS] , [SoAnhChonIn] , [STT]) VALUES( NEWID(),"+khoaPhong+","+maBN+ "," + maDV + "," + nguoiThucHien + "," + noiDung + "," + hinhAnhjson + "," + thoiGian + "," + ketLuan + "," + deNghi + "," + loai + "," + loaiCLS + "," + chanDoan + "," + trangThai + "," + maMauCLS + "," + soAnhDaChon + "," + sTT + ")");
            KeNoiData.Instance.ExecuteNonQuery("exec sp_PhieuCDHA @KhoaPhong , @MaBN , @MaDV , @NguoiThucHien , @NoiDung , @HinhAnhJson , @KetLuan , @DeNghi , @Loai , @LoaiCLS , @ChanDoan , @TrangThai , @MaMauCLS , @SoAnhDaChon , @STT", new object[] {
                khoaPhong, maBN, maDV, nguoiThucHien, noiDung, hinhAnhjson, ketLuan, deNghi, loai, loaiCLS, chanDoan, trangThai, maMauCLS, soAnhDaChon,sTT });
        }
        public void DeleteBV_PhieuCDHA(string id)
        {
            KeNoiData.Instance.ExecuteNonQuery("DELETE FROM dbo.BV_PhieuCDHA where Id= " + "'" + id + "'");
        }
        public void UpdateBV_PhieuCDHA(string id,string khoaPhong, string maBN, string maDV, string nguoiThucHien, string noiDung, string hinhAnhjson, string ketLuan, string deNghi, int loai, string loaiCLS, string chanDoan, string maMauCLS, int soAnhDaChon)
        {
             var phieuCDHA= GetListFullBV_PhieuCDHA().SingleOrDefault(q => q.Id == id);
            if (phieuCDHA.KhoaPhong != khoaPhong)
            {
                KeNoiData.Instance.ExecuteNonQuery("update BV_PhieuCDHA set KhoaPhong=N'" + khoaPhong + "' where Ma=N'" + id + "'");
            }
             if (phieuCDHA.MaDV != maDV)
            {
                KeNoiData.Instance.ExecuteNonQuery("update BV_PhieuCDHA set MaDV=N'" + maDV + "' where Ma=N'" + id + "'");
            }
             if (phieuCDHA.NguoiThucHien != nguoiThucHien)
            {
                KeNoiData.Instance.ExecuteNonQuery("update BV_PhieuCDHA set NguoiThucHien=N'" + nguoiThucHien + "' where Ma=N'" + id + "'");
            }
              if (phieuCDHA.NoiDung != noiDung)
            {
                KeNoiData.Instance.ExecuteNonQuery("update BV_PhieuCDHA set NoiDung=N'" + noiDung + "' where Ma=N'" + id + "'");
            }
              if (phieuCDHA.HinhAnhjson != hinhAnhjson)
            {
                KeNoiData.Instance.ExecuteNonQuery("update BV_PhieuCDHA set HinhAnhjson=N'" + hinhAnhjson + "' where Ma=N'" + id + "'");
            }
             if(phieuCDHA.KetLuan!=ketLuan)
            {
                KeNoiData.Instance.ExecuteNonQuery("update BV_PhieuCDHA set KetLuan=N'" + ketLuan + "' where Ma=N'" + id + "'");
            }
             if (phieuCDHA.DeNghi != deNghi)
            {
                KeNoiData.Instance.ExecuteNonQuery("update BV_PhieuCDHA set DeNghi=N'" + deNghi + "' where Ma=N'" + id + "'");
            }
            if (phieuCDHA.Loai != loai)
            {
                KeNoiData.Instance.ExecuteNonQuery("update BV_PhieuCDHA set Loai=N'" + loai + "' where Ma=N'" + id + "'");
            }
            if (phieuCDHA.LoaiCLS != loaiCLS)
            {
                KeNoiData.Instance.ExecuteNonQuery("update BV_PhieuCDHA set LoaiCLS=N'" + loaiCLS + "' where Ma=N'" + id + "'");
            }
            if (phieuCDHA.ChanDoan != chanDoan)
            {
                KeNoiData.Instance.ExecuteNonQuery("update BV_PhieuCDHA set ChanDoan=N'" + chanDoan + "' where Ma=N'" + id + "'");
            }
            if (phieuCDHA.MaMauCLS != maMauCLS)
            {
                KeNoiData.Instance.ExecuteNonQuery("update BV_PhieuCDHA set MaMauCLS=N'" + maMauCLS + "' where Ma=N'" + id + "'");
            }
            if (phieuCDHA.SoAnhDaChon != soAnhDaChon)
            {
                KeNoiData.Instance.ExecuteNonQuery("update BV_PhieuCDHA set SoAnhDaChon=N'" + soAnhDaChon + "' where Ma=N'" + id + "'");
            }
            
        }
    }
}
