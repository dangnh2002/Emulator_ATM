using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaLapATM.GUI
{
    public partial class DangNhapMaPIN : Form
    {
        public static DangNhapMaPIN dnMaPIN = new DangNhapMaPIN();
        public DangNhapMaPIN()
        {
            InitializeComponent();
        }

        private void DangNhapMaPIN_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtSoPIN_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void txtSoPIN_Leave(object sender, EventArgs e)
        {

        }

        private void txtNhapLieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
