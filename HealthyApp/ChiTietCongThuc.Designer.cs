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
            labelTaomoi = new Label();
            textBoxTaomoi = new TextBox();
            buttonTaomoi = new Button();
            panelChitiet = new Panel();
            buttonCapnhap = new Button();
            buttonLammoi = new Button();
            buttonXoa = new Button();
            buttonSua = new Button();
            TextBoxGhichu = new RichTextBox();
            label2 = new Label();
            buttonThem = new Button();
            numericSoluong = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            dataGridTong = new DataGridView();
            dataGridNguyenlieuCT = new DataGridView();
            label3 = new Label();
            labelChitiet = new Label();
            dataGridChitiet = new DataGridView();
            dataGridNguyenLieu = new DataGridView();
            panelChitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSoluong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridNguyenlieuCT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridChitiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridNguyenLieu).BeginInit();
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
            // labelTaomoi
            // 
            labelTaomoi.AutoSize = true;
            labelTaomoi.Location = new Point(222, 17);
            labelTaomoi.Name = "labelTaomoi";
            labelTaomoi.Size = new Size(69, 15);
            labelTaomoi.TabIndex = 27;
            labelTaomoi.Text = "Tên món ăn";
            // 
            // textBoxTaomoi
            // 
            textBoxTaomoi.Location = new Point(297, 14);
            textBoxTaomoi.Name = "textBoxTaomoi";
            textBoxTaomoi.Size = new Size(174, 23);
            textBoxTaomoi.TabIndex = 0;
            textBoxTaomoi.TextChanged += textBoxTaomoi_TextChanged;
            // 
            // buttonTaomoi
            // 
            buttonTaomoi.Location = new Point(477, 14);
            buttonTaomoi.Name = "buttonTaomoi";
            buttonTaomoi.Size = new Size(75, 23);
            buttonTaomoi.TabIndex = 1;
            buttonTaomoi.Text = "Tạo";
            buttonTaomoi.UseVisualStyleBackColor = true;
            buttonTaomoi.Click += buttonTaomoi_Click;
            // 
            // panelChitiet
            // 
            panelChitiet.Controls.Add(buttonCapnhap);
            panelChitiet.Controls.Add(buttonLammoi);
            panelChitiet.Controls.Add(buttonXoa);
            panelChitiet.Controls.Add(buttonSua);
            panelChitiet.Controls.Add(TextBoxGhichu);
            panelChitiet.Controls.Add(label2);
            panelChitiet.Controls.Add(buttonThem);
            panelChitiet.Controls.Add(numericSoluong);
            panelChitiet.Controls.Add(label5);
            panelChitiet.Controls.Add(label4);
            panelChitiet.Controls.Add(label1);
            panelChitiet.Controls.Add(dataGridTong);
            panelChitiet.Controls.Add(dataGridNguyenlieuCT);
            panelChitiet.Controls.Add(label3);
            panelChitiet.Controls.Add(labelChitiet);
            panelChitiet.Controls.Add(dataGridChitiet);
            panelChitiet.Controls.Add(dataGridNguyenLieu);
            panelChitiet.Location = new Point(12, 43);
            panelChitiet.Name = "panelChitiet";
            panelChitiet.Size = new Size(802, 487);
            panelChitiet.TabIndex = 30;
            panelChitiet.Paint += panelChitiet_Paint;
            // 
            // buttonCapnhap
            // 
            buttonCapnhap.Location = new Point(679, 390);
            buttonCapnhap.Name = "buttonCapnhap";
            buttonCapnhap.Size = new Size(120, 23);
            buttonCapnhap.TabIndex = 12;
            buttonCapnhap.Text = "Sửa công thức";
            buttonCapnhap.UseVisualStyleBackColor = true;
            buttonCapnhap.Click += buttonCapnhap_Click;
            // 
            // buttonLammoi
            // 
            buttonLammoi.Location = new Point(679, 361);
            buttonLammoi.Name = "buttonLammoi";
            buttonLammoi.Size = new Size(120, 23);
            buttonLammoi.TabIndex = 11;
            buttonLammoi.Text = "Làm mới";
            buttonLammoi.UseVisualStyleBackColor = true;
            buttonLammoi.Click += buttonLammoi_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(553, 419);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(120, 23);
            buttonXoa.TabIndex = 10;
            buttonXoa.Text = "Xóa nguyên liệu";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(553, 390);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(120, 23);
            buttonSua.TabIndex = 9;
            buttonSua.Text = "Sửa nguyên liệu";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // TextBoxGhichu
            // 
            TextBoxGhichu.Location = new Point(579, 44);
            TextBoxGhichu.Name = "TextBoxGhichu";
            TextBoxGhichu.Size = new Size(207, 282);
            TextBoxGhichu.TabIndex = 6;
            TextBoxGhichu.Text = "";
            TextBoxGhichu.TextChanged += TextBoxGhichu_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(579, 25);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 43;
            label2.Text = "Ghi chú";
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(553, 361);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(120, 23);
            buttonThem.TabIndex = 8;
            buttonThem.Text = "Thêm nguyên liệu";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // numericSoluong
            // 
            numericSoluong.Location = new Point(639, 332);
            numericSoluong.Name = "numericSoluong";
            numericSoluong.Size = new Size(147, 23);
            numericSoluong.TabIndex = 7;
            numericSoluong.ValueChanged += numericSoluong_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(579, 334);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 40;
            label5.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(328, 20);
            label4.Name = "label4";
            label4.Size = new Size(169, 21);
            label4.TabIndex = 39;
            label4.Text = "Nguyên liệu đã chọn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(109, 329);
            label1.Name = "label1";
            label1.Size = new Size(303, 21);
            label1.TabIndex = 38;
            label1.Text = "Tổng chỉ số dinh dưỡng của công thức";
            // 
            // dataGridTong
            // 
            dataGridTong.AllowUserToAddRows = false;
            dataGridTong.AllowUserToDeleteRows = false;
            dataGridTong.AllowUserToResizeColumns = false;
            dataGridTong.AllowUserToResizeRows = false;
            dataGridTong.BorderStyle = BorderStyle.None;
            dataGridTong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTong.Location = new Point(2, 353);
            dataGridTong.MultiSelect = false;
            dataGridTong.Name = "dataGridTong";
            dataGridTong.ReadOnly = true;
            dataGridTong.RowHeadersVisible = false;
            dataGridTong.RowTemplate.Height = 25;
            dataGridTong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTong.Size = new Size(545, 96);
            dataGridTong.TabIndex = 5;
            // 
            // dataGridNguyenlieuCT
            // 
            dataGridNguyenlieuCT.AllowUserToAddRows = false;
            dataGridNguyenlieuCT.AllowUserToDeleteRows = false;
            dataGridNguyenlieuCT.AllowUserToResizeRows = false;
            dataGridNguyenlieuCT.BorderStyle = BorderStyle.None;
            dataGridNguyenlieuCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridNguyenlieuCT.Location = new Point(267, 44);
            dataGridNguyenlieuCT.MultiSelect = false;
            dataGridNguyenlieuCT.Name = "dataGridNguyenlieuCT";
            dataGridNguyenlieuCT.ReadOnly = true;
            dataGridNguyenlieuCT.RowHeadersVisible = false;
            dataGridNguyenlieuCT.RowTemplate.Height = 25;
            dataGridNguyenlieuCT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridNguyenlieuCT.Size = new Size(280, 159);
            dataGridNguyenlieuCT.TabIndex = 3;
            dataGridNguyenlieuCT.CellClick += dataGridNguyenlieuCT_CellClick;
            dataGridNguyenlieuCT.CellContentClick += dataGridNguyenlieuCT_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(74, 19);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 35;
            label3.Text = "Nguyên liệu";
            // 
            // labelChitiet
            // 
            labelChitiet.AutoSize = true;
            labelChitiet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelChitiet.Location = new Point(74, 206);
            labelChitiet.Name = "labelChitiet";
            labelChitiet.Size = new Size(65, 21);
            labelChitiet.TabIndex = 34;
            labelChitiet.Text = "Chi tiết";
            // 
            // dataGridChitiet
            // 
            dataGridChitiet.AllowUserToAddRows = false;
            dataGridChitiet.AllowUserToDeleteRows = false;
            dataGridChitiet.AllowUserToResizeColumns = false;
            dataGridChitiet.AllowUserToResizeRows = false;
            dataGridChitiet.BorderStyle = BorderStyle.None;
            dataGridChitiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridChitiet.Location = new Point(2, 230);
            dataGridChitiet.MultiSelect = false;
            dataGridChitiet.Name = "dataGridChitiet";
            dataGridChitiet.ReadOnly = true;
            dataGridChitiet.RowHeadersVisible = false;
            dataGridChitiet.RowTemplate.Height = 25;
            dataGridChitiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridChitiet.Size = new Size(545, 96);
            dataGridChitiet.TabIndex = 4;
            dataGridChitiet.CellContentClick += dataGridChitiet_CellContentClick_1;
            // 
            // dataGridNguyenLieu
            // 
            dataGridNguyenLieu.AllowUserToAddRows = false;
            dataGridNguyenLieu.AllowUserToDeleteRows = false;
            dataGridNguyenLieu.AllowUserToResizeColumns = false;
            dataGridNguyenLieu.AllowUserToResizeRows = false;
            dataGridNguyenLieu.BorderStyle = BorderStyle.None;
            dataGridNguyenLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridNguyenLieu.Location = new Point(7, 44);
            dataGridNguyenLieu.MultiSelect = false;
            dataGridNguyenLieu.Name = "dataGridNguyenLieu";
            dataGridNguyenLieu.ReadOnly = true;
            dataGridNguyenLieu.RowHeadersVisible = false;
            dataGridNguyenLieu.RowTemplate.Height = 25;
            dataGridNguyenLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridNguyenLieu.Size = new Size(240, 159);
            dataGridNguyenLieu.TabIndex = 2;
            dataGridNguyenLieu.CellClick += dataGridNguyenLieu_CellClick;
            // 
            // ChiTietCongThuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(826, 542);
            Controls.Add(panelChitiet);
            Controls.Add(buttonTaomoi);
            Controls.Add(textBoxTaomoi);
            Controls.Add(labelTaomoi);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChiTietCongThuc";
            Text = "ChiTietCongThuc";
            Load += ChiTietCongThuc_Load;
            panelChitiet.ResumeLayout(false);
            panelChitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericSoluong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridNguyenlieuCT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridChitiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridNguyenLieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelTaomoi;
        private TextBox textBoxTaomoi;
        private Button buttonTaomoi;
        private Panel panelChitiet;
        private NumericUpDown numericSoluong;
        private Label label5;
        private Label label4;
        private Label label1;
        private DataGridView dataGridTong;
        private DataGridView dataGridNguyenlieuCT;
        private Label label3;
        private Label labelChitiet;
        private DataGridView dataGridChitiet;
        private DataGridView dataGridNguyenLieu;
        private Button buttonThem;
        private RichTextBox TextBoxGhichu;
        private Label label2;
        private Button buttonLammoi;
        private Button buttonXoa;
        private Button buttonSua;
        private Button buttonCapnhap;
    }
}