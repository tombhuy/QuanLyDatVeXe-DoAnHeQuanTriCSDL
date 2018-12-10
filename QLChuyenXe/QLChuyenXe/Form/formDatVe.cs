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
        public int mode = 0;
        public string _diemKhoiHanh = "";
        public string _diemDen = "";
        public int _idChuyenXe = 0;
        public DateTime _gioKhoiHanh;


        private void formDatVe_Load(object sender, EventArgs e)
        {
            tabThongTin.SelectedTab = tabChonTuyen;
            DisableTabPage();
            if(mode==1)
            {
                LoadData();
            }

        }

        void LoadData()
        {
            cbDiemKhoiHanh.Text = _diemKhoiHanh;
            cbDiemDen.Text = _diemDen;
            cbDiemKhoiHanh.Enabled = false;
            cbDiemDen.Enabled = false;
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
            (tabThongTin.TabPages[1] as TabPage).Enabled = true;
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
            (tabThongTin.TabPages[2] as TabPage).Enabled = true;
            tabThongTin.SelectedTab = tabThongTinKhachHang;
        }
    }
}
