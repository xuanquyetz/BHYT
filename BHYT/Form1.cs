using BHYT.DAO;
using BHYT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BHYT
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            Getmau21(DateTime.Now,DateTime.Now);
            LoadMau20(DateTime.Now, DateTime.Now);

        }
        //private void Loadmau21(DateTime? ngayvao, DateTime? denngay)
        //{

        //    List<BCBHYT> bcBH = BCBHYTDAO.Instance.GetMau21(ngayvao, denngay);
        //    foreach (BCBHYT item in bcBH)
        //    {
        //        decimal thanhtien = item.DongiaBHYT * item.SoLuong;
        //        ThanhTien.Tag = thanhtien;

        //    }

        //    //dtgv21.DataSource = BCBHYTDAO.Instance.GetMau21(ngayvao,denngay);


        //}
        //private void LoadMau21(DateTime? ngayvao, DateTime? denngay)
        //{
        //    gctMau21.DataSource = BCBHYTDAO.Instance.GetMau21(ngayvao, denngay);
        //    //gctMau21.DataSource = BCBHYTDAO.Instance.LoadMau21(ngayvao, denngay);
        //    //CthanhTien.DisplayFormat.FormatString = "n0";
        //    //CDonGia.DisplayFormat.FormatString = "n0";
        //}
        //private void GetMau21(DateTime? ngayvao,DateTime? denngay)
        //{
        //    gctMau21.DataSource = BCBHYTDAO.Instance.GetMau21(ngayvao, denngay);
        //}
        private void Getmau21 (DateTime? tungay,DateTime? denngay)
        {
            gctMau21.DataSource = BCBHYTDAO.Instance.LoadMau21(tungay, denngay);
        }
        private void LoadMau20(DateTime? ngayvao, DateTime? denngay)
        {
            gvMau20.DataSource = BCBHYTDAO.Instance.LoadMau20(ngayvao, denngay);
            //CthanhTien.DisplayFormat.FormatString = "n0";
            //CDonGia.DisplayFormat.FormatString = "n0";
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //LoadMau21(dtpTuNgay.Value,dtpDenNgay.Value);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntGet_Click(object sender, EventArgs e)
        {
            Getmau21(pTuNgay.Value, pDenNgay.Value);

        }

        private void bntExPortEX_Click(object sender, EventArgs e)
        {
            string Filename = "E:\\BAIHOC\\QLCF\\BHYT\\BHYT\\DATA\\Mau21.xlsx";
            gctMau21.ExportToXlsx(Filename);
            Process.Start(Filename);
        }

        private void bntGet20_Click(object sender, EventArgs e)
        {
            LoadMau20(pTuNgay20.Value, pDenNgay20.Value);
        }

        private void ExportExcell20_Click(object sender, EventArgs e)
        {
            string Filename = "E:\\BAIHOC\\QLCF\\BHYT\\BHYT\\DATA\\Mau20.xlsx";
            gvMau20.ExportToXlsx(Filename);
            Process.Start(Filename);
        }

        private void bntXemLog_Click(object sender, EventArgs e)
        {
            XEMLOG xemlog = new XEMLOG();
            xemlog.ShowDialog();
        }
    }
}
