namespace HealthyApp
{
    partial class CongThuc
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
            dataGridCongThuc = new DataGridView();
            label1 = new Label();
            buttonCongthuc = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridCongThuc).BeginInit();
            SuspendLayout();
            // 
            // dataGridCongThuc
            // 
            dataGridCongThuc.AllowUserToAddRows = false;
            dataGridCongThuc.AllowUserToDeleteRows = false;
            dataGridCongThuc.AllowUserToResizeColumns = false;
            dataGridCongThuc.AllowUserToResizeRows = false;
            dataGridCongThuc.BackgroundColor = SystemColors.Control;
            dataGridCongThuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCongThuc.Location = new Point(12, 76);
            dataGridCongThuc.Name = "dataGridCongThuc";
            dataGridCongThuc.ReadOnly = true;
            dataGridCongThuc.RowHeadersVisible = false;
            dataGridCongThuc.RowTemplate.Height = 25;
            dataGridCongThuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCongThuc.Size = new Size(434, 347);
            dataGridCongThuc.TabIndex = 11;
            dataGridCongThuc.CellClick += dataGridCongThuc_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(177, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 13;
            label1.Text = "Công thức";
            // 
            // buttonCongthuc
            // 
            buttonCongthuc.Location = new Point(371, 47);
            buttonCongthuc.Name = "buttonCongthuc";
            buttonCongthuc.Size = new Size(75, 23);
            buttonCongthuc.TabIndex = 14;
            buttonCongthuc.Text = "Tạo mới";
            buttonCongthuc.UseVisualStyleBackColor = true;
            buttonCongthuc.Click += buttonCongthuc_Click;
            // 
            // CongThuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 460);
            Controls.Add(buttonCongthuc);
            Controls.Add(label1);
            Controls.Add(dataGridCongThuc);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CongThuc";
            Text = "CongThuc";
            Load += CongThuc_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCongThuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridCongThuc;
        private Label label1;
        private Button buttonCongthuc;
    }
}