using BHYT;
using BHYT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BHYT.DAO
{
    class BCBHYTDAO
    {
        private static BCBHYTDAO instance;

        internal static BCBHYTDAO Instance
        {
            get
            {
                if (instance == null) instance = new BCBHYTDAO();
                return instance;
            }

         private  set
            {
               BCBHYTDAO.instance = value;
            }
        }
        private BCBHYTDAO() { }
        public DataTable LoadMau21(DateTime? tuNgay, DateTime? denNgay)
        {
            return KeNoiData.Instance.ExecuteQuery("exec Ups_BCBHYT_21 @TuNgay , @DenNgay", new object[] { tuNgay, denNgay });
        }
        //public List<BCBHYT> GetMau21(DateTime? tuNgay, DateTime? denNgay)
        //{
        //    List<BCBHYT> listBC = new List<BCBHYT>();
        //    DataTable dataBC = KeNoiData.Instance.ExecuteQuery("exec Ups_BCBHYT_21 @TuNgay , @DenNgay", new object[] { tuNgay, denNgay });
        //    foreach (DataRow item in dataBC.Rows)
        //    {
        //        BCBHYT bcbhyt = new BCBHYT(item);
        //        listBC.Add(bcbhyt);
        //    }
        //    return listBC;
        //}
        public DataTable LoadMau20(DateTime? tuNgay, DateTime? denNgay)
        {
            return KeNoiData.Instance.ExecuteQuery("exec usp_Mau20 @TuNgay , @DenNgay", new object[] { tuNgay, denNgay });
        }
        public DataTable LoadLog(DateTime? tuNgay, DateTime? denNgay)
        {
          return  KeNoiData.Instance.ExecuteQuery("sp_Ghilog @TuNgay , @DenNgay", new object[] { tuNgay, denNgay });
        }
        public DataTable BCXNT(int kyKT)
        {
            return KeNoiData.Instance.ExecuteQuery("sp_GetBC_XuatNhapTonKhoByKyKT @ThangKT", new object[] { kyKT });
        }
        public DataTable Keketoan()
        {
            DataTable ktt = new DataTable();
           return ktt= KeNoiData.Instance.ExecuteQuery("SELECT * FROM dbo.V_KyKetoan");
        }
        
    }
}
