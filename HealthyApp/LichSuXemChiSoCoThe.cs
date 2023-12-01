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
    public partial class LichSuXemChiSoCoThe : Form
    {
        KetNoi conn = new KetNoi();
        public LichSuXemChiSoCoThe()
        {
            InitializeComponent();
        }

        private void LichSuXemChiSoCoThe_Load(object sender, EventArgs e)
        {
            string truyvan = "select * from Lichsuxemchisocothe";
            DataTable db = conn.LayDuLieu(truyvan);
            dgvLichsu.DataSource = db;
        }
    }
}
