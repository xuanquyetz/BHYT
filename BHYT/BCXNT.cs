using BHYT.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHYT
{
    public partial class fBCXNT : Form
    {
        public fBCXNT()
        {
            InitializeComponent();
            GetkyKT();
            
        }
        private void GetBC(int KyKT)
        {
            gvXNT.DataSource = BCBHYTDAO.Instance.BCXNT(KyKT);
        }
        private void GetkyKT()
        {
            cbKyKeToan.DataSource = BCBHYTDAO.Instance.Keketoan();
            cbKyKeToan.DisplayMember = "201901";
            
        }
           
        private void bntGet_Click(object sender, EventArgs e)
        {

            GetBC(cbKyKeToan);
        }

        private void GetBC(ComboBox cbKyKeToan)
        {
            GetkyKT();
        }
    }
}
