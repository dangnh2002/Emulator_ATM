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
using GiaLapATM.GUI;

namespace GiaLapATM.GUI
{
    public partial class Master : Form
    {
        public static string nameForm = "";
        public static DangNhapMaPIN DNPIN = new DangNhapMaPIN();
        public Master()
        {
            InitializeComponent();
        }

        private void Master_Load(object sender, EventArgs e)
        {
            if(nameForm == "")
            {
                ChonNgonNgu_Load();
            }
            return;
        }
        private void bttrai1_Click(object sender, EventArgs e)
        {
            if(nameForm == "GiaoDienChinh")
            {
                RutTien_Load();
            }
            return;
        }
        private void bttrai2_Click(object sender, EventArgs e)
        {
            if (nameForm == "GiaoDienChinh")
            {
                XemSoDuTaiKhoan_Load();
            }
            return;
        }

        private void bttrai3_Click(object sender, EventArgs e)
        {
            if(nameForm == "GiaoDienChinh")
            {
                XemSaoKeTaiKhoan_Load();
            }
            return;
        }

        private void bttrai4_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btphai1_Click(object sender, EventArgs e)
        {
            if (nameForm == "GiaoDienChinh")
            {
                DoiMaPIN_Load();
            }
            return;
        }

        private void btphai2_Click(object sender, EventArgs e)
        {
            if (nameForm == "GiaoDienChinh")
            {
                NhapTaiKhoanChuyenDen_Load();
            }
            return;
        }
        public void btphai3_Click(object sender, EventArgs e)
        {
            if (nameForm.Equals("ChonNgonNgu"))
            {
                DangNhapMaPIN_Load();
            }
            
            else if (nameForm.Equals("DangNhapMaPIN"))
            {   
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == nameForm)//nameForm == DangNhapMaPIN
                    {
                        TextBox textbox_txtSoTheATM = form.Controls["txtSoTheATM"] as TextBox;
                        var txtSoTheATM_value = int.Parse(textbox_txtSoTheATM.Text);
                        TextBox textbox_txtSoPIN = form.Controls["txtSoPIN"] as TextBox;
                        var txtSoPIN_value = int.Parse(textbox_txtSoPIN.Text);
                        if (cardDAO.Card.ktDangNhap(txtSoTheATM_value, txtSoPIN_value))
                        {
                            GiaoDienChinh_Load();
                        }
                        else
                        {
                            DangNhapMaPIN_Load();
                        }
                        break;
                    }
                }               
            }
            else if (nameForm.Equals("XemSoDuTaiKhoan"))
            {
                InHoaDon_Load();
            }
            else if (nameForm.Equals("SoDuTaiKhoan"))
            {
                GiaoDienChinh_Load();
            }
            else if (nameForm.Equals("XemSaoKeTaiKhoan"))
            {
                InHoaDon_Load();
            }
            else if (nameForm.Equals("SaoKeTaiKhoan"))
            {
                GiaoDienChinh_Load();
            }
            else if (nameForm == "NhapTaiKhoanChuyenDen")
            {
                NhapSoTienChuyen_Load();
            }
            else if (nameForm == "NhapSoTienChuyen")
            {
                ThongTinChuyenKhoan_Load();
            }
            else if (nameForm == "ThongTinChuyenKhoan")
            {
                NhapSoTienChuyen_Load();
            }
            return;
        }
        private void btphai4_Click(object sender, EventArgs e)
        {
            if (nameForm.Equals("ChonNgonNgu"))
            {
                DangNhapMaPIN_Load();
            }
            else if (nameForm.Equals("XemSoDuTaiKhoan"))
            {
                SoDuTaiKhoan_Load();
            }
            else if (nameForm.Equals("XemSaoKeTaiKhoan"))
            {
                SaoKeTaiKhoan_Load();
            }
            else if (nameForm == "NhapTaiKhoanChuyenDen")
            {
                GiaoDienChinh_Load();
            }
            else if (nameForm == "NhapSoTienChuyen")
            {
                NhapTaiKhoanChuyenDen_Load();
            }
            else if (nameForm == "ThongTinChuyenKhoan")
            {
                GiaoDienChinh_Load();
            }
            return;
        }
        private void ChonNgonNgu_Load()
        {
            this.pnMaster.Controls.Clear();
            ChonNgonNgu chonNgonNgu = new ChonNgonNgu();
            chonNgonNgu.TopLevel = false;
            this.pnMaster.Controls.Add(chonNgonNgu);
            chonNgonNgu.Show();
            nameForm = "ChonNgonNgu";
        }
        private void DangNhapMaPIN_Load()
        {
            this.pnMaster.Controls.Clear();
            DangNhapMaPIN dangNhapMaPIN = new DangNhapMaPIN();
            dangNhapMaPIN.TopLevel = false;
            this.pnMaster.Controls.Add(dangNhapMaPIN);
            dangNhapMaPIN.Show();
            nameForm = "DangNhapMaPIN";
        }
        public void GiaoDienChinh_Load()
        {
            this.pnMaster.Controls.Clear();
            GiaoDienChinh giaoDienChinh = new GiaoDienChinh();
            giaoDienChinh.TopLevel = false;
            this.pnMaster.Controls.Add(giaoDienChinh);
            giaoDienChinh.Show();
            nameForm = "GiaoDienChinh";
        }
        public void RutTien_Load()
        {
            this.pnMaster.Controls.Clear();
            RutTien rutTien = new RutTien();
            rutTien.TopLevel = false;
            this.pnMaster.Controls.Add(rutTien);
            rutTien.Show();
            nameForm = "RutTien";
        }
        public void XemSoDuTaiKhoan_Load()
        {
            this.pnMaster.Controls.Clear();
            XemSoDuTaiKhoan xemSoDuTaiKhoan = new XemSoDuTaiKhoan();
            xemSoDuTaiKhoan.TopLevel = false;
            this.pnMaster.Controls.Add(xemSoDuTaiKhoan);
            xemSoDuTaiKhoan.Show();
            nameForm = "XemSoDuTaiKhoan";
        }
        public void SoDuTaiKhoan_Load()
        {
            this.pnMaster.Controls.Clear();
            SoDuTaiKhoan soDuTaiKhoan = new SoDuTaiKhoan();
            soDuTaiKhoan.TopLevel = false;
            this.pnMaster.Controls.Add(soDuTaiKhoan);
            soDuTaiKhoan.Show();
            nameForm = "SoDuTaiKhoan";
        }
        public void InHoaDon_Load()
        {
            this.pnMaster.Controls.Clear();
            InHoaDon inHoaDon = new InHoaDon();
            inHoaDon.TopLevel = false;
            this.pnMaster.Controls.Add(inHoaDon);
            inHoaDon.Show();
            nameForm = "InHoaDon";
        }
        public void SaoKeTaiKhoan_Load()
        {
            this.pnMaster.Controls.Clear();
            SaoKeTaiKhoan saoKeTaiKhoan = new SaoKeTaiKhoan();
            saoKeTaiKhoan.TopLevel = false;
            this.pnMaster.Controls.Add(saoKeTaiKhoan);
            saoKeTaiKhoan.Show();
            nameForm = "SaoKeTaiKhoan";
        }
        public void XemSaoKeTaiKhoan_Load()
        {
            this.pnMaster.Controls.Clear();
            XemSaoKeTaiKhoan xemSaoKeTaiKhoan = new XemSaoKeTaiKhoan();
            xemSaoKeTaiKhoan.TopLevel = false;
            this.pnMaster.Controls.Add(xemSaoKeTaiKhoan);
            xemSaoKeTaiKhoan.Show();
            nameForm = "XemSaoKeTaiKhoan";
        }
        public void DoiMaPIN_Load()
        {
            this.pnMaster.Controls.Clear();
            DoiMaPIN doiMaPIN = new DoiMaPIN();
            doiMaPIN.TopLevel = false;
            this.pnMaster.Controls.Add(doiMaPIN);
            doiMaPIN.Show();
            nameForm = "DoiMaPIN";
        }
        public void NhapSoTienChuyen_Load()
        {
            this.pnMaster.Controls.Clear();
            NhapSoTienChuyen nhapSoTienChuyen = new NhapSoTienChuyen();
            nhapSoTienChuyen.TopLevel = false;
            this.pnMaster.Controls.Add(nhapSoTienChuyen);
            nhapSoTienChuyen.Show();
            nameForm = "NhapSoTienChuyen";
        }
        public void NhapTaiKhoanChuyenDen_Load()
        {
            this.pnMaster.Controls.Clear();
            NhapTaiKhoanChuyenDen nhapTaiKhoanChuyenDen = new NhapTaiKhoanChuyenDen();
            nhapTaiKhoanChuyenDen.TopLevel = false;
            this.pnMaster.Controls.Add(nhapTaiKhoanChuyenDen);
            nhapTaiKhoanChuyenDen.Show();
            nameForm = "NhapTaiKhoanChuyenDen";
        }
        public void ThongTinChuyenKhoan_Load()
        {
            this.pnMaster.Controls.Clear();
            ThongTinChuyenKhoan thongTinChuyenKhoan = new ThongTinChuyenKhoan();
            thongTinChuyenKhoan.TopLevel = false;
            this.pnMaster.Controls.Add(thongTinChuyenKhoan);
            thongTinChuyenKhoan.Show();
            nameForm = "ThongTinChuyenKhoan";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GiaoDienChinh_Load();
            return;
        }
    }
}
