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
            chartKhoa.Location = new Point(263, 121);
            chartKhoa.Name = "chartKhoa";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartKhoa.Series.Add(series1);
            chartKhoa.Size = new Size(238, 334);
            chartKhoa.TabIndex = 2;
            // 
            // dateKhoa
            // 
            dateKhoa.Location = new Point(325, 62);
            dateKhoa.Name = "dateKhoa";
            dateKhoa.Size = new Size(110, 23);
            dateKhoa.TabIndex = 3;
            dateKhoa.ValueChanged += dateKhoa_ValueChanged;
            // 
            // dgvKhoa
            // 
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.Location = new Point(5, 12);
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.RowTemplate.Height = 25;
            dgvKhoa.Size = new Size(241, 426);
            dgvKhoa.TabIndex = 4;
            // 
            // Baocao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 450);
            Controls.Add(dgvKhoa);
            Controls.Add(dateKhoa);
            Controls.Add(chartKhoa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Baocao";
            Text = "Báo cáo";
            ((System.ComponentModel.ISupportInitialize)chartKhoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKhoa;
        private DateTimePicker dateKhoa;
        private DataGridView dgvKhoa;
    }
}