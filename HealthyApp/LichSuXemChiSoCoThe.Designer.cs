namespace HealthyApp
{
    partial class LichSuXemChiSoCoThe
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
            dgvLichsu = new DataGridView();
            btXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLichsu).BeginInit();
            SuspendLayout();
            // 
            // dgvLichsu
            // 
            dgvLichsu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichsu.Location = new Point(0, 31);
            dgvLichsu.Name = "dgvLichsu";
            dgvLichsu.RowTemplate.Height = 25;
            dgvLichsu.Size = new Size(442, 213);
            dgvLichsu.TabIndex = 0;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(367, 2);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(75, 23);
            btXoa.TabIndex = 1;
            btXoa.Text = "Xóa lịch sử";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // LichSuXemChiSoCoThe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 244);
            Controls.Add(btXoa);
            Controls.Add(dgvLichsu);
            Name = "LichSuXemChiSoCoThe";
            Load += LichSuXemChiSoCoThe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLichsu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLichsu;
        private Button btXoa;
    }
}