using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HealthyApp
{
	public partial class NguyenLieu : Form
	{
		KetNoi conn = new KetNoi();
		public NguyenLieu()
		{
			InitializeComponent();
		}
		void reload()
		{
			dataGridChitiet.DataSource = DBNull.Value;
			buttonTaomoi.Visible = true;
			buttonSuaNguyenLieu.Visible = false;
			buttonXoaNguyenLieu.Visible = false;
			buttonThemChitiet.Visible = false;
			textBoxTennguyenlieu.Enabled = true;
			textBoxDonvi.Enabled = true;
			textBoxTennguyenlieu.Clear();
			textBoxDonvi.Clear();
			textBoxTimkiem.Clear();
			textBoxDonvichiso.Clear();
			textBoxTenchiso.Clear();
			textBoxKhoiluong.Clear();
			panelChiso.Visible = false;
			buttonXoaChitiet.Visible = false;
			buttonSuaChitiet.Visible = false;
			buttonLammoichiso.Visible = false;
			load();
		}

		void lammoichiso()
		{
			textBoxDonvichiso.Clear();
			textBoxTenchiso.Clear();
			textBoxKhoiluong.Clear();
			buttonThemChitiet.Visible = true;
			buttonXoaChitiet.Visible = false;
			buttonSuaChitiet.Visible = false;
		}
		DataTable dataTable = new DataTable();
		void load()
		{
			dataTable = conn.LayDuLieu(string.Format("select Tennguyenlieu,Donvi,Id from Nguyenlieu "));
			dataGridNguyenLieu.DataSource = dataTable;
			dataGridNguyenLieu.Columns["Tennguyenlieu"].HeaderCell.Value = "Món ăn";
			dataGridNguyenLieu.Columns["Donvi"].HeaderCell.Value = "Đơn vị";
			dataGridNguyenLieu.Columns["Id"].Visible = false;
			dataGridNguyenLieu.Columns["Tennguyenlieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridNguyenLieu.Columns["Donvi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			for (int i = 0; i < dataGridNguyenLieu.Columns.Count; i++)
			{
				dataGridNguyenLieu.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}



		void chitietload(string nguyenlieu)
		{

			buttonThemChitiet.Visible = true;
			buttonXoaChitiet.Visible = false;
			buttonSuaChitiet.Visible = false;

			textBoxTenchiso.Clear();
			textBoxDonvichiso.Clear();
			textBoxKhoiluong.Clear();
			dataGridChitiet.DataSource = conn.LayDuLieu(string.Format("select Tenchiso,Luongchiso,Chisodinhduong.Donvi from Chisodinhduong,Nguyenlieu where Nguyenlieu.Id=Chisodinhduong.Id and Tennguyenlieu like N'{0}' ORDER BY Tenchiso"
					, nguyenlieu));
			dataGridChitiet.Columns["Tenchiso"].HeaderCell.Value = "Chỉ số";
			dataGridChitiet.Columns["Luongchiso"].HeaderCell.Value = "Khối lượng";
			dataGridChitiet.Columns["Donvi"].HeaderCell.Value = "Đơn vị";
			dataGridChitiet.Columns["Luongchiso"].DefaultCellStyle.Format = "N1";
			for (int i = 0; i < dataGridChitiet.Columns.Count; i++)
			{
				dataGridChitiet.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			}
			dataGridChitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		private void NguyenLieu_Load(object sender, EventArgs e)
		{
			reload();
		}

		int id = 0;
		private void dataGridNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				buttonThemChitiet.Visible = true;
				string title = (string)dataGridNguyenLieu.Rows[e.RowIndex].Cells["Tennguyenlieu"].Value;
				chitietload(title);
				textBoxTennguyenlieu.Text = title;
				textBoxDonvi.Text = (string)dataGridNguyenLieu.Rows[e.RowIndex].Cells["Donvi"].Value;
				id = (int)dataGridNguyenLieu.Rows[e.RowIndex].Cells["Id"].Value;
				buttonTaomoi.Visible = false;
				buttonSuaNguyenLieu.Visible = true;
				buttonXoaNguyenLieu.Visible = true;
				buttonLammoichiso.Visible = true;
				panelChiso.Visible = true;
			}
		}


		void clicknguyenlieu(object sender)
		{
			DataGridViewCellEventArgs sukien = new DataGridViewCellEventArgs(0, 0);
			for (int i = 0; i < dataGridNguyenLieu.Rows.Count; i++)
			{
				for (int a = 0; a < dataGridNguyenLieu.Columns.Count; a++)
				{
					if (dataGridNguyenLieu.Columns[a].Name == "Tennguyenlieu")
					{
						if ((string)dataGridNguyenLieu.Rows[i].Cells[a].Value == textBoxTennguyenlieu.Text)
						{
							sukien = new DataGridViewCellEventArgs(a, i);
						}
					}
				}
			}
			dataGridNguyenLieu_CellClick(sender, sukien);
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (textBoxTennguyenlieu.Text.Length > 0 && textBoxDonvi.Text.Length > 0)
			{
				string truyvan = string.Format("INSERT INTO Nguyenlieu(Tennguyenlieu, Donvi) VALUES (N'{0}', N'{1}');"
					, textBoxTennguyenlieu.Text, textBoxDonvi.Text);
				conn.Thucthi(truyvan);
				load();
				clicknguyenlieu(sender);
			}
			else
			{
				MessageBox.Show("Lỗi", "Giá trị không được để trống");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			reload();
		}
		string tenchisocu = "";
		private void dataGridChitiet_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				buttonThemChitiet.Visible = false;
				buttonSuaChitiet.Visible = true;
				buttonXoaChitiet.Visible = true;
				textBoxTenchiso.Text = (string)dataGridChitiet.Rows[e.RowIndex].Cells["Tenchiso"].Value;
				textBoxKhoiluong.Text = dataGridChitiet.Rows[e.RowIndex].Cells["Luongchiso"].Value.ToString();
				textBoxDonvichiso.Text = (string)dataGridChitiet.Rows[e.RowIndex].Cells["Donvi"].Value;
				tenchisocu = textBoxTenchiso.Text;
			}
		}

		private void buttonThem_Click(object sender, EventArgs e)
		{
			if (textBoxTenchiso.Text.Length > 0 && textBoxDonvichiso.Text.Length > 0 && textBoxKhoiluong.Text.Length > 0)
			{
				string truyvan = string.Format("INSERT INTO Chisodinhduong (Tenchiso, Luongchiso, Donvi, Id) VALUES (N'{0}', N'{1}',N'{2}',{3});"
					, textBoxTenchiso.Text, textBoxKhoiluong.Text, textBoxDonvichiso.Text, id);
				conn.Thucthi(truyvan);
				clicknguyenlieu(sender);
			}
			else
			{
				MessageBox.Show("Giá trị không được để trống", "Lỗi");
			}
		}

		private void buttonSua_Click(object sender, EventArgs e)
		{
			if (textBoxTenchiso.Text.Length > 0 && textBoxDonvichiso.Text.Length > 0 && textBoxKhoiluong.Text.Length > 0)
			{
				string truyvan = string.Format("UPDATE Chisodinhduong SET Tenchiso = N'{0}', Luongchiso = '{1}', Donvi = N'{2}' WHERE Id = {3} and Tenchiso = '{4}';"
					, textBoxTenchiso.Text, textBoxKhoiluong.Text, textBoxDonvichiso.Text, id, tenchisocu);
				conn.Thucthi(truyvan);
				clicknguyenlieu(sender);
			}
			else
			{
				MessageBox.Show("Giá trị không được để trống", "Lỗi");
			}
		}

		private void buttonXoa_Click(object sender, EventArgs e)
		{
			if (textBoxTenchiso.Text.Length > 0)
			{
				MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
				DialogResult ketqua = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận xóa", messageBoxButtons);
				if (ketqua == DialogResult.Yes)
				{
					string truyvan = string.Format("DELETE FROM Chisodinhduong WHERE id = {0} and Tenchiso = '{1}';"
					, id, textBoxTenchiso.Text);
					conn.Thucthi(truyvan);
				}
				clicknguyenlieu(sender);
			}
			else
			{
				MessageBox.Show("Giá trị không được để trống", "Lỗi");
			}
		}

		private void buttonSuaNguyenLieu_Click(object sender, EventArgs e)
		{
			if (textBoxTennguyenlieu.Text.Length > 0 && textBoxDonvi.Text.Length > 0)
			{
				string truyvan = string.Format("UPDATE Nguyenlieu SET Tennguyenlieu = N'{0}', Donvi = N'{1}' WHERE Id = {2};"
					, textBoxTennguyenlieu.Text, textBoxDonvi.Text, id);
				conn.Thucthi(truyvan);
				reload();
			}
			else
			{
				MessageBox.Show("Giá trị không được để trống", "Lỗi");
			}
		}

		private void buttonXoaNguyenLieu_Click(object sender, EventArgs e)
		{
			MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
			DialogResult ketqua = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận xóa", messageBoxButtons);
			if (ketqua == DialogResult.Yes)
			{
				string truyvan = string.Format("DELETE FROM Nguyenlieu WHERE id = {0};"
					, id);
				conn.Thucthi(truyvan);

			}
			reload();
		}

		private void buttonLammoichiso_Click(object sender, EventArgs e)
		{
			lammoichiso();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			string searchTerm = textBoxTimkiem.Text;
			if (!string.IsNullOrEmpty(searchTerm))
			{
				DataView dv = new DataView(dataTable);
				dv.RowFilter = string.Format("Tennguyenlieu LIKE '%{0}%'", searchTerm);
				dataGridNguyenLieu.DataSource = dv.ToTable();
			}
			else
			{
				dataGridNguyenLieu.DataSource = dataTable;
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
