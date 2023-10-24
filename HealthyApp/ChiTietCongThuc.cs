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
    public partial class ChiTietCongThuc : Form
    {
        KetNoi conn = new KetNoi();
        String tencongthuc = "";
        int Tuychon;
        DataTable dt = new DataTable();
        public ChiTietCongThuc(int tuychon)
        {
            Tuychon = tuychon;
            InitializeComponent();
        }
        void nguyenlieuload()
        {
            dataGridNguyenLieu.DataSource = conn.LayDuLieu(string.Format("select Tennguyenlieu,Donvi from Nguyenlieu where Tennguyenlieu not in (select Nguyenlieu.Tennguyenlieu from Congthuc,Chitietcongthuc,Nguyenlieu where Congthuc.Id_congthuc = Chitietcongthuc.Id_congthuc and Chitietcongthuc.Id_nguyenlieu = Nguyenlieu.Id and Tencongthuc like N'%{0}%')"
                                                            , tencongthuc));
            dataGridNguyenLieu.Columns["Tennguyenlieu"].HeaderCell.Value = "Nguyên liệu";
            dataGridNguyenLieu.Columns["Donvi"].HeaderCell.Value = "Đơn vị";
            dataGridNguyenLieu.Columns["Tennguyenlieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridNguyenLieu.Columns["Donvi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        void nguyenlieudachonload()
        {
            dataGridNguyenlieuCT.DataSource = conn.LayDuLieu(string.Format("select Nguyenlieu.Tennguyenlieu, Chitietcongthuc.Soluong from Congthuc,Chitietcongthuc,Nguyenlieu where Congthuc.Id_congthuc = Chitietcongthuc.Id_congthuc and Chitietcongthuc.Id_nguyenlieu = Nguyenlieu.Id and Tencongthuc like N'%{0}%'"
                                                            , tencongthuc));
            dataGridNguyenlieuCT.Columns["Tennguyenlieu"].HeaderCell.Value = "Nguyên liệu";
            dataGridNguyenlieuCT.Columns["Soluong"].HeaderCell.Value = "Số lượng";
            dataGridNguyenlieuCT.Columns["Tennguyenlieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridNguyenlieuCT.Columns["Soluong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        void buttontaomoitrue()
        {
            labelTaomoi.Visible = true;
            textBoxTaomoi.Visible = true;
            buttonTaomoi.Visible = true;
        }
        void buttontaomoifalse()
        {
            labelTaomoi.Visible = false;
            textBoxTaomoi.Visible = false;
            buttonTaomoi.Visible = false;
        }

        private void dataGridChitiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonTaomoi_Click(object sender, EventArgs e)
        {
            if (textBoxTaomoi.Text.Length > 0)
            {
                tencongthuc = textBoxTaomoi.Text;
                buttontaomoifalse();
                congthucload();

            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên công thức !", "Lỗi");
            }
        }
        void congthucload()
        {
            nguyenlieuload();
            nguyenlieudachonload();
            labelTitle.Text = tencongthuc;
        }

        void chitietload(string nguyenlieu)
        {
            dataGridChitiet.Columns.Clear();
            dataGridChitiet.DataSource = conn.LayDuLieu(string.Format("select Tenchiso,Luongchiso,Chisodinhduong.Donvi from Chisodinhduong,Nguyenlieu where Nguyenlieu.Id=Chisodinhduong.Id and Tennguyenlieu like N'{0}' ORDER BY Tenchiso"
                , nguyenlieu));
            dataGridChitiet.Columns["Tenchiso"].HeaderCell.Value = "Chỉ số";
            dataGridChitiet.Columns["Luongchiso"].HeaderCell.Value = "Khối lượng";
            dataGridChitiet.Columns["Donvi"].HeaderCell.Value = "Đơn vị";

            dataGridChitiet.Columns.Add("Tong", "Tổng");
            dataGridChitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tinhtong();
            for (int i = 0; i < dataGridChitiet.Columns.Count; i++)
            {
                dataGridChitiet.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        void tinhtong()
        {
            for (int i = 0; i < dataGridChitiet.Rows.Count; i++)
            {
                int tong;
                tong = Convert.ToInt32(dataGridChitiet.Rows[i].Cells["Luongchiso"].Value) * Convert.ToInt32(numericSoluong.Value);
                dataGridChitiet.Rows[i].Cells["Tong"].Value = tong;
            }
        }
        int Index;
        private void dataGridNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String nguyenlieu = (string)dataGridNguyenLieu.Rows[e.RowIndex].Cells["Tennguyenlieu"].Value;
            chitietload(nguyenlieu);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericSoluong_ValueChanged(object sender, EventArgs e)
        {
        }

        private void ChiTietCongThuc_Load(object sender, EventArgs e)
        {
            if(Tuychon == 0)
            {
                buttontaomoitrue();
            }
            else
            {
                String truyvan = "select * from Congthuc";
                dt = conn.LayDuLieu(truyvan);
                buttontaomoifalse();
                for(int i = 0;i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt.Rows[i]["Id_congthuc"]).Equals(Tuychon))
                    {
                        tencongthuc = Convert.ToString(dt.Rows[i]["Tencongthuc"]);
                        congthucload();
                    }
                }
            }
        }
    }
}
