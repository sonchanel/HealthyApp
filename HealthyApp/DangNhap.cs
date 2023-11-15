using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyApp
{
    public partial class DangNhap : Form
    {
        KetNoi conn = new KetNoi();
        int MK = 0;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            this.Location = new Point(
            (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
            (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2));
            textBoxMatKhau.Clear();
            textBoxTaiKhoan.Clear();
            textBoxMatKhau.PasswordChar = '*';
            pictureBoxMK.Location = new Point(315, 153);
            pictureBoxMK.Image = HealthyApp.Properties.Resources.eyeclose;
            MK = 0;
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            
            load();
        }
        DataTable dt = new DataTable();
        private bool kiemtradangnhap()
        {
            if (textBoxTaiKhoan.Text.Length <= 0 || textBoxMatKhau.Text.Length <= 0)
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống !", "Lỗi");
                return false;
            }
            string truyvan = $"select * from Taikhoan where Taikhoan = '{textBoxTaiKhoan.Text}' and Matkhau = '{textBoxMatKhau.Text}'";
            dt = conn.LayDuLieu(truyvan);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        private void dangnhapload()
        {
            if (base.OwnedForms.Length != 0)
            {
                Form[] cacForm = base.OwnedForms;
                Form[] array = cacForm;
                foreach (Form form in array)
                {
                    if (form.Name == "HeThong")
                    {
                        form.Hide();
                    }
                    else
                    {
                        form.Close();
                    }
                }
            }
            string taikhoan = textBoxTaiKhoan.Text;
            HeThong heThong = new HeThong(taikhoan);
            heThong.Owner = this;
            heThong.Show();
            Hide();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (kiemtradangnhap())
            {
                dangnhapload();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Lỗi");
            }
        }

        private void pictureBoxMK_Click(object sender, EventArgs e)
        {
            if (MK == 0)
            {
                textBoxMatKhau.PasswordChar = '\0';
                pictureBoxMK.Image = HealthyApp.Properties.Resources.eyeopen;
                MK = 1;
            }
            else
            {
                textBoxMatKhau.PasswordChar = '*';
                pictureBoxMK.Image = HealthyApp.Properties.Resources.eyeclose;
                MK = 0;
            }
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            if (base.OwnedForms.Length != 0)
            {
                Form[] cacForm = base.OwnedForms;
                Form[] array = cacForm;
                foreach (Form form in array)
                {
                    if (form.Name == "HeThong")
                    {
                        form.Hide();
                    }
                    else
                    {
                        form.Close();
                    }
                }
            }
            DangKi dangKi = new DangKi();
            dangKi.Owner = this;
            dangKi.Show();
            this.Hide();
        }

        private void DangNhap_Shown(object sender, EventArgs e)
        {
            load();
        }

    }
}
