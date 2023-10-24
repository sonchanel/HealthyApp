using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HealthyApp
{
    public partial class CongThuc : Form
    {
        KetNoi conn = new KetNoi();
        public CongThuc()
        {
            InitializeComponent();
        }
        void chitietformload(int tuychon)
        {
            ChiTietCongThuc chiTietCongThuc = new ChiTietCongThuc(tuychon);
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            chiTietCongThuc.MdiParent = this.MdiParent;
            chiTietCongThuc.Dock = DockStyle.Fill;
            this.MdiParent.ClientSize = chiTietCongThuc.Size;
            chiTietCongThuc.Show();
        }
        void congthucload()
        {
            string truyvan = string.Format("select Tencongthuc,Id_congthuc,Donvi,case when Ghichu is null then '' else Ghichu end as Ghichu from congthuc"
                );
            DataTable dataTable = conn.LayDuLieu(truyvan);
            dataGridCongThuc.DataSource = dataTable;
            dataGridCongThuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CongThuc_Load(object sender, EventArgs e)
        {
            congthucload();
        }

        private void buttonCongthuc_Click(object sender, EventArgs e)
        {
            chitietformload(0);
        }

        private void dataGridCongThuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int tuychon = Convert.ToInt32(dataGridCongThuc.Rows[e.RowIndex].Cells["Id_congthuc"].Value);
            chitietformload(tuychon);
        }
    }
}
