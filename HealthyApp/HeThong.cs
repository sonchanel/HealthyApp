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

        private void HeThong_Load(object sender, EventArgs e)
        {
            trangChủToolStripMenuItem_Click(sender, e);
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
    }
}
