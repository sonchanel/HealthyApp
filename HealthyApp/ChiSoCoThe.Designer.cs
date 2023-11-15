namespace HealthyApp
{
    partial class ChiSoCoThe
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
            lbChieucao = new Label();
            lbCannang = new Label();
            txtChieucao = new TextBox();
            txtCannang = new TextBox();
            txtChisoBMI = new TextBox();
            lbChisoBMI = new Label();
            btTinhtoan = new Button();
            lbm = new Label();
            lbkg = new Label();
            lbchi = new Label();
            lbDanhgia = new Label();
            dateNgaysinh = new DateTimePicker();
            lbNgaysinh = new Label();
            lbGioitinh = new Label();
            rbtNam = new RadioButton();
            rbtNu = new RadioButton();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            lbNhecan = new Label();
            lbBinhthuong = new Label();
            lbThuacan = new Label();
            lbBeophi = new Label();
            lbSonhecan = new Label();
            lbSobinhthuong = new Label();
            lbSothuacan = new Label();
            lbSobeophi = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbChieucao
            // 
            lbChieucao.AutoSize = true;
            lbChieucao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbChieucao.Location = new Point(12, 99);
            lbChieucao.Name = "lbChieucao";
            lbChieucao.Size = new Size(74, 20);
            lbChieucao.TabIndex = 0;
            lbChieucao.Text = "Chiều cao";
            // 
            // lbCannang
            // 
            lbCannang.AutoSize = true;
            lbCannang.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbCannang.Location = new Point(12, 128);
            lbCannang.Name = "lbCannang";
            lbCannang.Size = new Size(71, 20);
            lbCannang.TabIndex = 1;
            lbCannang.Text = "Cân nặng";
            // 
            // txtChieucao
            // 
            txtChieucao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtChieucao.Location = new Point(91, 96);
            txtChieucao.Name = "txtChieucao";
            txtChieucao.PlaceholderText = "0.0";
            txtChieucao.Size = new Size(246, 27);
            txtChieucao.TabIndex = 0;
            txtChieucao.TextAlign = HorizontalAlignment.Right;
            txtChieucao.KeyPress += txtChieucao_KeyPress;
            // 
            // txtCannang
            // 
            txtCannang.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCannang.Location = new Point(92, 125);
            txtCannang.Name = "txtCannang";
            txtCannang.PlaceholderText = "0.0";
            txtCannang.Size = new Size(245, 27);
            txtCannang.TabIndex = 1;
            txtCannang.TextAlign = HorizontalAlignment.Right;
            txtCannang.KeyPress += txtCannang_KeyPress;
            // 
            // txtChisoBMI
            // 
            txtChisoBMI.Enabled = false;
            txtChisoBMI.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtChisoBMI.Location = new Point(97, 281);
            txtChisoBMI.Name = "txtChisoBMI";
            txtChisoBMI.PlaceholderText = "0.0";
            txtChisoBMI.Size = new Size(113, 27);
            txtChisoBMI.TabIndex = 3;
            // 
            // lbChisoBMI
            // 
            lbChisoBMI.AutoSize = true;
            lbChisoBMI.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbChisoBMI.Location = new Point(12, 284);
            lbChisoBMI.Name = "lbChisoBMI";
            lbChisoBMI.Size = new Size(79, 20);
            lbChisoBMI.TabIndex = 5;
            lbChisoBMI.Text = "Chỉ số BMI";
            // 
            // btTinhtoan
            // 
            btTinhtoan.Cursor = Cursors.AppStarting;
            btTinhtoan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btTinhtoan.Location = new Point(92, 235);
            btTinhtoan.Name = "btTinhtoan";
            btTinhtoan.Size = new Size(246, 29);
            btTinhtoan.TabIndex = 2;
            btTinhtoan.Text = "Tính toán";
            btTinhtoan.UseVisualStyleBackColor = true;
            btTinhtoan.Click += btTinhtoan_Click;
            // 
            // lbm
            // 
            lbm.AutoSize = true;
            lbm.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbm.Location = new Point(343, 99);
            lbm.Name = "lbm";
            lbm.Size = new Size(29, 20);
            lbm.TabIndex = 7;
            lbm.Text = "cm";
            // 
            // lbkg
            // 
            lbkg.AutoSize = true;
            lbkg.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbkg.Location = new Point(343, 128);
            lbkg.Name = "lbkg";
            lbkg.Size = new Size(25, 20);
            lbkg.TabIndex = 8;
            lbkg.Text = "kg";
            // 
            // lbchi
            // 
            lbchi.AutoSize = true;
            lbchi.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbchi.Location = new Point(38, 321);
            lbchi.Name = "lbchi";
            lbchi.Size = new Size(25, 20);
            lbchi.TabIndex = 10;
            lbchi.Text = "->";
            // 
            // lbDanhgia
            // 
            lbDanhgia.AutoSize = true;
            lbDanhgia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbDanhgia.Location = new Point(65, 321);
            lbDanhgia.Name = "lbDanhgia";
            lbDanhgia.Size = new Size(114, 20);
            lbDanhgia.TabIndex = 11;
            lbDanhgia.Text = "...đang đánh giá";
            // 
            // dateNgaysinh
            // 
            dateNgaysinh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateNgaysinh.Format = DateTimePickerFormat.Short;
            dateNgaysinh.Location = new Point(92, 193);
            dateNgaysinh.Name = "dateNgaysinh";
            dateNgaysinh.Size = new Size(245, 27);
            dateNgaysinh.TabIndex = 15;
            dateNgaysinh.Value = new DateTime(2023, 10, 27, 22, 0, 30, 0);
            dateNgaysinh.ValueChanged += dateNgaysinh_ValueChanged;
            // 
            // lbNgaysinh
            // 
            lbNgaysinh.AutoSize = true;
            lbNgaysinh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbNgaysinh.Location = new Point(12, 196);
            lbNgaysinh.Name = "lbNgaysinh";
            lbNgaysinh.Size = new Size(74, 20);
            lbNgaysinh.TabIndex = 17;
            lbNgaysinh.Text = "Ngày sinh";
            // 
            // lbGioitinh
            // 
            lbGioitinh.AutoSize = true;
            lbGioitinh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbGioitinh.Location = new Point(12, 167);
            lbGioitinh.Name = "lbGioitinh";
            lbGioitinh.Size = new Size(65, 20);
            lbGioitinh.TabIndex = 18;
            lbGioitinh.Text = "Giới tính";
            // 
            // rbtNam
            // 
            rbtNam.AutoSize = true;
            rbtNam.Checked = true;
            rbtNam.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtNam.Location = new Point(92, 165);
            rbtNam.Name = "rbtNam";
            rbtNam.Size = new Size(59, 24);
            rbtNam.TabIndex = 4;
            rbtNam.TabStop = true;
            rbtNam.Text = "Nam";
            rbtNam.UseVisualStyleBackColor = true;
            rbtNam.Click += rbtNam_Click;
            // 
            // rbtNu
            // 
            rbtNu.AutoSize = true;
            rbtNu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtNu.Location = new Point(149, 165);
            rbtNu.Name = "rbtNu";
            rbtNu.Size = new Size(47, 24);
            rbtNu.TabIndex = 5;
            rbtNu.Text = "Nữ";
            rbtNu.UseVisualStyleBackColor = true;
            rbtNu.Click += rbtNu_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(235, 313);
            panel1.Name = "panel1";
            panel1.Size = new Size(7, 7);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(235, 337);
            panel2.Name = "panel2";
            panel2.Size = new Size(7, 7);
            panel2.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkOrange;
            panel3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(236, 363);
            panel3.Name = "panel3";
            panel3.Size = new Size(7, 7);
            panel3.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.MenuHighlight;
            panel4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(235, 289);
            panel4.Name = "panel4";
            panel4.Size = new Size(7, 7);
            panel4.TabIndex = 21;
            // 
            // lbNhecan
            // 
            lbNhecan.AutoSize = true;
            lbNhecan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbNhecan.Location = new Point(248, 284);
            lbNhecan.Name = "lbNhecan";
            lbNhecan.Size = new Size(63, 20);
            lbNhecan.TabIndex = 22;
            lbNhecan.Text = "Nhẹ cân";
            // 
            // lbBinhthuong
            // 
            lbBinhthuong.AutoSize = true;
            lbBinhthuong.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbBinhthuong.Location = new Point(248, 308);
            lbBinhthuong.Name = "lbBinhthuong";
            lbBinhthuong.Size = new Size(90, 20);
            lbBinhthuong.TabIndex = 23;
            lbBinhthuong.Text = "Bình thường";
            // 
            // lbThuacan
            // 
            lbThuacan.AutoSize = true;
            lbThuacan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbThuacan.Location = new Point(248, 333);
            lbThuacan.Name = "lbThuacan";
            lbThuacan.Size = new Size(69, 20);
            lbThuacan.TabIndex = 24;
            lbThuacan.Text = "Thừa cân";
            // 
            // lbBeophi
            // 
            lbBeophi.AutoSize = true;
            lbBeophi.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbBeophi.Location = new Point(248, 359);
            lbBeophi.Name = "lbBeophi";
            lbBeophi.Size = new Size(60, 20);
            lbBeophi.TabIndex = 25;
            lbBeophi.Text = "Béo phì";
            // 
            // lbSonhecan
            // 
            lbSonhecan.AutoSize = true;
            lbSonhecan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbSonhecan.Location = new Point(363, 284);
            lbSonhecan.Name = "lbSonhecan";
            lbSonhecan.Size = new Size(0, 20);
            lbSonhecan.TabIndex = 26;
            // 
            // lbSobinhthuong
            // 
            lbSobinhthuong.AutoSize = true;
            lbSobinhthuong.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbSobinhthuong.Location = new Point(363, 308);
            lbSobinhthuong.Name = "lbSobinhthuong";
            lbSobinhthuong.Size = new Size(0, 20);
            lbSobinhthuong.TabIndex = 27;
            // 
            // lbSothuacan
            // 
            lbSothuacan.AutoSize = true;
            lbSothuacan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbSothuacan.Location = new Point(363, 333);
            lbSothuacan.Name = "lbSothuacan";
            lbSothuacan.Size = new Size(0, 20);
            lbSothuacan.TabIndex = 28;
            // 
            // lbSobeophi
            // 
            lbSobeophi.AutoSize = true;
            lbSobeophi.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbSobeophi.Location = new Point(363, 359);
            lbSobeophi.Name = "lbSobeophi";
            lbSobeophi.Size = new Size(0, 20);
            lbSobeophi.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(149, 39);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 30;
            label1.Text = "Chỉ số cơ thể (BMI)";
            // 
            // ChiSoCoThe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 450);
            Controls.Add(label1);
            Controls.Add(lbSobeophi);
            Controls.Add(lbSothuacan);
            Controls.Add(lbSobinhthuong);
            Controls.Add(lbSonhecan);
            Controls.Add(lbBeophi);
            Controls.Add(lbThuacan);
            Controls.Add(lbBinhthuong);
            Controls.Add(lbNhecan);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(rbtNu);
            Controls.Add(rbtNam);
            Controls.Add(lbGioitinh);
            Controls.Add(lbNgaysinh);
            Controls.Add(dateNgaysinh);
            Controls.Add(lbDanhgia);
            Controls.Add(lbchi);
            Controls.Add(lbkg);
            Controls.Add(lbm);
            Controls.Add(btTinhtoan);
            Controls.Add(lbChisoBMI);
            Controls.Add(txtChisoBMI);
            Controls.Add(txtCannang);
            Controls.Add(txtChieucao);
            Controls.Add(lbCannang);
            Controls.Add(lbChieucao);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChiSoCoThe";
            Text = "ChiSoCoThe";
            Load += ChiSoCoThe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbChieucao;
        private Label lbCannang;
        private TextBox txtChieucao;
        private TextBox txtCannang;
        private TextBox txtChisoBMI;
        private Label lbChisoBMI;
        private Button btTinhtoan;
        private Label lbm;
        private Label lbkg;
        private Label lbchi;
        private Label lbDanhgia;
        private DateTimePicker dateNgaysinh;
        private Label lbNgaysinh;
        private Label lbGioitinh;
        private RadioButton rbtNam;
        private RadioButton rbtNu;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lbNhecan;
        private Label lbBinhthuong;
        private Label lbThuacan;
        private Label lbBeophi;
        private Label lbSonhecan;
        private Label lbSobinhthuong;
        private Label lbSothuacan;
        private Label lbSobeophi;
        private Label label1;
    }
}