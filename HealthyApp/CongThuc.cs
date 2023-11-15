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
        string Tk;
        public CongThuc(string taikhoan)
        {
            Tk = taikhoan;
            InitializeComponent();
        }
        void chitietformload(int tuychon)
        {
            ChiTietCongThuc chiTietCongThuc = new ChiTietCongThuc(tuychon, Tk);
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
            buttonXoa.Enabled = false;
            string truyvan = string.Format("select Tencongthuc,Id_congthuc,Donvi,case when Ghichu is null then '' else Ghichu end as Ghichu from congthuc where Taikhoan = '{0}'"
                , Tk);
            DataTable dataTable = conn.LayDuLieu(truyvan);
            dataGridCongThuc.DataSource = dataTable;
            dataGridCongThuc.Columns["Tencongthuc"].HeaderCell.Value = "Công thức";
            dataGridCongThuc.Columns["Id_congthuc"].Visible = false;
            dataGridCongThuc.Columns["Donvi"].HeaderCell.Value = "Đơn vị";
            dataGridCongThuc.Columns["Ghichu"].HeaderCell.Value = "Ghi chú";
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
        int tuychon = -1;
        private void dataGridCongThuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                buttonXoa.Enabled = true;
                tuychon = Convert.ToInt32(dataGridCongThuc.Rows[e.RowIndex].Cells["Id_congthuc"].Value);
            }
        }


        private void buttonXoa_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult ketqua = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận xóa", messageBoxButtons);
            if (ketqua == DialogResult.Yes)
            {
                string truyvan = string.Format("DELETE FROM Congthuc WHERE Id_congthuc = '{0}'"
                , tuychon);
                conn.Thucthi(truyvan);
            }
            congthucload();
        }

        private void dataGridCongThuc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                chitietformload(tuychon);
            }
        }

        private void dataGridCongThuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
