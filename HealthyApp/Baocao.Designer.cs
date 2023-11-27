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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lbKhoa = new Label();
            pbKhoa = new PictureBox();
            chartKhoa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dateKhoa = new DateTimePicker();
            dgvKhoa = new DataGridView();
            btKhoa = new Button();
            ((System.ComponentModel.ISupportInitialize)pbKhoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartKhoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            SuspendLayout();
            // 
            // lbKhoa
            // 
            lbKhoa.AutoSize = true;
            lbKhoa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbKhoa.Location = new Point(129, 84);
            lbKhoa.Name = "lbKhoa";
            lbKhoa.Size = new Size(348, 20);
            lbKhoa.TabIndex = 0;
            lbKhoa.Text = "Cần mua bản Preminium để sử dụng chức năng này";
            // 
            // pbKhoa
            // 
            pbKhoa.Image = Properties.Resources._lock;
            pbKhoa.Location = new Point(276, 119);
            pbKhoa.Name = "pbKhoa";
            pbKhoa.Size = new Size(43, 39);
            pbKhoa.SizeMode = PictureBoxSizeMode.StretchImage;
            pbKhoa.TabIndex = 1;
            pbKhoa.TabStop = false;
            pbKhoa.Click += pictureBox1_Click;
            // 
            // chartKhoa
            // 
            chartArea2.Name = "ChartArea1";
            chartKhoa.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartKhoa.Legends.Add(legend2);
            chartKhoa.Location = new Point(312, 52);
            chartKhoa.Name = "chartKhoa";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartKhoa.Series.Add(series2);
            chartKhoa.Size = new Size(287, 248);
            chartKhoa.TabIndex = 2;
            chartKhoa.Visible = false;
            // 
            // dateKhoa
            // 
            dateKhoa.Location = new Point(354, 12);
            dateKhoa.Name = "dateKhoa";
            dateKhoa.Size = new Size(210, 23);
            dateKhoa.TabIndex = 3;
            dateKhoa.Visible = false;
            // 
            // dgvKhoa
            // 
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.Location = new Point(3, 52);
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.RowTemplate.Height = 25;
            dgvKhoa.Size = new Size(267, 167);
            dgvKhoa.TabIndex = 4;
            dgvKhoa.Visible = false;
            // 
            // btKhoa
            // 
            btKhoa.Location = new Point(26, 238);
            btKhoa.Name = "btKhoa";
            btKhoa.Size = new Size(220, 28);
            btKhoa.TabIndex = 5;
            btKhoa.Text = "Lịch sử tính chỉ số cơ thể";
            btKhoa.UseVisualStyleBackColor = true;
            btKhoa.Visible = false;
            btKhoa.Click += btKhoa_Click;
            // 
            // Baocao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 303);
            Controls.Add(btKhoa);
            Controls.Add(dgvKhoa);
            Controls.Add(dateKhoa);
            Controls.Add(chartKhoa);
            Controls.Add(pbKhoa);
            Controls.Add(lbKhoa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Baocao";
            Text = "Báo cáo";
            ((System.ComponentModel.ISupportInitialize)pbKhoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartKhoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbKhoa;
        private PictureBox pbKhoa;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKhoa;
        private DateTimePicker dateKhoa;
        private DataGridView dgvKhoa;
        private Button btKhoa;
    }
}