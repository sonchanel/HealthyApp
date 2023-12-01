namespace HealthyApp
{
	partial class NguyenLieu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dataGridNguyenLieu = new DataGridView();
			dataGridChitiet = new DataGridView();
			textBoxTennguyenlieu = new TextBox();
			label1 = new Label();
			buttonTaomoi = new Button();
			label2 = new Label();
			textBoxTenchiso = new TextBox();
			label3 = new Label();
			textBoxKhoiluong = new TextBox();
			label4 = new Label();
			textBoxDonvi = new TextBox();
			buttonLammoi = new Button();
			buttonThemChitiet = new Button();
			buttonSuaChitiet = new Button();
			buttonXoaChitiet = new Button();
			label5 = new Label();
			textBoxDonvichiso = new TextBox();
			label6 = new Label();
			label7 = new Label();
			textBoxTimkiem = new TextBox();
			buttonXoaNguyenLieu = new Button();
			buttonSuaNguyenLieu = new Button();
			buttonLammoichiso = new Button();
			panelChiso = new Panel();
			((System.ComponentModel.ISupportInitialize)dataGridNguyenLieu).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridChitiet).BeginInit();
			panelChiso.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridNguyenLieu
			// 
			dataGridNguyenLieu.AllowUserToAddRows = false;
			dataGridNguyenLieu.AllowUserToDeleteRows = false;
			dataGridNguyenLieu.AllowUserToResizeColumns = false;
			dataGridNguyenLieu.AllowUserToResizeRows = false;
			dataGridNguyenLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridNguyenLieu.Location = new Point(359, 77);
			dataGridNguyenLieu.MultiSelect = false;
			dataGridNguyenLieu.Name = "dataGridNguyenLieu";
			dataGridNguyenLieu.ReadOnly = true;
			dataGridNguyenLieu.RowHeadersVisible = false;
			dataGridNguyenLieu.RowTemplate.Height = 25;
			dataGridNguyenLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridNguyenLieu.Size = new Size(270, 272);
			dataGridNguyenLieu.TabIndex = 0;
			dataGridNguyenLieu.CellClick += dataGridNguyenLieu_CellClick;
			// 
			// dataGridChitiet
			// 
			dataGridChitiet.AllowUserToAddRows = false;
			dataGridChitiet.AllowUserToDeleteRows = false;
			dataGridChitiet.AllowUserToResizeColumns = false;
			dataGridChitiet.AllowUserToResizeRows = false;
			dataGridChitiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridChitiet.Location = new Point(12, 355);
			dataGridChitiet.MultiSelect = false;
			dataGridChitiet.Name = "dataGridChitiet";
			dataGridChitiet.ReadOnly = true;
			dataGridChitiet.RowHeadersVisible = false;
			dataGridChitiet.RowTemplate.Height = 25;
			dataGridChitiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridChitiet.Size = new Size(617, 150);
			dataGridChitiet.TabIndex = 1;
			dataGridChitiet.CellClick += dataGridChitiet_CellClick;
			// 
			// textBoxTennguyenlieu
			// 
			textBoxTennguyenlieu.Location = new Point(108, 77);
			textBoxTennguyenlieu.Name = "textBoxTennguyenlieu";
			textBoxTennguyenlieu.Size = new Size(164, 23);
			textBoxTennguyenlieu.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 80);
			label1.Name = "label1";
			label1.Size = new Size(90, 15);
			label1.TabIndex = 3;
			label1.Text = "Tên nguyên liệu";
			// 
			// buttonTaomoi
			// 
			buttonTaomoi.Location = new Point(12, 143);
			buttonTaomoi.Name = "buttonTaomoi";
			buttonTaomoi.Size = new Size(75, 23);
			buttonTaomoi.TabIndex = 4;
			buttonTaomoi.Text = "Tạo mới";
			buttonTaomoi.UseVisualStyleBackColor = true;
			buttonTaomoi.Click += button1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 53);
			label2.Name = "label2";
			label2.Size = new Size(59, 15);
			label2.TabIndex = 6;
			label2.Text = "Tên chỉ số";
			// 
			// textBoxTenchiso
			// 
			textBoxTenchiso.Location = new Point(99, 50);
			textBoxTenchiso.Name = "textBoxTenchiso";
			textBoxTenchiso.Size = new Size(164, 23);
			textBoxTenchiso.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(3, 82);
			label3.Name = "label3";
			label3.Size = new Size(65, 15);
			label3.TabIndex = 8;
			label3.Text = "Khối lượng";
			// 
			// textBoxKhoiluong
			// 
			textBoxKhoiluong.Location = new Point(99, 79);
			textBoxKhoiluong.Name = "textBoxKhoiluong";
			textBoxKhoiluong.Size = new Size(164, 23);
			textBoxKhoiluong.TabIndex = 7;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 109);
			label4.Name = "label4";
			label4.Size = new Size(41, 15);
			label4.TabIndex = 10;
			label4.Text = "Đơn vị";
			// 
			// textBoxDonvi
			// 
			textBoxDonvi.Location = new Point(108, 106);
			textBoxDonvi.Name = "textBoxDonvi";
			textBoxDonvi.Size = new Size(164, 23);
			textBoxDonvi.TabIndex = 9;
			// 
			// buttonLammoi
			// 
			buttonLammoi.Location = new Point(255, 143);
			buttonLammoi.Name = "buttonLammoi";
			buttonLammoi.Size = new Size(75, 23);
			buttonLammoi.TabIndex = 11;
			buttonLammoi.Text = "Làm mới";
			buttonLammoi.UseVisualStyleBackColor = true;
			buttonLammoi.Click += button2_Click;
			// 
			// buttonThemChitiet
			// 
			buttonThemChitiet.Location = new Point(3, 148);
			buttonThemChitiet.Name = "buttonThemChitiet";
			buttonThemChitiet.Size = new Size(75, 23);
			buttonThemChitiet.TabIndex = 12;
			buttonThemChitiet.Text = "Thêm";
			buttonThemChitiet.UseVisualStyleBackColor = true;
			buttonThemChitiet.Click += buttonThem_Click;
			// 
			// buttonSuaChitiet
			// 
			buttonSuaChitiet.Location = new Point(84, 148);
			buttonSuaChitiet.Name = "buttonSuaChitiet";
			buttonSuaChitiet.Size = new Size(75, 23);
			buttonSuaChitiet.TabIndex = 13;
			buttonSuaChitiet.Text = "Cập nhật";
			buttonSuaChitiet.UseVisualStyleBackColor = true;
			buttonSuaChitiet.Click += buttonSua_Click;
			// 
			// buttonXoaChitiet
			// 
			buttonXoaChitiet.Location = new Point(165, 148);
			buttonXoaChitiet.Name = "buttonXoaChitiet";
			buttonXoaChitiet.Size = new Size(75, 23);
			buttonXoaChitiet.TabIndex = 14;
			buttonXoaChitiet.Text = "Xóa";
			buttonXoaChitiet.UseVisualStyleBackColor = true;
			buttonXoaChitiet.Click += buttonXoa_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(3, 111);
			label5.Name = "label5";
			label5.Size = new Size(41, 15);
			label5.TabIndex = 16;
			label5.Text = "Đơn vị";
			// 
			// textBoxDonvichiso
			// 
			textBoxDonvichiso.Location = new Point(99, 108);
			textBoxDonvichiso.Name = "textBoxDonvichiso";
			textBoxDonvichiso.Size = new Size(164, 23);
			textBoxDonvichiso.TabIndex = 15;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label6.Location = new Point(12, 31);
			label6.Name = "label6";
			label6.Size = new Size(120, 25);
			label6.TabIndex = 17;
			label6.Text = "Nguyên liệu";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label7.Location = new Point(3, 0);
			label7.Name = "label7";
			label7.Size = new Size(176, 25);
			label7.TabIndex = 18;
			label7.Text = "Chỉ số dinh dưỡng";
			// 
			// textBoxTimkiem
			// 
			textBoxTimkiem.Location = new Point(359, 48);
			textBoxTimkiem.Name = "textBoxTimkiem";
			textBoxTimkiem.PlaceholderText = "Tìm kiếm";
			textBoxTimkiem.Size = new Size(270, 23);
			textBoxTimkiem.TabIndex = 19;
			textBoxTimkiem.TextChanged += textBox1_TextChanged;
			// 
			// buttonXoaNguyenLieu
			// 
			buttonXoaNguyenLieu.Location = new Point(174, 143);
			buttonXoaNguyenLieu.Name = "buttonXoaNguyenLieu";
			buttonXoaNguyenLieu.Size = new Size(75, 23);
			buttonXoaNguyenLieu.TabIndex = 21;
			buttonXoaNguyenLieu.Text = "Xóa";
			buttonXoaNguyenLieu.UseVisualStyleBackColor = true;
			buttonXoaNguyenLieu.Click += buttonXoaNguyenLieu_Click;
			// 
			// buttonSuaNguyenLieu
			// 
			buttonSuaNguyenLieu.Location = new Point(93, 143);
			buttonSuaNguyenLieu.Name = "buttonSuaNguyenLieu";
			buttonSuaNguyenLieu.Size = new Size(75, 23);
			buttonSuaNguyenLieu.TabIndex = 20;
			buttonSuaNguyenLieu.Text = "Cập nhật";
			buttonSuaNguyenLieu.UseVisualStyleBackColor = true;
			buttonSuaNguyenLieu.Click += buttonSuaNguyenLieu_Click;
			// 
			// buttonLammoichiso
			// 
			buttonLammoichiso.Location = new Point(246, 148);
			buttonLammoichiso.Name = "buttonLammoichiso";
			buttonLammoichiso.Size = new Size(75, 23);
			buttonLammoichiso.TabIndex = 22;
			buttonLammoichiso.Text = "Làm mới";
			buttonLammoichiso.UseVisualStyleBackColor = true;
			buttonLammoichiso.Click += buttonLammoichiso_Click;
			// 
			// panelChiso
			// 
			panelChiso.Controls.Add(label7);
			panelChiso.Controls.Add(buttonLammoichiso);
			panelChiso.Controls.Add(textBoxTenchiso);
			panelChiso.Controls.Add(label2);
			panelChiso.Controls.Add(textBoxKhoiluong);
			panelChiso.Controls.Add(label3);
			panelChiso.Controls.Add(buttonThemChitiet);
			panelChiso.Controls.Add(buttonSuaChitiet);
			panelChiso.Controls.Add(label5);
			panelChiso.Controls.Add(buttonXoaChitiet);
			panelChiso.Controls.Add(textBoxDonvichiso);
			panelChiso.Location = new Point(12, 172);
			panelChiso.Name = "panelChiso";
			panelChiso.Size = new Size(341, 177);
			panelChiso.TabIndex = 23;
			panelChiso.Paint += panel1_Paint;
			// 
			// NguyenLieu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(641, 538);
			Controls.Add(panelChiso);
			Controls.Add(buttonXoaNguyenLieu);
			Controls.Add(buttonSuaNguyenLieu);
			Controls.Add(textBoxTimkiem);
			Controls.Add(label6);
			Controls.Add(buttonLammoi);
			Controls.Add(label4);
			Controls.Add(textBoxDonvi);
			Controls.Add(buttonTaomoi);
			Controls.Add(label1);
			Controls.Add(textBoxTennguyenlieu);
			Controls.Add(dataGridChitiet);
			Controls.Add(dataGridNguyenLieu);
			FormBorderStyle = FormBorderStyle.None;
			Name = "NguyenLieu";
			Text = "Nguyên liệu";
			Load += NguyenLieu_Load;
			((System.ComponentModel.ISupportInitialize)dataGridNguyenLieu).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridChitiet).EndInit();
			panelChiso.ResumeLayout(false);
			panelChiso.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridNguyenLieu;
		private DataGridView dataGridChitiet;
		private TextBox textBoxTennguyenlieu;
		private Label label1;
		private Button buttonTaomoi;
		private Label label2;
		private TextBox textBoxTenchiso;
		private Label label3;
		private TextBox textBoxKhoiluong;
		private Label label4;
		private TextBox textBoxDonvi;
		private Button buttonLammoi;
		private Button buttonThemChitiet;
		private Button buttonSuaChitiet;
		private Button buttonXoaChitiet;
		private Label label5;
		private TextBox textBoxDonvichiso;
		private Label label6;
		private Label label7;
		private TextBox textBoxTimkiem;
		private Button buttonXoaNguyenLieu;
		private Button buttonSuaNguyenLieu;
		private Button buttonLammoichiso;
		private Panel panelChiso;
	}
}