namespace HealthyApp
{
    partial class ChiTietCongThuc
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
            labelTitle = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridChitiet = new DataGridView();
            dataGridNguyenLieu = new DataGridView();
            dataGridNguyenlieuCT = new DataGridView();
            dataGridTong = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            labelTaomoi = new Label();
            textBoxTaomoi = new TextBox();
            buttonTaomoi = new Button();
            numericSoluong = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridChitiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridNguyenLieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridNguyenlieuCT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSoluong).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(12, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(84, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Tạo mới";
            labelTitle.Click += labelTitle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(79, 67);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 22;
            label3.Text = "Nguyên liệu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(79, 253);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 21;
            label2.Text = "Chi tiết";
            // 
            // dataGridChitiet
            // 
            dataGridChitiet.AllowUserToAddRows = false;
            dataGridChitiet.AllowUserToDeleteRows = false;
            dataGridChitiet.AllowUserToResizeColumns = false;
            dataGridChitiet.AllowUserToResizeRows = false;
            dataGridChitiet.BorderStyle = BorderStyle.None;
            dataGridChitiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridChitiet.Location = new Point(7, 277);
            dataGridChitiet.MultiSelect = false;
            dataGridChitiet.Name = "dataGridChitiet";
            dataGridChitiet.ReadOnly = true;
            dataGridChitiet.RowHeadersVisible = false;
            dataGridChitiet.RowTemplate.Height = 25;
            dataGridChitiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridChitiet.Size = new Size(545, 96);
            dataGridChitiet.TabIndex = 20;
            dataGridChitiet.CellContentClick += dataGridChitiet_CellContentClick;
            // 
            // dataGridNguyenLieu
            // 
            dataGridNguyenLieu.AllowUserToAddRows = false;
            dataGridNguyenLieu.AllowUserToDeleteRows = false;
            dataGridNguyenLieu.AllowUserToResizeColumns = false;
            dataGridNguyenLieu.AllowUserToResizeRows = false;
            dataGridNguyenLieu.BorderStyle = BorderStyle.None;
            dataGridNguyenLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridNguyenLieu.ColumnHeadersVisible = false;
            dataGridNguyenLieu.Location = new Point(12, 91);
            dataGridNguyenLieu.MultiSelect = false;
            dataGridNguyenLieu.Name = "dataGridNguyenLieu";
            dataGridNguyenLieu.ReadOnly = true;
            dataGridNguyenLieu.RowHeadersVisible = false;
            dataGridNguyenLieu.RowTemplate.Height = 25;
            dataGridNguyenLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridNguyenLieu.Size = new Size(240, 159);
            dataGridNguyenLieu.TabIndex = 19;
            dataGridNguyenLieu.CellClick += dataGridNguyenLieu_CellClick;
            // 
            // dataGridNguyenlieuCT
            // 
            dataGridNguyenlieuCT.AllowUserToAddRows = false;
            dataGridNguyenlieuCT.AllowUserToDeleteRows = false;
            dataGridNguyenlieuCT.AllowUserToResizeRows = false;
            dataGridNguyenlieuCT.BorderStyle = BorderStyle.None;
            dataGridNguyenlieuCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridNguyenlieuCT.Location = new Point(272, 91);
            dataGridNguyenlieuCT.MultiSelect = false;
            dataGridNguyenlieuCT.Name = "dataGridNguyenlieuCT";
            dataGridNguyenlieuCT.ReadOnly = true;
            dataGridNguyenlieuCT.RowHeadersVisible = false;
            dataGridNguyenlieuCT.RowTemplate.Height = 25;
            dataGridNguyenlieuCT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridNguyenlieuCT.Size = new Size(280, 159);
            dataGridNguyenlieuCT.TabIndex = 23;
            // 
            // dataGridTong
            // 
            dataGridTong.AllowUserToAddRows = false;
            dataGridTong.AllowUserToDeleteRows = false;
            dataGridTong.AllowUserToResizeColumns = false;
            dataGridTong.AllowUserToResizeRows = false;
            dataGridTong.BorderStyle = BorderStyle.None;
            dataGridTong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTong.Location = new Point(7, 400);
            dataGridTong.MultiSelect = false;
            dataGridTong.Name = "dataGridTong";
            dataGridTong.ReadOnly = true;
            dataGridTong.RowHeadersVisible = false;
            dataGridTong.RowTemplate.Height = 25;
            dataGridTong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTong.Size = new Size(545, 96);
            dataGridTong.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(79, 376);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 25;
            label1.Text = "Tổng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(333, 67);
            label4.Name = "label4";
            label4.Size = new Size(169, 21);
            label4.TabIndex = 26;
            label4.Text = "Nguyên liệu đã chọn";
            label4.Click += label4_Click;
            // 
            // labelTaomoi
            // 
            labelTaomoi.AutoSize = true;
            labelTaomoi.Location = new Point(170, 17);
            labelTaomoi.Name = "labelTaomoi";
            labelTaomoi.Size = new Size(69, 15);
            labelTaomoi.TabIndex = 27;
            labelTaomoi.Text = "Tên món ăn";
            // 
            // textBoxTaomoi
            // 
            textBoxTaomoi.Location = new Point(245, 14);
            textBoxTaomoi.Name = "textBoxTaomoi";
            textBoxTaomoi.Size = new Size(174, 23);
            textBoxTaomoi.TabIndex = 28;
            // 
            // buttonTaomoi
            // 
            buttonTaomoi.Location = new Point(425, 14);
            buttonTaomoi.Name = "buttonTaomoi";
            buttonTaomoi.Size = new Size(75, 23);
            buttonTaomoi.TabIndex = 29;
            buttonTaomoi.Text = "Tạo";
            buttonTaomoi.UseVisualStyleBackColor = true;
            buttonTaomoi.Click += buttonTaomoi_Click;
            // 
            // numericSoluong
            // 
            numericSoluong.Location = new Point(645, 65);
            numericSoluong.Name = "numericSoluong";
            numericSoluong.Size = new Size(131, 23);
            numericSoluong.TabIndex = 31;
            numericSoluong.ValueChanged += numericSoluong_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(585, 67);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 30;
            label5.Text = "Số lượng";
            label5.Click += label5_Click;
            // 
            // ChiTietCongThuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 521);
            Controls.Add(numericSoluong);
            Controls.Add(label5);
            Controls.Add(buttonTaomoi);
            Controls.Add(textBoxTaomoi);
            Controls.Add(labelTaomoi);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dataGridTong);
            Controls.Add(dataGridNguyenlieuCT);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridChitiet);
            Controls.Add(dataGridNguyenLieu);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChiTietCongThuc";
            Text = "ChiTietCongThuc";
            Load += ChiTietCongThuc_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridChitiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridNguyenLieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridNguyenlieuCT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSoluong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label label3;
        private Label label2;
        private DataGridView dataGridChitiet;
        private DataGridView dataGridNguyenLieu;
        private DataGridView dataGridNguyenlieuCT;
        private DataGridView dataGridTong;
        private Label label1;
        private Label label4;
        private Label labelTaomoi;
        private TextBox textBoxTaomoi;
        private Button buttonTaomoi;
        private NumericUpDown numericSoluong;
        private Label label5;
    }
}