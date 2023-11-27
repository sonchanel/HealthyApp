using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.SqlServer.Server;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HealthyApp
{
    public partial class Baocao : Form
    {
        KetNoi conn = new KetNoi();
        public Baocao()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lbKhoa.Visible = false;
            pbKhoa.Visible = false;
            chartKhoa.Visible = true;
            dateKhoa.Visible = true;
            dgvKhoa.Visible = true;
            btKhoa.Visible = true;
            int year = dateKhoa.Value.Year;
            int month = dateKhoa.Value.Month;
            int day = dateKhoa.Value.Day;


            string truyvan = string.Format("select Tenchiso SUM(Luongchiso) as TongLuongchiso from Chisodinhduong join Thucdon on Chisodinhduong.Id = Thucdon.Id where Thoigian = '{0}-{1}-{2}' group by Tenchiso;", year, month, day);
            DataTable db = conn.LayDuLieu(truyvan);
            dgvKhoa.DataSource = db;
            string a = db.Rows[0]["Tenchiso"].ToString();
            string b = db.Rows[0]["Tenchiso"].ToString();

            Series series = new Series();
            series.Points.AddXY(a, b);

            chartKhoa.Series.Add(series);
        }

        private void btKhoa_Click(object sender, EventArgs e)
        {
            LichSuXemChiSoCoThe a = new LichSuXemChiSoCoThe();
            a.Show();
        }
    }
}
