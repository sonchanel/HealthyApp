using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        void reload()
        {
            buttonSua.Enabled = false;
            buttonThem.Enabled = false;
            buttonXoa.Enabled = false;
            dataGridChitiet.Columns.Clear();
            congthucload();
            labelChitiet.Text = "Chi tiết";
        }
        void nguyenlieuload()
        {
            if (tencongthuc.Length > 0)
            {
                dataGridNguyenLieu.DataSource = conn.LayDuLieu(string.Format("select Id,Tennguyenlieu,Donvi from Nguyenlieu where Tennguyenlieu not in (select Nguyenlieu.Tennguyenlieu from Congthuc,Chitietcongthuc,Nguyenlieu where Congthuc.Id_congthuc = Chitietcongthuc.Id_congthuc and Chitietcongthuc.Id_nguyenlieu = Nguyenlieu.Id and Tencongthuc like N'%{0}%')"
                                                                , tencongthuc));
                dataGridNguyenLieu.Columns["Id"].Visible = false;
                dataGridNguyenLieu.Columns["Tennguyenlieu"].HeaderCell.Value = "Nguyên liệu";
                dataGridNguyenLieu.Columns["Donvi"].HeaderCell.Value = "Đơn vị";
                dataGridNguyenLieu.Columns["Tennguyenlieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridNguyenLieu.Columns["Donvi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        void nguyenlieudachonload()
        {
            if (tencongthuc.Length > 0)
            {
                dataGridNguyenlieuCT.DataSource = conn.LayDuLieu(string.Format("select Id_nguyenlieu,Nguyenlieu.Tennguyenlieu, Chitietcongthuc.Soluong from Congthuc,Chitietcongthuc,Nguyenlieu where Congthuc.Id_congthuc = Chitietcongthuc.Id_congthuc and Chitietcongthuc.Id_nguyenlieu = Nguyenlieu.Id and Tencongthuc like N'%{0}%'"
                                                                , tencongthuc));
                dataGridNguyenlieuCT.Columns["Tennguyenlieu"].HeaderCell.Value = "Nguyên liệu";
                dataGridNguyenlieuCT.Columns["Soluong"].HeaderCell.Value = "Số lượng";
                dataGridNguyenlieuCT.Columns["Id_nguyenlieu"].Visible = false;
                dataGridNguyenlieuCT.Columns["Tennguyenlieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridNguyenlieuCT.Columns["Soluong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
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
                String truyvan = string.Format("INSERT INTO Congthuc VALUES (N'{0}', N'1(khẩu phần)', N'' );"
                    ,tencongthuc);
                conn.Thucthi(truyvan);
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
            tongdinhduongload();
            ghichuload();
            labelTitle.Text = "Chi tiết công thức";
            textBoxTaomoi.Text = tencongthuc;
            buttonTaomoi.Visible = false;
            panelChitiet.Enabled = true;

            buttonCapnhap.Enabled = false;
        }

        void tongdinhduongload()
        {
            if (tencongthuc.Length > 0)
            {
                string truyvan = string.Format("select Tenchiso, Chisodinhduong.Donvi, Sum(Luongchiso*Chitietcongthuc.Soluong) as Tong from Nguyenlieu, Congthuc, Chitietcongthuc,Chisodinhduong where Chisodinhduong.Id=Nguyenlieu.Id and Nguyenlieu.Id = Chitietcongthuc.Id_nguyenlieu and Chitietcongthuc.Id_congthuc = Congthuc.Id_congthuc and Tencongthuc like N'{0}' group by Tenchiso ,Chisodinhduong.Donvi order by Tenchiso"
                    , tencongthuc);
                dataGridTong.DataSource = conn.LayDuLieu(truyvan);
                dataGridTong.Columns["Tenchiso"].HeaderCell.Value = "Chỉ số";
                dataGridTong.Columns["Tong"].HeaderCell.Value = "Tổng";
                dataGridTong.Columns["Donvi"].HeaderCell.Value = "Đơn vị";
                dataGridTong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        void ghichuload()
        {
            if (tencongthuc.Length > 0)
            {
                string truyvan = string.Format("select case when Ghichu is null then '' else Ghichu end as Ghichu from Congthuc where Tencongthuc like N'%{0}%'"
                    , tencongthuc);
                DataTable dt = new DataTable();
                dt = conn.LayDuLieu(truyvan);
                TextBoxGhichu.Text = dt.Rows[0]["Ghichu"].ToString();
            }
        }

        void chitietload(string nguyenlieu)
        {
            labelChitiet.Text = "Chi tiết";
            labelChitiet.Text += " : " + nguyenlieu;
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
                double tong;
                tong = (double)dataGridChitiet.Rows[i].Cells["Luongchiso"].Value * (double)numericSoluong.Value;
                tong = Math.Round(tong, 2);
                dataGridChitiet.Rows[i].Cells["Tong"].Value = tong;
            }
        }

        string id_nguyenlieu = "";
        private void dataGridNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            buttonThem.Enabled = true;
            buttonSua.Enabled = false;
            buttonXoa.Enabled = false;
            id_nguyenlieu = Convert.ToString(dataGridNguyenLieu.Rows[e.RowIndex].Cells["Id"].Value);
            numericSoluong.Value = 1;
            String nguyenlieu = (string)dataGridNguyenLieu.Rows[e.RowIndex].Cells["Tennguyenlieu"].Value;
            chitietload(nguyenlieu);
        }

        private void numericSoluong_ValueChanged(object sender, EventArgs e)
        {
            if (numericSoluong.Value <= 0)
            {
                numericSoluong.Value = 1;
            }
            tinhtong();
        }

        private void ChiTietCongThuc_Load(object sender, EventArgs e)
        {
            reload();
            numericSoluong.Value = 1;

            if (Tuychon == 0)
            {
                buttonTaomoi.Visible = true;
                panelChitiet.Enabled = false;
            }
            else
            {
                String truyvan = "select * from Congthuc";
                dt = conn.LayDuLieu(truyvan);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt.Rows[i]["Id_congthuc"]).Equals(Tuychon))
                    {
                        tencongthuc = Convert.ToString(dt.Rows[i]["Tencongthuc"]);
                        congthucload();
                    }
                }
            }
        }

        private void dataGridNguyenlieuCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonThem.Enabled = false;
            buttonSua.Enabled = true;
            buttonXoa.Enabled = true;
            id_nguyenlieu = Convert.ToString(dataGridNguyenlieuCT.Rows[e.RowIndex].Cells["Id_nguyenlieu"].Value);
            String nguyenlieu = (string)dataGridNguyenlieuCT.Rows[e.RowIndex].Cells["Tennguyenlieu"].Value;
            numericSoluong.Value = Convert.ToDecimal(dataGridNguyenlieuCT.Rows[e.RowIndex].Cells["Soluong"].Value);
            chitietload(nguyenlieu);
        }
        string layidcongthuc()
        {
            if (tencongthuc.Length > 0)
            {
                string truyvan = string.Format("select Id_congthuc from Congthuc where Tencongthuc like N'{0}'"
                    , tencongthuc);
                DataTable dataTable = new DataTable();
                dataTable = conn.LayDuLieu(truyvan);
                string id_congthuc = dataTable.Rows[0]["Id_congthuc"].ToString();
                return id_congthuc;
            }else { return  string.Empty; }
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            string id_congthuc = layidcongthuc();
            string truyvan = string.Format("INSERT INTO Chitietcongthuc VALUES ({0},{1},{2});"
                , id_congthuc, id_nguyenlieu, numericSoluong.Value);
            conn.Thucthi(truyvan);
            reload();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult ketqua = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận xóa", messageBoxButtons);
            if (ketqua == DialogResult.Yes)
            {
                string truyvan = string.Format("DELETE FROM Chitietcongthuc WHERE Id_nguyenlieu = '{0}'"
                , id_nguyenlieu);
                conn.Thucthi(truyvan);
            }
            reload();

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string id_congthuc = layidcongthuc();
            //string truyvan = string.Format("UPDATE Congthuc SET Ghichu = N'{0}',Tencongthuc = N'{1}' WHERE Id_congthuc = '{2}'"
            //    ,TextBoxGhichu.Text,textBoxTaomoi.Text,id_congthuc);
            //conn.Thucthi(truyvan);
            string truyvan = string.Format("UPDATE Chitietcongthuc SET Soluong = {0} WHERE Id_congthuc = {1} and Id_nguyenlieu = {2}"
                , numericSoluong.Value, id_congthuc, id_nguyenlieu);
            conn.Thucthi(truyvan);
            reload();
        }

        private void panelChitiet_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLammoi_Click(object sender, EventArgs e)
        {
            reload();
        }
        void capnhapcongthuc()
        {
            string id_congthuc = layidcongthuc();
            string truyvan = string.Format("UPDATE Congthuc SET Ghichu = N'{0}',Tencongthuc = N'{1}' WHERE Id_congthuc = '{2}'"
                , TextBoxGhichu.Text, textBoxTaomoi.Text, id_congthuc);
            conn.Thucthi(truyvan);
            tencongthuc = textBoxTaomoi.Text;
            reload();
        }
        private void textBoxTaomoi_TextChanged(object sender, EventArgs e)
        {
            buttonCapnhap.Enabled = true;
        }

        private void TextBoxGhichu_TextChanged(object sender, EventArgs e)
        {
            buttonCapnhap.Enabled = true;
        }

        private void buttonCapnhap_Click(object sender, EventArgs e)
        {
            capnhapcongthuc();
            MessageBox.Show("Cập nhập thành công !", "Thông báo");
        }

        private void buttonXoacongthuc_Click(object sender, EventArgs e)
        {

        }
    }
}
