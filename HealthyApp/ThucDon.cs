using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HealthyApp
{
    public partial class ThucDon : Form
    {
        String time;
        DateTime dateTime;
        KetNoi conn = new KetNoi();
        public ThucDon(String thoigian, DateTime datetime)
        {
            time = thoigian;
            dateTime = datetime;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void reload()
        {
            dateTimeTrangChu.Value = dateTime;
            dataGridThucdon.DataSource = conn.LayDuLieu(string.Format("select Id,Tennguyenlieu,Soluong,case when Ghichu is null then '' else Ghichu end as Ghichu from thucdon where Buaan = '{0}' and Thoigian = '{1}'"
                                , time, dateTimeTrangChu.Value));
            dataGridThucdon.Columns["Id"].Visible = false;
            String title = "";
            if (time == "Sang")
                title = "Bữa sáng";
            else if (time == "Trua")
                title = "Bữa Trưa";
            else if (time == "Toi")
                title = "Bữa Tối";
            labelThoiGian.Text = title;

            conn.renameDTV(dataGridThucdon);

            dataGridNguyenLieu.DataSource = conn.LayDuLieu(string.Format("select Tennguyenlieu from Nguyenlieu where Tennguyenlieu not in (SELECT Tennguyenlieu FROM Thucdon where Buaan = '{0}' and Thoigian = '{1}')"
                                                            , time, dateTimeTrangChu.Value));
            dataGridNguyenLieu.Columns["Tennguyenlieu"].HeaderCell.Value = "Nguyên liệu";
            dataGridNguyenLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridChitiet.Columns.Clear();
        }
        void buttonreload()
        {
            Index = -1;
            numericSoluong.Value = 1;
            TextBoxGhichu.Clear();
            buttonThem.Enabled = false;
            buttonXoa.Enabled = false;
            buttonSua.Enabled = false;
            numericSoluong.Enabled = false;

        }
        void lammoi()
        {
            reload();
            buttonreload();
        }
        private void ThucDon_Load(object sender, EventArgs e)
        {
            buttonLammoi_Click(sender, e);
        }
        String title = "";
        private void dataGridNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonreload();
            buttonThem.Enabled = true;
            numericSoluong.Enabled=true;
            title = (string)dataGridNguyenLieu.Rows[e.RowIndex].Cells["Tennguyenlieu"].Value;
            chitietload(title);
        }
        int Index;
        private void dataGridThucdon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                buttonreload();
                buttonXoa.Enabled = true;
                buttonSua.Enabled = true;
                numericSoluong.Enabled=true;
                Index = Convert.ToInt32(dataGridThucdon.Rows[e.RowIndex].Cells["Id"].Value);
                String nguyenlieu = (string)dataGridThucdon.Rows[e.RowIndex].Cells["Tennguyenlieu"].Value;
                numericSoluong.Value = Convert.ToDecimal(dataGridThucdon.Rows[e.RowIndex].Cells["Soluong"].Value);
                TextBoxGhichu.Text = (string)dataGridThucdon.Rows[e.RowIndex].Cells["Ghichu"].Value;
                chitietload(nguyenlieu);
            }
        }

        void chitietload(String nguyenlieu)
        {
            dataGridChitiet.Columns.Clear();
            dataGridChitiet.DataSource = conn.LayDuLieu(string.Format("select Tenchiso,Luongchiso,Donvi from Chisodinhduong,Nguyenlieu where Nguyenlieu.Id=Chisodinhduong.Id and Tennguyenlieu like N'{0}' ORDER BY Tenchiso"
                , nguyenlieu));
            dataGridChitiet.Columns["Tenchiso"].HeaderCell.Value = "Chỉ số";
            dataGridChitiet.Columns["Luongchiso"].HeaderCell.Value = "Khối lượng (trong 100g)";
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

        private void buttonLammoi_Click(object sender, EventArgs e)
        {
            lammoi();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult ketqua = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận xóa", messageBoxButtons);
            if (ketqua == DialogResult.Yes) { }
            String truyvan = string.Format("DELETE FROM Thucdon WHERE Id = '{0}'"
                , Index);
            conn.Thucthi(truyvan);
            buttonLammoi_Click(sender, e);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (title != "")
            {
                string thoigian, buaan, ghichu, tennguyenlieu;
                int soluong;
                thoigian = dateTimeTrangChu.Value.ToString();
                buaan = time;
                ghichu = TextBoxGhichu.Text;
                tennguyenlieu = title;
                soluong = Convert.ToInt32(numericSoluong.Value);
                String truyvan = string.Format("INSERT INTO Thucdon(Thoigian, Buaan, Ghichu, Tennguyenlieu, Soluong)VALUES ('{0}', '{1}', '{2}', N'{3}', {4});"
                    , thoigian, buaan, ghichu, tennguyenlieu, soluong);
                conn.Thucthi(truyvan);
                buttonLammoi_Click(sender, e);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string truyvan = string.Format("UPDATE Thucdon SET Soluong={0} ,Ghichu=N'{1}' WHERE Id = {2}"
            , numericSoluong.Value, TextBoxGhichu.Text, Index);
            conn.Thucthi(truyvan);
            buttonLammoi_Click(sender, e);
        }

        private void numericSoluong_ValueChanged(object sender, EventArgs e)
        {
            if (numericSoluong.Value <= 0)
            {
                numericSoluong.Value = 1;
            }
            tinhtong();
        }

        private void dataGridThucdon_DataSourceChanged(object sender, EventArgs e)
        {
            String truyvan = string.Format("select Sum(Tong) as TongCalo from (select Sum(Luongchiso*Thucdon.Soluong) as Tong,Thucdon.Thoigian,Thucdon.Buaan,Thucdon.Tennguyenlieu,Thucdon.Soluong,Chisodinhduong.Id,Chisodinhduong.Tenchiso,Chisodinhduong.Luongchiso from Thucdon,Chisodinhduong,Nguyenlieu where Thucdon.Tennguyenlieu=Nguyenlieu.Tennguyenlieu and Chisodinhduong.Id=Nguyenlieu.Id and Tenchiso = 'calo' and Thucdon.Thoigian = '{0}' and Buaan = '{1}' group by Thoigian,Buaan,Thucdon.Tennguyenlieu,Thucdon.Soluong,Chisodinhduong.Id,Chisodinhduong.Tenchiso,Chisodinhduong.Luongchiso ) as BangCalo"
                                , dateTimeTrangChu.Value, time);
            DataTable dataTable = new DataTable();
            dataTable = conn.LayDuLieu(truyvan);
            textBoxTongCalo.Text = Convert.ToString(dataTable.Rows[0]["TongCalo"].ToString());
            if (textBoxTongCalo.Text != "")
            {
                textBoxTongCalo.Text += " kcal";
            }
        }
    }






}

