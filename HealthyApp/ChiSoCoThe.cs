using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyApp
{
    public partial class ChiSoCoThe : Form
    {
        KetNoi conn = new KetNoi();
        public ChiSoCoThe()
        {
            InitializeComponent();
            KiemtraNgaysinh();
            HienSolieu();
        }
        public int tuoi;

        private void txtChieucao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCannang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void KiemtraNgaysinh()
        {
            int namsinh = dateNgaysinh.Value.Year;
            int namhientai = DateTime.Now.Year;
            tuoi = namhientai - namsinh;
            if (tuoi < 5) btTinhtoan.Enabled = false;
            else btTinhtoan.Enabled = true;
        }

        private void HienSolieu()
        {
            if (tuoi >= 5 && rbtNam.Checked == true)
            {
                lbSonhecan.Text = "< 18.6";
                lbSobinhthuong.Text = "18.6 - 24.9";
                lbSothuacan.Text = "25 - 29.9";
                lbSobeophi.Text = "> 30";
            }
            else if (tuoi >= 5 && rbtNu.Checked == true)
            {
                lbSonhecan.Text = "< 18.1";
                lbSobinhthuong.Text = "18.1 - 24.4";
                lbSothuacan.Text = "24.5 - 29.4";
                lbSobeophi.Text = "> 29.4";
            }
            if (tuoi >= 50)
            {
                lbSonhecan.Text = "< 17.6";
                lbSobinhthuong.Text = "17.6 - 23.9";
                lbSothuacan.Text = "23.9 - 28.9";
                lbSobeophi.Text = "> 28.9";
            }
        }
        private void rbtNu_Click(object sender, EventArgs e)
        {
            rbtNam.Checked = false;
            rbtNu.Checked = true;
            KiemtraNgaysinh();
            HienSolieu();
        }

        private void rbtNam_Click(object sender, EventArgs e)
        {
            rbtNu.Checked = false;
            rbtNam.Checked = true;
            KiemtraNgaysinh();
            HienSolieu();
        }

        private void dateNgaysinh_ValueChanged(object sender, EventArgs e)
        {
            KiemtraNgaysinh();
            HienSolieu();
        }

        private void btTinhtoan_Click(object sender, EventArgs e)
        {
            float.TryParse(txtCannang.Text, out float weight);
            float.TryParse(txtChieucao.Text, out float height);
            height = height / 100;
            float BMI = weight / (height * height);
            txtChisoBMI.Text = "" + BMI;

            KiemtraNgaysinh();

            if (tuoi >= 5 && rbtNam.Checked == true)
            {
                if (BMI <= 18.5)
                {
                    lbDanhgia.Text = "Nhẹ cân";
                }
                else if (BMI < 25)
                {
                    lbDanhgia.Text = "Bình thường";
                }
                else if (BMI < 30)
                {
                    lbDanhgia.Text = "Thừa cân";
                }
                else
                {
                    lbDanhgia.Text = "Béo phì";
                }
            }

            else if (tuoi >= 5 && rbtNu.Checked == true)
            {
                if (BMI <= 18)
                {
                    lbDanhgia.Text = "Nhẹ cân";
                }
                else if (BMI < 24.5)
                {
                    lbDanhgia.Text = "Bình thường";
                }
                else if (BMI < 29.5)
                {
                    lbDanhgia.Text = "Thừa cân";
                }
                else
                {
                    lbDanhgia.Text = "Béo phì";
                }
            }


            else if (tuoi >= 50)
            {
                if (BMI <= 17.5)
                {
                    lbDanhgia.Text = "Nhẹ cân";
                }
                else if (BMI < 24)
                {
                    lbDanhgia.Text = "Bình thường";
                }
                else if (BMI < 29)
                {
                    lbDanhgia.Text = "Thừa cân";
                }
                else
                {
                    lbDanhgia.Text = "Béo phì";
                }


            }
            string truyvan = string.Format("use HealthyApp insert into Lichsuxemchisocothe values ({0},{1},{2},N'{3}')", txtChieucao.Text, txtCannang.Text, txtChisoBMI.Text, lbDanhgia.Text);
            conn.Thucthi(truyvan);
        }

        private void ChiSoCoThe_Load(object sender, EventArgs e)
        {
            /*            string truyvan = string.Format("select Ngaysinh from Taikhoan where Taikhoan = 'a'");
                        DataTable db = conn.LayDuLieu(truyvan);
                        string a = db.Rows[0]["Ngaysinh"].ToString();
                        dateNgaysinh.Value = ;*/
        }

        private void btLichsu_Click(object sender, EventArgs e)
        {
            LichSuXemChiSoCoThe a = new LichSuXemChiSoCoThe();
            a.Show();
        }
    }
}
