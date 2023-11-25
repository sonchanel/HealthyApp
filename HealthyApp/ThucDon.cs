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
		string Tk;
		public ThucDon(String thoigian, DateTime datetime, string taikhoan)
		{
			Tk = taikhoan;
			time = thoigian;
			dateTime = datetime;
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		DataTable dataTableTK;
		void reload()
		{
			dateTimeTrangChu.Value = dateTime;
			dataGridThucdon.DataSource = conn.LayDuLieu(string.Format("select Type,Id,Tennguyenlieu,Soluong,case when Ghichu is null then '' else Ghichu end as Ghichu from thucdon where Buaan = '{0}' and Thoigian = '{1}' and Taikhoan = '{2}'"
								, time, dateTimeTrangChu.Value, Tk));
			dataGridThucdon.Columns["Id"].Visible = false;
			dataGridThucdon.Columns["Type"].Visible = false;
			String title = "";
			if (time == "Sang")
				title = "Bữa sáng";
			else if (time == "Trua")
				title = "Bữa Trưa";
			else if (time == "Toi")
				title = "Bữa Tối";
			labelThoiGian.Text = title;

			conn.renameDTV(dataGridThucdon);

			DataTable nguyenlieu = conn.LayDuLieu(string.Format("select Tennguyenlieu,Donvi from Nguyenlieu where Tennguyenlieu not in (SELECT Tennguyenlieu FROM Thucdon where Buaan = '{0}' and Thoigian = '{1}' and Taikhoan = '{2}')"
															, time, dateTimeTrangChu.Value, Tk));
			DataTable congthuc = conn.LayDuLieu(string.Format("select Tencongthuc as Tennguyenlieu,Donvi from Congthuc where Taikhoan = '{0}'"
															, Tk));
			congthuc.Columns.Add("Type", typeof(string));
			congthuc.Columns["Type"].DefaultValue = "0";
			for (int i = 0; i < congthuc.Rows.Count; i++)
			{
				congthuc.Rows[i]["Type"] = "1";
			}
			congthuc.Merge(nguyenlieu);
			dataTableTK = congthuc;
			dataGridNguyenLieu.DataSource = congthuc;
			dataGridNguyenLieu.Columns["Tennguyenlieu"].HeaderCell.Value = "Món ăn";
			dataGridNguyenLieu.Columns["Donvi"].HeaderCell.Value = "Đơn vị";
			dataGridNguyenLieu.Columns["Type"].Visible = false;
			dataGridNguyenLieu.Columns["Tennguyenlieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridNguyenLieu.Columns["Donvi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			//dataGridNguyenLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
		void dgvclick()
		{
			dataGridChitiet.BorderStyle = BorderStyle.None;
			dataGridNguyenLieu.BorderStyle = BorderStyle.None;
			dataGridThucdon.BorderStyle = BorderStyle.None;
		}
		private void ThucDon_Load(object sender, EventArgs e)
		{
			buttonLammoi_Click(sender, e);
		}
		String title = "";
		String type = "0";
		private void dataGridNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dgvclick();
			dataGridNguyenLieu.BorderStyle = BorderStyle.FixedSingle;
			buttonreload();
			buttonThem.Enabled = true;
			numericSoluong.Enabled = true;
			title = (string)dataGridNguyenLieu.Rows[e.RowIndex].Cells["Tennguyenlieu"].Value;
			if ((string)dataGridNguyenLieu.Rows[e.RowIndex].Cells["Type"].Value == "1")
			{
				type = "1";
			}
			else
			{
				type = "0";
			}
			chitietload(title, type);
		}
		int Index;
		private void dataGridThucdon_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dgvclick();
			dataGridThucdon.BorderStyle = BorderStyle.FixedSingle;
			if (e.RowIndex >= 0)
			{
				buttonreload();
				buttonXoa.Enabled = true;
				buttonSua.Enabled = true;
				numericSoluong.Enabled = true;
				Index = Convert.ToInt32(dataGridThucdon.Rows[e.RowIndex].Cells["Id"].Value);
				String nguyenlieu = (string)dataGridThucdon.Rows[e.RowIndex].Cells["Tennguyenlieu"].Value;
				numericSoluong.Value = Convert.ToDecimal(dataGridThucdon.Rows[e.RowIndex].Cells["Soluong"].Value);
				TextBoxGhichu.Text = (string)dataGridThucdon.Rows[e.RowIndex].Cells["Ghichu"].Value;
				if ((string)dataGridThucdon.Rows[e.RowIndex].Cells["Type"].Value == "1")
				{
					type = "1";
				}
				else
				{
					type = "0";
				}
				chitietload(nguyenlieu, type);
			}
		}

		void chitietload(String nguyenlieu, string type)
		{
			dataGridChitiet.Columns.Clear();
			if (type == "0")
			{
				dataGridChitiet.DataSource = conn.LayDuLieu(string.Format("select Tenchiso,Luongchiso,Chisodinhduong.Donvi from Chisodinhduong,Nguyenlieu where Nguyenlieu.Id=Chisodinhduong.Id and Tennguyenlieu like N'{0}' ORDER BY Tenchiso"
					, nguyenlieu));
			}
			else
			{
				dataGridChitiet.DataSource = conn.LayDuLieu(string.Format("select Tenchiso,Sum(Luongchiso*Soluong) as Luongchiso,Chisodinhduong.Donvi from Chisodinhduong,Chitietcongthuc,Congthuc where Congthuc.Id_congthuc = Chitietcongthuc.Id_congthuc and Chitietcongthuc.Id_nguyenlieu=Chisodinhduong.Id and Tencongthuc like N'{0}' and Taikhoan = '{1}' group by Tenchiso,Chisodinhduong.Donvi ORDER BY Tenchiso"
					, nguyenlieu, Tk));
			}
			dataGridChitiet.Columns["Tenchiso"].HeaderCell.Value = "Chỉ số";
			dataGridChitiet.Columns["Luongchiso"].HeaderCell.Value = "Khối lượng";
			dataGridChitiet.Columns["Donvi"].HeaderCell.Value = "Đơn vị";

			dataGridChitiet.Columns.Add("Tong", "Tổng");
			dataGridChitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			tinhtong();
			dataGridChitiet.Columns["Tong"].DefaultCellStyle.Format = "N1";
			dataGridChitiet.Columns["Luongchiso"].DefaultCellStyle.Format = "N1";
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

		private void buttonLammoi_Click(object sender, EventArgs e)
		{
			lammoi();
		}

		private void buttonXoa_Click(object sender, EventArgs e)
		{
			MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
			DialogResult ketqua = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận xóa", messageBoxButtons);
			if (ketqua == DialogResult.Yes)
			{
				String truyvan = string.Format("DELETE FROM Thucdon WHERE Id = '{0}'"
					, Index);
				conn.Thucthi(truyvan);
			}
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
				String truyvan = string.Format("INSERT INTO Thucdon(Thoigian, Buaan, Ghichu, Tennguyenlieu, Soluong, Type, Taikhoan)VALUES ('{0}', '{1}', '{2}', N'{3}', {4}, {5}, '{6}');"
					, thoigian, buaan, ghichu, tennguyenlieu, soluong, type, Tk);
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
			String truyvan = string.Format("select Sum(Tong) as Tong from (select Sum(Luongchiso*Thucdon.Soluong) as Tong from Thucdon,Nguyenlieu,Chisodinhduong where Thucdon.Thoigian = '{0}' and Buaan = '{1}' and Taikhoan = '{2}' and Nguyenlieu.Tennguyenlieu = Thucdon.Tennguyenlieu and Nguyenlieu.Id = Chisodinhduong.Id and Tenchiso = 'Calo' group by Luongchiso,Thucdon.Soluong) as BangCalo"
				, dateTimeTrangChu.Value, time, Tk);
			DataTable dataTable = conn.LayDuLieu(truyvan);
			truyvan = string.Format("select Sum(Thucdon.Soluong*Luongchiso*Chitietcongthuc.Soluong) as Tong from Thucdon,Congthuc,Chitietcongthuc,Nguyenlieu,Chisodinhduong where Thucdon.Thoigian = '{0}' and Buaan = '{1}' and Thucdon.Taikhoan = '{2}' and Congthuc.Tencongthuc = Thucdon.Tennguyenlieu and Congthuc.Id_congthuc = Chitietcongthuc.Id_congthuc and Chitietcongthuc.Id_nguyenlieu = Nguyenlieu.Id and Nguyenlieu.Id= Chisodinhduong.Id and Tenchiso = 'Calo'"
				, dateTimeTrangChu.Value, time, Tk);
			DataTable dataTable1 = conn.LayDuLieu(truyvan);
			dataTable.Merge(dataTable1);
			int tong = 0;
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				if (dataTable.Rows[i]["Tong"] != DBNull.Value)
				{
					tong += Convert.ToInt32(dataTable.Rows[i]["Tong"]);
				}
			}
			textBoxTongCalo.Text = Convert.ToString(tong);
			if (textBoxTongCalo.Text != "")
			{
				textBoxTongCalo.Text += " kcal";
			}
		}

		private void dataGridNguyenLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridThucdon_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void dataGridChitiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void dataGridChitiet_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dgvclick();
			dataGridChitiet.BorderStyle = BorderStyle.FixedSingle;
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			if (this.MdiParent != null && this.MdiParent is HeThong)
			{
				HeThong heThong = (HeThong)this.MdiParent;
				heThong.trangchuclick();
			}
		}

		private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
		{
			string searchTerm = textBoxTimKiem.Text;
			if (!string.IsNullOrEmpty(searchTerm))
			{
				DataView dv = new DataView(dataTableTK);
				dv.RowFilter = string.Format("Tennguyenlieu LIKE '%{0}%'", searchTerm);
				dataGridNguyenLieu.DataSource = dv.ToTable();
			}
			else
			{
				dataGridNguyenLieu.DataSource = dataTableTK;
			}
		}
	}






}

