﻿using BUS;
using GiaLapATM.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;
//using app = Microsoft.Office.Interop.Excel.Application;

namespace GiaLapATM.GUI
{
    public partial class Master : Form
    {
        public static string nameForm = "", details = "";
        public static int SoThe = 0, sothechuyenden = 0, sotienchuyenden = 0;
        public static DangNhapMaPIN DNPIN = new DangNhapMaPIN();
        public Master()
        {
            InitializeComponent();
        }

        private void Master_Load(object sender, EventArgs e)
        {
            if (nameForm == "")
            {
                DangNhapSoTheATM_Load();
            }
            return;
        }
        private void bttrai1_Click(object sender, EventArgs e)
        {
            if (nameForm == "GiaoDienChinh")
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
            if (nameForm == "GiaoDienChinh")
            {
                SaoKeTaiKhoan_Load();
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
            else if(nameForm == "ThongTinChuyenKhoan")
            {
                if(AccountBUS.ChuyenTien(SoThe,sothechuyenden,sotienchuyenden) && LogBUS.ChuyenTien(SoThe, sothechuyenden, sotienchuyenden, details))
                {
                    GiaoDienChinh_Load();
                }
            }
            if (nameForm == "SaoKeTaiKhoan")
            {
                var Form = Application.OpenForms[1];
                DataGridView grid = Form.Controls["Grid_saoke"] as DataGridView;
                exportExcel(grid);
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
                var Form = Application.OpenForms[1];
                TextBox txt_MaPin = Form.Controls["txtNhapLieu"] as TextBox;
                if (!string.IsNullOrEmpty(txt_MaPin.Text))
                {
                    var mapin = int.Parse(txt_MaPin.Text);
                    if (CardBUS.ktDangNhap(SoThe, mapin))
                    {
                        GiaoDienChinh_Load();
                    }
                    else
                    {
                        DangNhapMaPIN_Load();
                    }
                }
                else
                {
                    DangNhapMaPIN_Load();
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
                var Form = Application.OpenForms[1];
                TextBox txt_SoTaiKhoan = Form.Controls["txtNhapLieu"] as TextBox;
                if (!string.IsNullOrEmpty(txt_SoTaiKhoan.Text))
                {
                    sothechuyenden = int.Parse(txt_SoTaiKhoan.Text);
                    var account = AccountBUS.getByAccountNo(sothechuyenden);
                    if (account.AccountNo != null)
                    {

                        NhapSoTienChuyen_Load();
                    }
                    else
                    {
                        NhapTaiKhoanChuyenDen_Load();
                    }
                }
                else
                {
                    NhapTaiKhoanChuyenDen_Load();
                }                
            }
            else if (nameForm == "NhapSoTienChuyen")
            {
                var Form = Application.OpenForms[1];
                TextBox txt_Sotienchuyen = Form.Controls["txtNhapLieu"] as TextBox;
                if(!string.IsNullOrEmpty(txt_Sotienchuyen.Text))
                {
                    sotienchuyenden = int.Parse(txt_Sotienchuyen.Text);
                    var account = AccountBUS.getByAccountNo(SoThe);
                    if(sotienchuyenden <= account.Balance - 50000)
                    {
                        ThongTinChuyenKhoan_Load();
                    }
                    else
                    {
                        //thông báo phải để lại 50.000 duy trì thẻ
                        NhapSoTienChuyen_Load();
                    }
                }
                else
                {
                    NhapSoTienChuyen_Load();
                }
            }
            else if (nameForm == "ThongTinChuyenKhoan")
            {
                NhapSoTienChuyen_Load();
            }
            else if(nameForm == "DangNhapSoTheATM")
            {
                var Form = Application.OpenForms[1];
                TextBox txt_sothe = Form.Controls["txtNhapLieu"] as TextBox;
                if(!string.IsNullOrEmpty(txt_sothe.Text))
                {
                    SoThe = int.Parse(txt_sothe.Text);
                    var account = AccountBUS.getByAccountNo(SoThe);
                    if(account.AccountNo == null)
                    {
                        // thông báo số thẻ không tồn tại
                        DangNhapSoTheATM_Load();
                    }
                    else
                    {
                        ChonNgonNgu_Load();
                    }
                }
                else
                {
                    DangNhapSoTheATM_Load();
                }
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
        private void button1_Click(object sender, EventArgs e)
        {
            GiaoDienChinh_Load();
            return;
        }

        #region LoadForm
        private void ChonNgonNgu_Load()
        {
            Application.OpenForms[1].Close();
            this.pnMaster.Controls.Clear();
            ChonNgonNgu chonNgonNgu = new ChonNgonNgu();
            chonNgonNgu.TopLevel = false;
            this.pnMaster.Controls.Add(chonNgonNgu);
            chonNgonNgu.Show();
            nameForm = "ChonNgonNgu";
        }
        private void DangNhapMaPIN_Load()
        {
            Application.OpenForms[1].Close();//đóng form hiện tại đang mở
            this.pnMaster.Controls.Clear();
            DangNhapMaPIN dangNhapMaPIN = new DangNhapMaPIN();
            dangNhapMaPIN.TopLevel = false;
            this.pnMaster.Controls.Add(dangNhapMaPIN);
            dangNhapMaPIN.Show();
            nameForm = "DangNhapMaPIN";
        }
        public void GiaoDienChinh_Load()
        {
            Application.OpenForms[1].Close();//đóng form hiện tại đang mở
            this.pnMaster.Controls.Clear();
            GiaoDienChinh giaoDienChinh = new GiaoDienChinh();
            giaoDienChinh.TopLevel = false;
            this.pnMaster.Controls.Add(giaoDienChinh);
            giaoDienChinh.Show();
            nameForm = "GiaoDienChinh";
        }
        public void RutTien_Load()
        {
            Application.OpenForms[1].Close();//đóng form hiện tại đang mở
            this.pnMaster.Controls.Clear();
            RutTien rutTien = new RutTien();
            rutTien.TopLevel = false;
            this.pnMaster.Controls.Add(rutTien);
            rutTien.Show();
            nameForm = "RutTien";
        }
        public void XemSoDuTaiKhoan_Load()
        {
            Application.OpenForms[1].Close();//đóng form hiện tại đang mở
            this.pnMaster.Controls.Clear();
            XemSoDuTaiKhoan xemSoDuTaiKhoan = new XemSoDuTaiKhoan();
            xemSoDuTaiKhoan.TopLevel = false;
            this.pnMaster.Controls.Add(xemSoDuTaiKhoan);
            xemSoDuTaiKhoan.Show();
            nameForm = "XemSoDuTaiKhoan";
        }
        public void SoDuTaiKhoan_Load()
        {
            Application.OpenForms[1].Close();//đóng form hiện tại đang mở
            this.pnMaster.Controls.Clear();
            SoDuTaiKhoan soDuTaiKhoan = new SoDuTaiKhoan();
            soDuTaiKhoan.TopLevel = false;            
            this.pnMaster.Controls.Add(soDuTaiKhoan);
            soDuTaiKhoan.Show();
            nameForm = "SoDuTaiKhoan";

            var account = AccountBUS.getByAccountNo(SoThe);
            var Form = Application.OpenForms[1];
            Label lbl_SoDuChoPhep = Form.Controls["lbl_SoDuChoPhep"] as Label;
            lbl_SoDuChoPhep.Text = account.Balance.ToString("0,000");
            Label lbl_SoDuThucTe = Form.Controls["lbl_SoDuThucTe"] as Label;
            lbl_SoDuThucTe.Text = account.Balance.ToString("0,000");

        }
        public void InHoaDon_Load()
        {
            Application.OpenForms[1].Close();//đóng form hiện tại đang mở
            this.pnMaster.Controls.Clear();
            InHoaDon inHoaDon = new InHoaDon();
            inHoaDon.TopLevel = false;
            this.pnMaster.Controls.Add(inHoaDon);
            inHoaDon.Show();
            nameForm = "InHoaDon";
        }
        public void SaoKeTaiKhoan_Load()
        {
            Application.OpenForms[1].Close();//đóng form hiện tại đang mở
            this.pnMaster.Controls.Clear();
            SaoKeTaiKhoan saoKeTaiKhoan = new SaoKeTaiKhoan();
            saoKeTaiKhoan.TopLevel = false;
            this.pnMaster.Controls.Add(saoKeTaiKhoan);
            saoKeTaiKhoan.Show();
            nameForm = "SaoKeTaiKhoan";
            var Form = Application.OpenForms[1];
            DataGridView grid = Form.Controls["Grid_saoke"] as DataGridView;
            grid.DataSource = LogBUS.get5Rows(SoThe);
            Label lbl_sodu = Form.Controls["lbl_sodu"] as Label;
            lbl_sodu.Text = AccountBUS.getByAccountNo(SoThe).Balance.ToString("0,000");
        }
        public void DoiMaPIN_Load()
        {
            Application.OpenForms[1].Close();//đóng form hiện tại đang mở
            this.pnMaster.Controls.Clear();
            DoiMaPIN doiMaPIN = new DoiMaPIN();
            doiMaPIN.TopLevel = false;
            this.pnMaster.Controls.Add(doiMaPIN);
            doiMaPIN.Show();
            nameForm = "DoiMaPIN";
        }
        public void NhapSoTienChuyen_Load()
        {
            Application.OpenForms[1].Close();//đóng form hiện tại đang mở
            this.pnMaster.Controls.Clear();
            NhapSoTienChuyen nhapSoTienChuyen = new NhapSoTienChuyen();
            nhapSoTienChuyen.TopLevel = false;
            this.pnMaster.Controls.Add(nhapSoTienChuyen);
            nhapSoTienChuyen.Show();
            nameForm = "NhapSoTienChuyen";
        }
        public void NhapTaiKhoanChuyenDen_Load()
        {
            Application.OpenForms[1].Close();//đóng form hiện tại đang mở
            this.pnMaster.Controls.Clear();
            NhapTaiKhoanChuyenDen nhapTaiKhoanChuyenDen = new NhapTaiKhoanChuyenDen();
            nhapTaiKhoanChuyenDen.TopLevel = false;
            this.pnMaster.Controls.Add(nhapTaiKhoanChuyenDen);
            nhapTaiKhoanChuyenDen.Show();
            nameForm = "NhapTaiKhoanChuyenDen";
        }
        public void ThongTinChuyenKhoan_Load()
        {
            Application.OpenForms[1].Close();//đóng form hiện tại đang mở
            this.pnMaster.Controls.Clear();
            ThongTinChuyenKhoan thongTinChuyenKhoan = new ThongTinChuyenKhoan();
            thongTinChuyenKhoan.TopLevel = false;
            this.pnMaster.Controls.Add(thongTinChuyenKhoan);
            thongTinChuyenKhoan.Show();
            nameForm = "ThongTinChuyenKhoan";

            var account = AccountBUS.getByAccountNo(sothechuyenden);
            var AccountInfo = CustomerBUS.getByCustID(account.CustID); 
            var Form = Application.OpenForms[1];
            Label lbl_chutaikhoan = Form.Controls["lbl_chutaikhoan"] as Label;
            lbl_chutaikhoan.Text = AccountInfo.Name;
            Label lbl_sotaikhoan = Form.Controls["lbl_sotaikhoan"] as Label;
            lbl_sotaikhoan.Text = account.AccountNo;
            Label lbl_sotienchuyen = Form.Controls["lbl_sotienchuyen"] as Label;
            lbl_sotienchuyen.Text = sotienchuyenden.ToString("0,000");



        }
        public void DangNhapSoTheATM_Load()
        {
            if (nameForm != "")
            {
                Application.OpenForms[1].Close();//đóng form hiện tại đang mở                
            }
            this.pnMaster.Controls.Clear();
            DangNhapSoTheATM dangNhapSoTheATM = new DangNhapSoTheATM();
            dangNhapSoTheATM.TopLevel = false;
            this.pnMaster.Controls.Add(dangNhapSoTheATM);
            dangNhapSoTheATM.Show();
            nameForm = "DangNhapSoTheATM";
        }
        #endregion

        #region bàn phím
        private bool phimSo(string phim)
        {
            try
            {
                if (nameForm == "DangNhapMaPIN" || nameForm == "DangNhapSoTheATM" || nameForm == "DoiMaPIN" || nameForm == "NhapSoTienChuyen" || nameForm == "NhapTaiKhoanChuyenDen")
                {
                    var form = Application.OpenForms[1];
                    form.Controls["txtNhapLieu"].Text += phim;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            phimSo("1");
            return;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            phimSo("2");
            return;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            phimSo("3");
            return;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            phimSo("4");
            return;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            phimSo("5");
            return;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            phimSo("6");
            return;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            phimSo("7");
            return;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            phimSo("8");
            return;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            phimSo("9");
            return;
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            phimSo("0");
            return;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            if (nameForm == "DangNhapMaPIN" || nameForm == "DangNhapSoTheATM" || nameForm == "DoiMaPIN" || nameForm == "NhapSoTienChuyen" || nameForm == "NhapTaiKhoanChuyenDen")
            {
                var form = Application.OpenForms[1];
                form.Controls["txtNhapLieu"].Text = "";
            }                
            return;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            GiaoDienChinh_Load();
            return;
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            
        }
        private void btBackspace_Click(object sender, EventArgs e)
        {
            if (nameForm == "DangNhapMaPIN" || nameForm == "DangNhapSoTheATM" || nameForm == "DoiMaPIN" || nameForm == "NhapSoTienChuyen" || nameForm == "NhapTaiKhoanChuyenDen")
            {
                var form = Application.OpenForms[1];
                int length = form.Controls["txtNhapLieu"].Text.Length;
                if (length > 0)
                {
                    form.Controls["txtNhapLieu"].Text = form.Controls["txtNhapLieu"].Text.Remove(length - 1, 1);
                }
            }
            return;       
        }
        #endregion

        #region Export
        public void exportExcel(DataGridView g)
        {
            Microsoft.Office.Interop.Excel.Application obj = new Microsoft.Office.Interop.Excel.Application();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            var duongDan = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            obj.ActiveWorkbook.SaveCopyAs(duongDan + @"\SaoKe.xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        #endregion

    }
}
