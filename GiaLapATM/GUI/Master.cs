using BUS;
using DTO;
using GiaLapATM.GUI.ChuyenKhoan;
using GiaLapATM.GUI.RutTien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaLapATM.GUI
{
    public partial class Master : Form
    {
        public static string nameForm = "", details = "";
        public static double SoThe = 0;
        public static double sothechuyenden = 0, sotienchuyenden = 0;
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
            else if (nameForm == "RutTien")
            {
                //rút 50.000 VNĐ
                var account = AccountBUS.getByAccountNo(SoThe);     //lấy thông tin account từ số thẻ chuyển tiền
                if ((account.Balance - 100000) > 0)                 //kiểm tra số tiền sau khi rút còn đủ 50.000 duy trì thẻ hay không
                {
                    //thực hiện giao dịch
                    if (AccountBUS.RutTien(SoThe, 50000))//thực hiện rút tiền
                        InHoaDon_Load();//thành công
                    else
                        GiaoDienChinh_Load();
                }
                else
                {
                    GiaoDienChinh_Load();
                }
            }
            return;
        }
        private void bttrai2_Click(object sender, EventArgs e)
        {
            if (nameForm == "GiaoDienChinh")
            {
                SoDuTaiKhoan_Load();
            }
            else if (nameForm == "RutTien")
            {
                //rút 100.000 VNĐ
                var account = AccountBUS.getByAccountNo(SoThe);     //lấy thông tin account từ số thẻ chuyển tiền
                if ((account.Balance - 150000) > 0)                 //kiểm tra số tiền sau khi rút còn đủ 50.000 duy trì thẻ hay không
                {
                    //thực hiện giao dịch
                    if (AccountBUS.RutTien(SoThe, 100000))//thực hiện rút tiền
                        InHoaDon_Load();//thành công
                    else
                        GiaoDienChinh_Load();
                }
                else
                {
                    GiaoDienChinh_Load();
                }
            }
            return;
        }
        private void bttrai3_Click(object sender, EventArgs e)
        {
            if (nameForm == "GiaoDienChinh")
            {
                SaoKeTaiKhoan_Load();
            }
            else if (nameForm == "RutTien")
            {
                //rút 200.000 VNĐ
                var account = AccountBUS.getByAccountNo(SoThe);     //lấy thông tin account từ số thẻ chuyển tiền
                if ((account.Balance - 250000) > 0)                 //kiểm tra số tiền sau khi rút còn đủ 50.000 duy trì thẻ hay không
                {
                    //thực hiện giao dịch
                    if (AccountBUS.RutTien(SoThe, 200000))//thực hiện rút tiền
                        InHoaDon_Load();//thành công
                    else
                        GiaoDienChinh_Load();
                }
                else
                {
                    GiaoDienChinh_Load();
                }
            }
            return;
        }
        private void bttrai4_Click(object sender, EventArgs e)
        {
            if (nameForm == "RutTien")
            {
                //rút 500.000 VNĐ
                var account = AccountBUS.getByAccountNo(SoThe);     //lấy thông tin account từ số thẻ chuyển tiền
                if ((account.Balance - 550000) > 0)                 //kiểm tra số tiền sau khi rút còn đủ 50.000 duy trì thẻ hay không
                {
                    //thực hiện giao dịch
                    if (AccountBUS.RutTien(SoThe, 500000))//thực hiện rút tiền
                        InHoaDon_Load();//thành công
                    else
                        GiaoDienChinh_Load();
                }
                else
                {
                    GiaoDienChinh_Load();
                }
            }
            return;
        }
        private void btphai1_Click(object sender, EventArgs e)
        {
            if (nameForm == "GiaoDienChinh")
            {
                DoiMaPIN_Load();
            }
            else if (nameForm == "RutTien")
            {
                //rút 1.000.000 VNĐ
                var account = AccountBUS.getByAccountNo(SoThe);     //lấy thông tin account từ số thẻ chuyển tiền
                if ((account.Balance - 1050000) > 0)                 //kiểm tra số tiền sau khi rút còn đủ 50.000 duy trì thẻ hay không
                {
                    //thực hiện giao dịch
                    if (AccountBUS.RutTien(SoThe, 1000000))//thực hiện rút tiền
                        InHoaDon_Load();//thành công
                    else
                        GiaoDienChinh_Load();
                }
                else
                {
                    GiaoDienChinh_Load();
                }
            }
            return;
        }
        private void btphai2_Click(object sender, EventArgs e)
        {
            if (nameForm == "GiaoDienChinh")
            {
                NhapTaiKhoanChuyenDen_Load();
            }
            else if (nameForm == "RutTien")
            {
                //rút 1.500.000 VNĐ
                var account = AccountBUS.getByAccountNo(SoThe);     //lấy thông tin account từ số thẻ chuyển tiền
                if ((account.Balance - 1550000) > 0)                 //kiểm tra số tiền sau khi rút còn đủ 50.000 duy trì thẻ hay không
                {
                    //thực hiện giao dịch
                    if (AccountBUS.RutTien(SoThe, 1500000))//thực hiện rút tiền
                        InHoaDon_Load();//thành công
                    else
                        GiaoDienChinh_Load();
                }
                else
                {
                    GiaoDienChinh_Load();
                }
            }
            else if (nameForm == "ThongTinChuyenKhoan")
            {
                //thực hiện giao dịch
                if (AccountBUS.ChuyenTien(SoThe, sothechuyenden, sotienchuyenden) && LogBUS.ChuyenTien(SoThe, sothechuyenden, sotienchuyenden, details))
                {
                    //nếu giao dịch thành công và lưu lại lịch sử giao dịch thành công thì trở về giao diện chính
                    ChuyenKhoanThanhCong_Load();
                }
            }
            else if (nameForm == "SaoKeTaiKhoan")
            {
                //in sao kê
                //var Form = Application.OpenForms[1];
                //DataGridView grid = Form.Controls["Grid_saoke"] as DataGridView;
                //exportExcel(grid);
                //btHoaDon.BackColor = Color.White;
                btHoaDon.BackColor = Color.Gray;
                // btHoaDon.BackColor = Color.White;
            }
            else if (nameForm == "SoDuTaiKhoan")
            {
                //in sao kê
                //var Form = Application.OpenForms[1];
                //DataGridView grid = Form.Controls["Grid_saoke"] as DataGridView;
                //exportExcel(grid);
                //btHoaDon.BackColor = Color.White;
                btHoaDon.BackColor = Color.Gray;
                // btHoaDon.BackColor = Color.White;
            }
            return;
        }
        public void btphai3_Click(object sender, EventArgs e)
        {
            if (nameForm.Equals("ChonNgonNgu"))
            {
                DangNhapMaPIN_Load();
            }
            else if (nameForm == "InHoaDon")
            {
                GiaoDichThanhCong_Load();
            }
            else if (nameForm == "RutTien")
            {
                //rút 2.000.000 VNĐ
                var account = AccountBUS.getByAccountNo(SoThe);     //lấy thông tin account từ số thẻ chuyển tiền
                if ((account.Balance - 2050000) > 0)                 //kiểm tra số tiền sau khi rút còn đủ 50.000 duy trì thẻ hay không
                {
                    //thực hiện giao dịch
                    if (AccountBUS.RutTien(SoThe, 2000000))//thực hiện rút tiền
                        InHoaDon_Load();//thành công
                    else
                        GiaoDienChinh_Load();
                }
                else
                {
                    GiaoDienChinh_Load();
                }
            }
            else if (nameForm.Equals("DangNhapMaPIN"))
            {
                var Form = Application.OpenForms[1];    //khởi tạo form đang mở hiện tại
                TextBox txt_MaPin = Form.Controls["txtNhapLieu"] as TextBox;    //lấy textbox nhập mã pin
                if (!string.IsNullOrEmpty(txt_MaPin.Text))  //check null nhập mã pin
                {
                    var mapin = double.Parse(txt_MaPin.Text);
                    if (CardBUS.ktDangNhap(SoThe, mapin))   //kiểm tra mã pin có đúng không 
                    {
                        GiaoDienChinh_Load();   //trở về giao diện chính
                    }
                    else
                    {
                        DangNhapMaPIN_Load();   //load lại nhập mà pin
                        var Form_nhap_ma_pin = Application.OpenForms[1];
                        Label lbl_alert = Form_nhap_ma_pin.Controls["lbl_alert"] as Label;
                        lbl_alert.Visible = true;
                    }
                }
                else
                {
                    DangNhapMaPIN_Load();   //load lại nhập mà pin
                }
            }
            else if (nameForm.Equals("XemSoDuTaiKhoan"))
            {
                btHoaDon.BackColor = Color.Gray;
            }
            else if (nameForm.Equals("SoDuTaiKhoan"))
            {
                GiaoDienChinh_Load();
            }
            else if (nameForm.Equals("SaoKeTaiKhoan"))
            {
                GiaoDienChinh_Load();
            }
            else if (nameForm.Equals("ChuyenKhoanThanhCong"))
            {
                GiaoDienChinh_Load();
            }
            else if (nameForm.Equals("GiaoDichThanhCong"))
            {
                GiaoDienChinh_Load();
            }
            else if (nameForm.Equals("DoiMaPINThanhCong"))
            {
                GiaoDienChinh_Load();
            }
            else if (nameForm == "NhapTaiKhoanChuyenDen")
            {
                var Form = Application.OpenForms[1];    //khởi tạo form đang mở
                TextBox txt_SoTaiKhoan = Form.Controls["txtNhapLieu"] as TextBox;   //lấy textbox nhập số tài khoản chuyển đến
                if (!string.IsNullOrEmpty(txt_SoTaiKhoan.Text)) //check null số tài khoản
                {
                    sothechuyenden = double.Parse(txt_SoTaiKhoan.Text);    //lưu lại số tài khoản chuyển tiền đến
                    var account = AccountBUS.getByAccountNo(sothechuyenden);    //lấy thông tin tài khoản chuyển tiền đến
                    if (account.AccountNo != null)  //check null tài khoản chuyển tiền đến
                    {
                        NhapSoTienChuyen_Load();    //load form nhập số tiền cần chuyển
                    }
                    else
                    {
                        //tài khoản chuyển tiền đến không tồn tại => load lại form nhập tài khoàn chuyển tiền
                        NhapTaiKhoanChuyenDen_Load();
                        var Form_NhapTaiKhoan = Application.OpenForms[1];
                        Label txt_alert = Form_NhapTaiKhoan.Controls["lbl_alert"] as Label;
                        txt_alert.Visible = true;
                    }
                }
                else
                {
                    NhapTaiKhoanChuyenDen_Load();   //load lại form nhập số tài khoản chuyển tiền đến
                }
            }
            else if (nameForm == "NhapSoTienChuyen")
            {
                var Form = Application.OpenForms[1];    //khởi tạo form đang mở
                TextBox txt_Sotienchuyen = Form.Controls["txtNhapLieu"] as TextBox;   //lấy textbox nhập số tiền chuyển đến
                if (!string.IsNullOrEmpty(txt_Sotienchuyen.Text))   //check null số tiền chuyển
                {
                    if (double.Parse(txt_Sotienchuyen.Text) < 2000)
                    {
                        //thông báo số tiền chuyển khoản phải lớn hơn 20,000VNĐ
                        NhapSoTienChuyen_Load();
                        var Form_Nhapsotien = Application.OpenForms[1];
                        Label txt_alert = Form_Nhapsotien.Controls["lbl_alert2"] as Label;
                        txt_alert.Visible = true;
                    }
                    sotienchuyenden = double.Parse(txt_Sotienchuyen.Text); //lưu lại số tiền cần chuyển
                    var account = AccountBUS.getByAccountNo(SoThe); //lấy thông tin account từ số thẻ chuyển tiền
                    if (sotienchuyenden <= account.Balance - 50000)  //check điều kiện số tiền chuyển đi <= số tiền trong thẻ - 50.000 duy trì thẻ
                    {
                        ThongTinChuyenKhoan_Load(); //mở form thông tin chuyển khoản
                    }
                    else
                    {
                        //thông báo phải để lại 50.000 duy trì thẻ
                        NhapSoTienChuyen_Load();
                        var Form_Nhapsotien = Application.OpenForms[1];
                        Label txt_alert = Form_Nhapsotien.Controls["lbl_alert"] as Label;
                        txt_alert.Visible = true;
                    }
                }
                else
                {
                    NhapSoTienChuyen_Load();    //load lại form nhập số tiền chuyển khoản
                }
            }
            else if (nameForm == "ThongTinChuyenKhoan")
            {
                NhapSoTienChuyen_Load();
            }
            else if (nameForm == "DangNhapSoTheATM")
            {
                var Form = Application.OpenForms[1];    //khởi tạo form đang mở
                TextBox txt_sothe = Form.Controls["txtNhapLieu"] as TextBox;    //lấy textbox nhập số thẻ atm
                if (!string.IsNullOrEmpty(txt_sothe.Text))   //check null số thẻ
                {
                    SoThe = double.Parse(txt_sothe.Text); //lưu lại số thẻ
                    var account = AccountBUS.getByAccountNo(SoThe); // lấy thông tin account theo số thẻ
                    if (account.AccountNo == null)   //check account có tồn tại hay không 
                    {
                        DangNhapSoTheATM_Load();    // load lại form nhập số thẻ
                        var Form_nhap_so_the = Application.OpenForms[1];
                        Label lbl_alert = Form_nhap_so_the.Controls["lbl_alert"] as Label;
                        lbl_alert.Visible = true;
                    }
                    else
                    {
                        ChonNgonNgu_Load(); // load form chọn ngôn ngữ
                    }
                }
                else
                {
                    DangNhapSoTheATM_Load();    // load lại form nhập số thẻ
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
            else if (nameForm == "InHoaDon")
            {
                GiaoDichThanhCong_Load();
            }
            else if (nameForm == "GiaoDichThanhCong")
            {
                DangNhapSoTheATM_Load();
            }
            else if (nameForm == "DoiMaPINThanhCong")
            {
                DangNhapSoTheATM_Load();
            }
            else if (nameForm.Equals("XemSoDuTaiKhoan"))
            {
                SoDuTaiKhoan_Load();
            }
            else if (nameForm.Equals("SaoKeTaiKhoan"))
            {
                DangNhapSoTheATM_Load();
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
            else if (nameForm == "SoDuTaiKhoan")
            {
                DangNhapSoTheATM_Load();
            }
            else if (nameForm == "ChuyenKhoanThanhCong")
            {
                DangNhapSoTheATM_Load();
            }
            else if (nameForm == "RutTien")
            {
                //rút số tiền khác
                SoTienKhoac_Load();
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
        private void SoTienKhoac_Load()
        {
            Application.OpenForms[1].Close();
            this.pnMaster.Controls.Clear();
            GUI.RutTien.SoTienKhac soTienKhac = new GUI.RutTien.SoTienKhac();
            soTienKhac.TopLevel = false;
            this.pnMaster.Controls.Add(soTienKhac);
            soTienKhac.Show();
            nameForm = "SoTienKhac";
        }
        private void GiaoDichThanhCong_Load()
        {
            Application.OpenForms[1].Close();
            this.pnMaster.Controls.Clear();
            GUI.RutTien.GiaoDichThanhCong giaoDichThanhCong = new GUI.RutTien.GiaoDichThanhCong();
            giaoDichThanhCong.TopLevel = false;
            this.pnMaster.Controls.Add(giaoDichThanhCong);
            giaoDichThanhCong.Show();
            nameForm = "GiaoDichThanhCong";
        }
        private void DoiMaPINThanhCong_Load()
        {
            Application.OpenForms[1].Close();
            this.pnMaster.Controls.Clear();
            GUI.DoiPin.DoiMaPINThanhCong doiMaPINThanhCong = new GUI.DoiPin.DoiMaPINThanhCong();
            doiMaPINThanhCong.TopLevel = false;
            this.pnMaster.Controls.Add(doiMaPINThanhCong);
            doiMaPINThanhCong.Show();
            nameForm = "DoiMaPINThanhCong";
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
            btHoaDon.BackColor = Color.White;
        }
        public void RutTien_Load()
        {
            Application.OpenForms[1].Close();//đóng form hiện tại đang mở
            this.pnMaster.Controls.Clear();
            GUI.RutTien.RutTien rutTien = new GUI.RutTien.RutTien();
            rutTien.TopLevel = false;
            this.pnMaster.Controls.Add(rutTien);
            rutTien.Show();
            nameForm = "RutTien";
        }
        public void ChuyenKhoanThanhCong_Load()
        {
            Application.OpenForms[1].Close();//đóng form hiện tại đang mở
            this.pnMaster.Controls.Clear();
            ChuyenKhoanThanhCong chuyenKhoanThanhCong = new ChuyenKhoanThanhCong();
            chuyenKhoanThanhCong.TopLevel = false;
            this.pnMaster.Controls.Add(chuyenKhoanThanhCong);
            chuyenKhoanThanhCong.Show();
            nameForm = "ChuyenKhoanThanhCong";
            btHoaDon.BackColor = Color.White;
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
            btHoaDon.BackColor = Color.White;

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
            Label lbl_sodu = Form.Controls["lbl_sodu"] as Label;
            lbl_sodu.Text = AccountBUS.getByAccountNo(SoThe).Balance.ToString("0,000");
            DataGridView gridview = Form.Controls["grtest"] as DataGridView;
            gridview.DataSource = LogBUS.get5Row(SoThe);
            gridview.Columns[0].Visible = false;
            gridview.Columns[1].Visible = false;
            gridview.Columns[2].Visible = false;
            gridview.Columns[3].Visible = false;
            gridview.Columns[7].Visible = false;
            gridview.Columns[4].HeaderText = "Ngày giao dịch";
            gridview.Columns[4].Width = 130;
            gridview.Columns[5].HeaderText = "Số tiền giao dịch";
            gridview.Columns[5].Width = 130;
            gridview.Columns[6].HeaderText = "Nội dung giao dịch";
            gridview.Columns[6].Width = 190;
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
            lbl_sotienchuyen.Text = sotienchuyenden.ToString("0,000") + "VNĐ";



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
            btHoaDon.BackColor = Color.White;
        }
        #endregion

        #region Bàn phím
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
            DangNhapSoTheATM_Load();
            return;
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            if (nameForm == "SoTienKhoac")
            {
                var Form = Application.OpenForms[1];
                TextBox txt_SoTien = Form.Controls["txtNhapLieu"] as TextBox;
                if (!string.IsNullOrEmpty(txt_SoTien.Text))    //check null số tiền nhập vào
                {
                    var sotien = double.Parse(txt_SoTien.Text);
                    var account = AccountBUS.getByAccountNo(SoThe);     //lấy thông tin account từ số thẻ chuyển tiền
                    if ((account.Balance - 50000 - sotien) > 0)         //kiểm tra số tiền sau khi rút còn đủ 50.000 duy trì thẻ hay không
                    {
                        //thực hiện giao dịch
                        if (AccountBUS.RutTien(SoThe, sotien))//thực hiện rút tiền
                            InHoaDon_Load();//thành công
                        else
                            GiaoDienChinh_Load();
                    }
                    else
                    {
                        GiaoDienChinh_Load();
                    }
                }
                else
                {
                    RutTien_Load();
                }
            }
            else if (nameForm == "DoiMaPIN")
            {
                var Form = Application.OpenForms[1];
                TextBox txt_MaPinMoi = Form.Controls["txtNhapLieu"] as TextBox;
                if (!string.IsNullOrEmpty(txt_MaPinMoi.Text))  //check null nhập mã pin
                {
                    var mapinmoi = double.Parse(txt_MaPinMoi.Text);
                    if (CardBUS.DoiPin(SoThe, mapinmoi))   //Đổi mã pin
                    {
                        DoiMaPINThanhCong_Load();   //thông báo đổi pin thành công
                    }
                    else
                    {
                        DoiMaPINThanhCong_Load();   //thông báo đổi pin thất bại
                        var Form_alert = Application.OpenForms[1];      //get form hiện tại
                        Label lbl_alert = Form_alert.Controls["lbl_alert"] as Label;            //get label thông báo thành công
                        lbl_alert.Visible = false;                                              //ẩn label thông báo thành công
                        Label lbl_alert_err = Form_alert.Controls["lbl_alert_err"] as Label;    //get label thông báo thất bại
                        lbl_alert.Visible = true;                                               //hiển thị label thông báo thất bại
                    }
                }
                else
                {
                    DoiMaPIN_Load();   //load lại nhập mà pin
                }
            }
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

    }
}
