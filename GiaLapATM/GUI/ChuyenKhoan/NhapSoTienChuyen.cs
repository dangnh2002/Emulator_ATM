﻿using System;
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
    public partial class NhapSoTienChuyen : Form
    {
        public NhapSoTienChuyen()
        {
            InitializeComponent();
        }

        private void txtNhapLieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
