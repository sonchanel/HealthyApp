namespace HealthyApp
{
	partial class Baocao
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			chartKhoa = new System.Windows.Forms.DataVisualization.Charting.Chart();
			dateKhoa = new DateTimePicker();
			dgvKhoa = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)chartKhoa).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
			SuspendLayout();
			// 
			// chartKhoa
			// 
			chartArea1.Name = "ChartArea1";
			chartKhoa.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			chartKhoa.Legends.Add(legend1);
			chartKhoa.Location = new Point(12, 240);
			chartKhoa.Name = "chartKhoa";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			chartKhoa.Series.Add(series1);
			chartKhoa.Size = new Size(476, 169);
			chartKhoa.TabIndex = 2;
			// 
			// dateKhoa
			// 
			dateKhoa.Location = new Point(12, 83);
			dateKhoa.Name = "dateKhoa";
			dateKhoa.Size = new Size(229, 23);
			dateKhoa.TabIndex = 3;
			dateKhoa.ValueChanged += dateKhoa_ValueChanged;
			// 
			// dgvKhoa
			// 
			dgvKhoa.AllowUserToAddRows = false;
			dgvKhoa.AllowUserToDeleteRows = false;
			dgvKhoa.AllowUserToResizeColumns = false;
			dgvKhoa.AllowUserToResizeRows = false;
			dgvKhoa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvKhoa.Location = new Point(12, 112);
			dgvKhoa.Name = "dgvKhoa";
			dgvKhoa.ReadOnly = true;
			dgvKhoa.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dgvKhoa.RowHeadersVisible = false;
			dgvKhoa.RowTemplate.Height = 25;
			dgvKhoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvKhoa.Size = new Size(476, 122);
			dgvKhoa.TabIndex = 4;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(12, 24);
			label1.Name = "label1";
			label1.Size = new Size(96, 25);
			label1.TabIndex = 5;
			label1.Text = "Thống kê";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(12, 59);
			label2.Name = "label2";
			label2.Size = new Size(113, 21);
			label2.TabIndex = 6;
			label2.Text = "Chọn thời gian";
			// 
			// Baocao
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(500, 450);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dgvKhoa);
			Controls.Add(dateKhoa);
			Controls.Add(chartKhoa);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Baocao";
			Text = "Báo cáo";
			Load += Baocao_Load;
			((System.ComponentModel.ISupportInitialize)chartKhoa).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private System.Windows.Forms.DataVisualization.Charting.Chart chartKhoa;
		private DateTimePicker dateKhoa;
		private DataGridView dgvKhoa;
		private Label label1;
		private Label label2;
	}
}