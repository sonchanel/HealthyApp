using HealthyApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyApp
{
	public partial class DangKi : Form
	{
		KetNoi conn = new KetNoi();
		int MK = 0;
		int NhapLaiMK = 0;

		public DangKi()
		{
			InitializeComponent();
		}

		private void load()
		{
			textBoxEmail.Clear();
			textBoxMatKhau.Clear();
			textBoxNhapLaiMK.Clear();
			textBoxSDT.Clear();
			textBoxTaiKhoan.Clear();
			textBoxHoTen.Clear();
			dateTimePickerNgaySinh.Value = DateTime.Now;
			dateTimePickerNgaySinh.Format = DateTimePickerFormat.Custom;
			dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
			textBoxMatKhau.PasswordChar = '*';
			textBoxNhapLaiMK.PasswordChar = '*';
			pictureBoxMK.Location = new Point(303, 115);
			pictureBoxNhapLaiMK.Location = new Point(303, 168);
			pictureBoxMK.Image = Resources.eyeclose;
			pictureBoxNhapLaiMK.Image = Resources.eyeclose;
			MK = 0;
			NhapLaiMK = 0;
		}

		private void DangKi_Load(object sender, EventArgs e)
		{
			base.Location = new Point(Screen.PrimaryScreen.Bounds.Size.Width / 2 - base.Size.Width / 2, Screen.PrimaryScreen.Bounds.Size.Height / 2 - base.Size.Height / 2);
			base.MaximizeBox = false;
			load();
		}

		private void pictureBoxMK_Click(object sender, EventArgs e)
		{
			if (MK == 0)
			{
				pictureBoxMK.Image = Resources.eyeopen;
				textBoxMatKhau.PasswordChar = '\0';
				MK = 1;
			}
			else
			{
				pictureBoxMK.Image = Resources.eyeclose;
				textBoxMatKhau.PasswordChar = '*';
				MK = 0;
			}
		}

		private void pictureBoxNhapLaiMK_Click(object sender, EventArgs e)
		{
			if (NhapLaiMK == 0)
			{
				pictureBoxNhapLaiMK.Image = Resources.eyeopen;
				textBoxNhapLaiMK.PasswordChar = '\0';
				NhapLaiMK = 1;
			}
			else
			{
				pictureBoxNhapLaiMK.Image = Resources.eyeclose;
				textBoxNhapLaiMK.PasswordChar = '*';
				NhapLaiMK = 0;
			}
		}

		private void Back()
		{
			if (base.Owner != null && base.Owner != null)
			{
				Form Dangnhap = base.Owner;
				Dangnhap.Show();
				this.Hide();
			}
		}

		private void btDangKi_Click(object sender, EventArgs e)
		{
			if (textBoxTaiKhoan.Text.Length > 0 && textBoxMatKhau.Text.Length > 0 && textBoxNhapLaiMK.Text.Length > 0 && textBoxHoTen.Text.Length > 0 && dateTimePickerNgaySinh.Value < DateTime.Now)
			{
				string truyvan = $"select Taikhoan from Taikhoan where Taikhoan = '{textBoxTaiKhoan.Text}'";
				DataTable dt = conn.LayDuLieu(truyvan);
				if (dt.Rows.Count > 0)
				{
					MessageBox.Show("Tên tài khoản đã được sử dụng ", "Thông báo");
				}
				else if (textBoxMatKhau.Text == textBoxNhapLaiMK.Text)
				{
					truyvan = $"INSERT INTO Taikhoan VALUES (N'{textBoxTaiKhoan.Text}', N'{textBoxMatKhau.Text}', N'{textBoxHoTen.Text}' , '{dateTimePickerNgaySinh.Value}' , N'{textBoxEmail.Text}', '{textBoxSDT.Text}' );";
					if (conn.Thucthi(truyvan))
					{
						MessageBox.Show("Đăng kí thành công", "Thông báo");
						load();
					}
					else
					{
						MessageBox.Show("Đã có lỗi xảy ra", "Lỗi");
					}
				}
				else
				{
					MessageBox.Show("Nhập sai mật khẩu", "Lỗi");
				}
			}
			else
			{
				MessageBox.Show("Nhập thiếu hoặc sai dữ liệu", "Lỗi");
			}
		}

		private void DangKi_FormClosed(object sender, FormClosedEventArgs e)
		{
			Back();
		}

		private void btDangNhap_Click(object sender, EventArgs e)
		{
			Back();
		}
	}
}
