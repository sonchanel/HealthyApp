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
        public HeThong()
        {
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
            TrangChu trangChu = new TrangChu();
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
            CongThuc congThuc = new CongThuc();
            congThuc.MdiParent = this;
            congThuc.Dock = DockStyle.Fill;
            this.ClientSize = congThuc.Size;
            congThuc.Show();
        }
    }
}
