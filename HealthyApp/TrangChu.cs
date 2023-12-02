
using System.Data;
using System.Dynamic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HealthyApp
{
	public partial class TrangChu : Form
	{
		KetNoi conn = new KetNoi();
		string Tk;
		public TrangChu(string taikhoan)
		{
			Tk = taikhoan;
			InitializeComponent();
		}

		private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}
		String truyvan(String time)
		{
			return string.Format("select Tennguyenlieu,Soluong,case when Ghichu is null then '' else Ghichu end as Ghichu from thucdon where Buaan = '{0}' and Thoigian = '{1}' and Taikhoan = '{2}'"
								, time, dateTimeTrangChu.Value, Tk); ;
		}


		void tailai()
		{

			//labelChuaTaoThucDon.Visible = false;
			String time = "Sang";
			DataTable dt = new DataTable();
			dt = conn.LayDuLieu(truyvan(time));
			dataGridSang.DataSource = dt;
			time = "Trua";
			dt = conn.LayDuLieu(truyvan(time));
			dataGridTrua.DataSource = dt;
			time = "Toi";
			dt = conn.LayDuLieu(truyvan(time));
			dataGridToi.DataSource = dt;

			conn.renameDTV(dataGridSang);
			conn.renameDTV(dataGridTrua);
			conn.renameDTV(dataGridToi);

			buttonSang.Location = new Point(408, 27);
			buttonTrua.Location = new Point(408, 156);
			buttonToi.Location = new Point(408, 285);

			chuacothucdon(dataGridSang, buttonSang, labelSang);
			chuacothucdon(dataGridTrua, buttonTrua, labelTrua);
			chuacothucdon(dataGridToi, buttonToi, labelToi);

		}

		Label labelSang = new Label();
		Label labelTrua = new Label();
		Label labelToi = new Label();
		//Pen pen = new Pen(Color.Red, 30);
		//Pen penw = new Pen(Color.White, 30);
		//Graphics sang,trua,toi;
		void chuacothucdon(DataGridView a, Button b, Label label)
		{
			int x = 0;
			x = b.Location.X - 320;
			int y = 0;
			y = b.Location.Y + 65;
			//e = this.CreateGraphics();

			if (a.Rows.Count <= 0)
			{
				a.Visible = false;
				//labelChuaTaoThucDon.Visible = true;

				label.Text = "Chưa có thực đơn ! Tạo mới ngay";
				label.AutoSize = true;
				label.Font = new Font("", 14);
				label.Location = new Point(x, y - 40);
				label.Visible = true;
				label.ForeColor = Color.Green;
				this.Controls.Add(label);
				b.Location = new Point(x, y);
				b.Size = new Size(300, 30);
				b.Font = new Font("", 10);
				//e.DrawLine(pen, x + 10, y + 50, x + 290, y + 50);
				//Console.WriteLine(e.DpiX);
				//Console.WriteLine(e.DpiY);
			}
			else
			{
				this.Controls.Remove(label);
				b.Location = new Point(x + 320, y - 65);
				b.Size = new Size(75, 23);
				b.Font = new Font("", 9);
				//e.DrawLine(penw, x + 10, y + 50, x + 290, y + 50);
			}
		}

		private void TrangChu_Load(object sender, EventArgs e)
		{
			dateTimeTrangChu.Value = DateTime.Now;
		}

		private void dateTimeTrangChu_ValueChanged(object sender, EventArgs e)
		{
			tailai();
		}

		void buttonClick(String time)
		{
			ThucDon thucDon = new ThucDon(time, dateTimeTrangChu.Value, Tk);
			if (ActiveMdiChild != null)
			{
				ActiveMdiChild.Close();
			}
			thucDon.MdiParent = this.MdiParent;
			thucDon.Dock = DockStyle.Fill;
			this.MdiParent.ClientSize = thucDon.Size;
			thucDon.Show();
		}
		private void buttonSang_Click(object sender, EventArgs e)
		{
			buttonClick("Sang");
		}

		private void buttonTrua_Click(object sender, EventArgs e)
		{
			buttonClick("Trua");
		}

		private void buttonToi_Click(object sender, EventArgs e)
		{
			buttonClick("Toi");
		}

		void dgvclick()
		{
			dataGridSang.BorderStyle = BorderStyle.None;
			dataGridTrua.BorderStyle = BorderStyle.None;
			dataGridToi.BorderStyle = BorderStyle.None;
		}
		private void dataGridSang_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dgvclick();
			dataGridSang.BorderStyle = BorderStyle.FixedSingle;
		}

		private void dataGridTrua_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dgvclick();
			dataGridTrua.BorderStyle = BorderStyle.FixedSingle;
		}

		private void dataGridToi_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dgvclick();
			dataGridToi.BorderStyle = BorderStyle.FixedSingle;
		}

		private void dataGridSang_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}