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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            buttonThem = new Button();
            buttonSua = new Button();
            buttonXoa = new Button();
            textBoxTenCongThuc = new TextBox();
            labelThanhphan = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridCongThuc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridCongThuc
            // 
            dataGridCongThuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCongThuc.Location = new Point(308, 73);
            dataGridCongThuc.Name = "dataGridCongThuc";
            dataGridCongThuc.RowTemplate.Height = 25;
            dataGridCongThuc.Size = new Size(385, 365);
            dataGridCongThuc.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 13;
            label1.Text = "Công thức";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(290, 210);
            dataGridView1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 166);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 15;
            label2.Text = "Tên công thức";
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(12, 73);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(66, 30);
            buttonThem.TabIndex = 16;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(100, 73);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(66, 30);
            buttonSua.TabIndex = 17;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(196, 73);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(66, 30);
            buttonXoa.TabIndex = 18;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // textBoxTenCongThuc
            // 
            textBoxTenCongThuc.Location = new Point(100, 163);
            textBoxTenCongThuc.Name = "textBoxTenCongThuc";
            textBoxTenCongThuc.Size = new Size(202, 23);
            textBoxTenCongThuc.TabIndex = 19;
            // 
            // labelThanhphan
            // 
            labelThanhphan.AutoSize = true;
            labelThanhphan.Location = new Point(12, 199);
            labelThanhphan.Name = "labelThanhphan";
            labelThanhphan.Size = new Size(70, 15);
            labelThanhphan.TabIndex = 21;
            labelThanhphan.Text = "Thành phần";
            // 
            // CongThuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 564);
            Controls.Add(labelThanhphan);
            Controls.Add(textBoxTenCongThuc);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(dataGridCongThuc);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CongThuc";
            Text = "CongThuc";
            ((System.ComponentModel.ISupportInitialize)dataGridCongThuc).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridCongThuc;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonXoa;
        private TextBox textBoxTenCongThuc;
        private Label labelThanhphan;
    }
}