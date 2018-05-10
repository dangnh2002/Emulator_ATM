using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaLapATM.DAO;
using GiaLapATM.DTO;

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
        public bool KTDangNhap(object sender, EventArgs e)
        {
            string aa = txtSoTheATM.Text;
            button1_Click(sender, e);
            return cardDAO.Card.ktDangNhap(Int32.Parse(txtSoTheATM.Text), Int32.Parse(txtSoPIN.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aa = txtSoTheATM.Text;
            cardDAO.Card.ktDangNhap(Int32.Parse(txtSoTheATM.Text), Int32.Parse(txtSoPIN.Text));
        }
    }
}
