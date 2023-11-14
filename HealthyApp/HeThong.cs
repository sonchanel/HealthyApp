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
    public partial class HeThong : Form
    {
        string Tk;
        public HeThong(string taikhoan)
        {
            Tk = taikhoan;
            InitializeComponent();
        }
        private void Center(Form form)
        {
            form.Location = new Point(
            (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2),
            (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }

        //Thay doi thu code
        private void HeThong_Load(object sender, EventArgs e)
        {
            trangChủToolStripMenuItem_Click(sender, e);
            Center(this);
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            TrangChu trangChu = new TrangChu(Tk);
            trangChu.MdiParent = this;
            trangChu.Dock = DockStyle.Fill;
            this.ClientSize = trangChu.Size;
            trangChu.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void HeThong_SizeChanged(object sender, EventArgs e)
        {
            Center(this);
        }

        void côngThứcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            CongThuc congThuc = new CongThuc(Tk);
            congThuc.MdiParent = this;
            congThuc.Dock = DockStyle.Fill;
            this.ClientSize = congThuc.Size;
            congThuc.Show();
        }

//<<<<<<< HEAD
//        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
//=======
//        private void chỉSốCơThểToolStripMenuItem_Click(object sender, EventArgs e)
//>>>>>>> 4185ac5808b7c99d81dc4118fb0f7b1ee2f61e3f
//        {
//            if (ActiveMdiChild != null)
//            {
//                ActiveMdiChild.Close();
//            }
//<<<<<<< HEAD
//            TaiKhoan taiKhoan = new TaiKhoan(Tk);
//            taiKhoan.MdiParent = this;
//            taiKhoan.Dock = DockStyle.Fill;
//            this.ClientSize = taiKhoan.Size;
//            taiKhoan.Show();
//        }

//        private void HeThong_FormClosed(object sender, FormClosedEventArgs e)
//        {
//            Application.Exit();
//=======
//            ChiSoCoThe b = new ChiSoCoThe();
//            b.MdiParent = this;
//            b.Dock = DockStyle.Fill;
//            this.ClientSize = b.Size;
//            b.Show();
//        }

//        private void cáNhânToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            if (ActiveMdiChild != null)
//            {
//                ActiveMdiChild.Close();
//            }
//            CaNhan c = new CaNhan();
//            c.MdiParent = this;
//            c.Dock = DockStyle.Fill;
//            this.ClientSize = c.Size;
//            c.Show();
//>>>>>>> 4185ac5808b7c99d81dc4118fb0f7b1ee2f61e3f
        }
    }
//}
