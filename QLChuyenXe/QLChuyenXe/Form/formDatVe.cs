using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLChuyenXe
{
    public partial class formDatVe : MetroForm
    {
        public formDatVe()
        {
            InitializeComponent();
            

        }

       

        private void formDatVe_Load(object sender, EventArgs e)
        {
            tabThongTin.SelectedTab = tabChonTuyen;
            DisableTabPage();
            
        }

        void DisableTabPage()
        {
            foreach  (TabPage tab in tabThongTin.TabPages)
            {
                tab.Enabled = false;
            }
            (tabThongTin.TabPages[0] as TabPage).Enabled = true;
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            (tabThongTin.TabPages[1] as TabPage).Enabled = false;
            tabThongTin.SelectedTab = tabChonGhe;
            
        }

        private void tabDatVe_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(!e.TabPage.Enabled)
            {
                e.Cancel = true;
            }
        }

        private void btnTiepTuctab2_Click(object sender, EventArgs e)
        {
            (tabThongTin.TabPages[2] as TabPage).Enabled = false;
            tabThongTin.SelectedTab = tabThongTinKhachHang;
        }
    }
}
