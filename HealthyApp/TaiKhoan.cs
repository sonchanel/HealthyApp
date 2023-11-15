using HealthyApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyApp
{
    public partial class TaiKhoan : Form
    {
        KetNoi conn = new KetNoi();
        string Tk;
        int MKcu = 0;
        int MKmoi = 0;
        public TaiKhoan(string taikhoan)
        {
            Tk = taikhoan;
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            string truyvan = $"select * from Taikhoan where Taikhoan = '{Tk}'";
            DataTable datatable = conn.LayDuLieu(truyvan);
            labelTaiKhoan.Text = datatable.Rows[0]["Taikhoan"].ToString();
            string mk = datatable.Rows[0]["Matkhau"].ToString();
            labelMatKhau.Text = "";
            for (int i = 0; i < mk.Length; i++)
            {
                if (labelMatKhau.Text.Length < 10)
                {
                    labelMatKhau.Text += "*";
                }
            }
            textBoxHoTen.Text = datatable.Rows[0]["Hoten"].ToString();
            textBoxEmail.Text = datatable.Rows[0]["Email"].ToString();
            textBoxSDT.Text = datatable.Rows[0]["SDT"].ToString();
            dateTimePickerNgaySinh.Text = datatable.Rows[0]["Ngaysinh"].ToString();
            labelXinchao.Text = "Xin chào " + textBoxHoTen.Text + " !";
            labelXinchao.Location = new Point(57, 30);
            TKMKload();
            thongtinload();
        }
        private void TKMKload()
        {
            textBoxMKmoi.Clear();
            textBoxMKcu.Clear();
            textBoxMKcu.Visible = false;
            textBoxMKmoi.Visible = false;
            buttonXacnhan.Visible = false;
            buttonDoiMatKhau.Visible = true;
            labelMatKhau.Visible = true;
            labelMatKhau.Visible = true;
            labelMkmoi.Visible = false;
            labelMkcu.Visible = false;
            buttonHuybo.Visible = false;
            textBoxMKmoi.PasswordChar = '*';
            textBoxMKcu.PasswordChar = '*';
            pictureBoxMKcu.Location = new Point(303, 116);
            pictureBoxMKmoi.Location = new Point(303, 152);
            pictureBoxMKcu.Image = Resources.eyeclose;
            pictureBoxMKmoi.Image = Resources.eyeclose;
            MKcu = 0;
            MKmoi = 0;
            pictureBoxMKcu.Visible = false;
            pictureBoxMKmoi.Visible = false;
        }
        private void thongtinload()
        {
            textBoxHoTen.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxSDT.Enabled = false;
            dateTimePickerNgaySinh.Enabled = false;
            dateTimePickerNgaySinh.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            buttonChinhSua.Visible = true;
            buttonHoanTat.Visible = false;
            buttonHuyBoChinhSua.Visible = false;
        }


        private void buttonDoiMatKhau_Click(object sender, EventArgs e)
        {
            load();
            labelMatKhau.Visible = false;
            textBoxMKmoi.Visible = true;
            textBoxMKcu.Visible = true;
            buttonXacnhan.Visible = true;
            buttonDoiMatKhau.Visible = false;
            labelMkmoi.Visible = true;
            labelMkcu.Visible = true;
            buttonHuybo.Visible = true;
            labelMatKhau.Visible = false;
            pictureBoxMKmoi.Visible = true;
            pictureBoxMKcu.Visible = true;
        }

        private void buttonXacnhan_Click(object sender, EventArgs e)
        {
            if (textBoxMKcu.Text.Length > 0 && textBoxMKmoi.Text.Length > 0)
            {
                string truyvan = $"select * from Taikhoan where Taikhoan = '{labelTaiKhoan.Text}' and Matkhau = '{textBoxMKcu.Text}'";
                DataTable dt = conn.LayDuLieu(truyvan);
                if (dt.Rows.Count > 0)
                {
                    truyvan = $"Update Taikhoan SET Matkhau = '{textBoxMKmoi.Text}' WHERE Taikhoan = '{labelTaiKhoan.Text}'";
                    if (conn.Thucthi(truyvan))
                    {
                        MessageBox.Show("Đã cập nhập mật khẩu mới", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra", "Lỗi");
                    }
                    load();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không được để trống", "Lỗi");
            }
        }

        private void buttonHuyBo_Click(object sender, EventArgs e)
        {
            load();
        }

        private void buttonChinhSua_Click(object sender, EventArgs e)
        {
            load();
            textBoxHoTen.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxSDT.Enabled = true;
            dateTimePickerNgaySinh.Enabled = true;
            buttonHoanTat.Visible = true;
            buttonHuyBoChinhSua.Visible = true;
            buttonChinhSua.Visible = false;
        }

        private void buttonHuyBoChinhSua_Click(object sender, EventArgs e)
        {
            load();
        }

        private void buttonHoanTat_Click(object sender, EventArgs e)
        {
            if (textBoxHoTen.Text.Length > 0 && dateTimePickerNgaySinh.Value < DateTime.Now)
            {
                string truyvan = $"Update Taikhoan SET Hoten = '{textBoxHoTen.Text}', Ngaysinh = '{dateTimePickerNgaySinh.Value}', Email = '{textBoxEmail.Text}', SDT = '{textBoxSDT.Text}' WHERE Taikhoan = '{labelTaiKhoan.Text}'";
                if (conn.Thucthi(truyvan))
                {
                    MessageBox.Show("Đã cập nhập thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Lỗi");
                }
                load();
            }
            else
            {
                MessageBox.Show("Dữ liệu thiếu hoặc nhập sai", "Lỗi");
            }
        }

        private void pictureBoxMKcu_Click(object sender, EventArgs e)
        {
            if (MKcu == 0)
            {
                pictureBoxMKcu.Image = Resources.eyeopen;
                textBoxMKcu.PasswordChar = '\0';
                MKcu = 1;
            }
            else
            {
                pictureBoxMKcu.Image = Resources.eyeclose;
                textBoxMKcu.PasswordChar = '*';
                MKcu = 0;
            }
        }

        private void pictureBoxMKmoi_Click(object sender, EventArgs e)
        {
            if (MKmoi == 0)
            {
                pictureBoxMKmoi.Image = Resources.eyeopen;
                textBoxMKmoi.PasswordChar = '\0';
                MKmoi = 1;
            }
            else
            {
                pictureBoxMKmoi.Image = Resources.eyeclose;
                textBoxMKmoi.PasswordChar = '*';
                MKmoi = 0;
            }
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent is HeThong)
            {
                HeThong heThong = (HeThong)this.MdiParent;
                heThong.Back();
                heThong.Hide();
            }
        }
    }
}
