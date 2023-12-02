namespace HealthyApp
{
	partial class TrangChu
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			buttonSang = new Button();
			dataGridSang = new DataGridView();
			dataGridTrua = new DataGridView();
			buttonTrua = new Button();
			dataGridToi = new DataGridView();
			buttonToi = new Button();
			dateTimeTrangChu = new DateTimePicker();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridSang).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridTrua).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridToi).BeginInit();
			SuspendLayout();
			// 
			// buttonSang
			// 
			buttonSang.Location = new Point(408, 27);
			buttonSang.Name = "buttonSang";
			buttonSang.Size = new Size(75, 23);
			buttonSang.TabIndex = 1;
			buttonSang.Text = "Bữa Sáng";
			buttonSang.UseVisualStyleBackColor = true;
			buttonSang.Click += buttonSang_Click;
			// 
			// dataGridSang
			// 
			dataGridSang.AllowUserToAddRows = false;
			dataGridSang.AllowUserToDeleteRows = false;
			dataGridSang.BackgroundColor = SystemColors.Control;
			dataGridSang.BorderStyle = BorderStyle.None;
			dataGridSang.EditMode = DataGridViewEditMode.EditOnF2;
			dataGridSang.Location = new Point(12, 56);
			dataGridSang.Name = "dataGridSang";
			dataGridSang.ReadOnly = true;
			dataGridSang.RowHeadersVisible = false;
			dataGridSang.RowTemplate.Height = 25;
			dataGridSang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridSang.Size = new Size(471, 94);
			dataGridSang.TabIndex = 4;
			dataGridSang.CellClick += dataGridSang_CellClick;
			dataGridSang.CellContentClick += dataGridSang_CellContentClick;
			// 
			// dataGridTrua
			// 
			dataGridTrua.AllowUserToAddRows = false;
			dataGridTrua.AllowUserToDeleteRows = false;
			dataGridTrua.BackgroundColor = SystemColors.Control;
			dataGridTrua.BorderStyle = BorderStyle.None;
			dataGridTrua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridTrua.Location = new Point(12, 185);
			dataGridTrua.Name = "dataGridTrua";
			dataGridTrua.ReadOnly = true;
			dataGridTrua.RowHeadersVisible = false;
			dataGridTrua.RowTemplate.Height = 25;
			dataGridTrua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridTrua.Size = new Size(471, 94);
			dataGridTrua.TabIndex = 5;
			dataGridTrua.CellClick += dataGridTrua_CellClick;
			// 
			// buttonTrua
			// 
			buttonTrua.Location = new Point(408, 156);
			buttonTrua.Name = "buttonTrua";
			buttonTrua.Size = new Size(75, 23);
			buttonTrua.TabIndex = 2;
			buttonTrua.Text = "Bữa Trưa";
			buttonTrua.UseVisualStyleBackColor = true;
			buttonTrua.Click += buttonTrua_Click;
			// 
			// dataGridToi
			// 
			dataGridToi.AllowUserToAddRows = false;
			dataGridToi.AllowUserToDeleteRows = false;
			dataGridToi.BackgroundColor = SystemColors.Control;
			dataGridToi.BorderStyle = BorderStyle.None;
			dataGridToi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridToi.Location = new Point(12, 314);
			dataGridToi.Name = "dataGridToi";
			dataGridToi.ReadOnly = true;
			dataGridToi.RowHeadersVisible = false;
			dataGridToi.RowTemplate.Height = 25;
			dataGridToi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridToi.Size = new Size(471, 94);
			dataGridToi.TabIndex = 6;
			dataGridToi.CellClick += dataGridToi_CellClick;
			// 
			// buttonToi
			// 
			buttonToi.Location = new Point(408, 285);
			buttonToi.Name = "buttonToi";
			buttonToi.Size = new Size(75, 23);
			buttonToi.TabIndex = 3;
			buttonToi.Text = "Bữa Tối";
			buttonToi.UseVisualStyleBackColor = true;
			buttonToi.Click += buttonToi_Click;
			// 
			// dateTimeTrangChu
			// 
			dateTimeTrangChu.CustomFormat = "";
			dateTimeTrangChu.Format = DateTimePickerFormat.Short;
			dateTimeTrangChu.Location = new Point(12, 12);
			dateTimeTrangChu.Name = "dateTimeTrangChu";
			dateTimeTrangChu.Size = new Size(89, 23);
			dateTimeTrangChu.TabIndex = 0;
			dateTimeTrangChu.ValueChanged += dateTimeTrangChu_ValueChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(189, 10);
			label1.Name = "label1";
			label1.Size = new Size(97, 25);
			label1.TabIndex = 8;
			label1.Text = "Thực đơn";
			// 
			// TrangChu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(500, 450);
			Controls.Add(label1);
			Controls.Add(dateTimeTrangChu);
			Controls.Add(dataGridToi);
			Controls.Add(buttonToi);
			Controls.Add(dataGridTrua);
			Controls.Add(buttonTrua);
			Controls.Add(dataGridSang);
			Controls.Add(buttonSang);
			ForeColor = SystemColors.ControlText;
			FormBorderStyle = FormBorderStyle.None;
			Name = "TrangChu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Trang chủ";
			Load += TrangChu_Load;
			((System.ComponentModel.ISupportInitialize)dataGridSang).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridTrua).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridToi).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button buttonSang;
		private DataGridView dataGridSang;
		private DataGridView dataGridTrua;
		private Button buttonTrua;
		private DataGridView dataGridToi;
		private Button buttonToi;
		private DateTimePicker dateTimeTrangChu;
		private Label label1;
	}
}