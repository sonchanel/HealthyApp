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

        public void trangchuclick()
        {
            trangChủToolStripMenuItem_Click(Owner, new EventArgs());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void HeThong_SizeChanged(object sender, EventArgs e)
        {
            Center(this);
        }

        private void côngThứcToolStripMenuItem_Click(object sender, EventArgs e)
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

        public void congthucclick()
        {
            côngThứcToolStripMenuItem_Click(Owner, new EventArgs());
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            TaiKhoan taiKhoan = new TaiKhoan(Tk);
            taiKhoan.MdiParent = this;
            taiKhoan.Dock = DockStyle.Fill;
            this.ClientSize = taiKhoan.Size;
            taiKhoan.Show();
        }



        private void HeThong_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void Back()
        {
            if (base.Owner != null && base.Owner != null)
            {
                Form Dangnhap = base.Owner;
                Dangnhap.Show();
                Hide();
            }
        }

        private void chỉSốCơThểToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            ChiSoCoThe chiSoCoThe = new ChiSoCoThe();
            chiSoCoThe.MdiParent = this;
            chiSoCoThe.Dock = DockStyle.Fill;
            this.ClientSize = chiSoCoThe.Size;
            chiSoCoThe.Show();
        }
    }
}
