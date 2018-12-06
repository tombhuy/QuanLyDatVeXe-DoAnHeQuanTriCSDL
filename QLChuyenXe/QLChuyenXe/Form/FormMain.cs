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
    public partial class FormMain : MetroForm
    {
        public FormMain()
        {
            InitializeComponent();
            schedule1.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            schedule1.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            traCuu1.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            lichTrinh1.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            lichKhoiHanh1.BringToFront();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            xe1.BringToFront();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            nhanVien1.BringToFront();
        }
    }
}
