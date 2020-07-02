using BHYT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHYT.DAO
{
    public class MauCLSDAO
    {
        private static MauCLSDAO instance;

        internal static MauCLSDAO Instance
        {
            get
            {
                if (instance == null) instance = new MauCLSDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        public MauCLSDAO() { }
        public List<DanhMucMauCLSDTO> LoadFullMauCLS()
        {
            List<DanhMucMauCLSDTO> listfull = new List<DanhMucMauCLSDTO>();
            DataTable data = KeNoiData.Instance.ExecuteQuery("SELECT *FROM HT_DMBenhAnMau");
            foreach (DataRow item in data.Rows)
            {
                DanhMucMauCLSDTO cls = new DanhMucMauCLSDTO(item);
                listfull.Add(cls);
            }
            return listfull;
        }
        public void InsertMauCLS(string ma, string ten, string noiDung, string loai, string tieuDeIn, string ketLuan, string deNghi)
        {
            KeNoiData.Instance.ExecuteNonQuery("exec sp_InsertMauText @Ma , @Ten , @NoiDung , @Loai , @TieuDeIn , @KetLuan , @DeNghi", new object[] {ma,ten,noiDung,loai,tieuDeIn,ketLuan,deNghi });
        }
        public void UpdateMauCLS(string ma, string ten, string noiDung, string loai, string tieuDeIn, string ketLuan, string deNghi)
        {
            KeNoiData.Instance.ExecuteNonQuery("exec sp_UpdateMauText @Ma , @Ten , @NoiDung , @Loai , @TieuDeIn , @KetLuan , @DeNghi", new object[] { ma, ten, noiDung, loai, tieuDeIn, ketLuan, deNghi });
        }
        public void DeleteMauCLS(string ma)
        {
            KeNoiData.Instance.ExecuteNonQuery("DELETE FROM dbo.HT_DMBenhAnMau where Ma= " + "'" + ma + "'");
        }
    }
}
