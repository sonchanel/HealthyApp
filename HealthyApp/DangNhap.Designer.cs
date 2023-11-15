namespace HealthyApp
{
    partial class DangNhap
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
            textBoxTaiKhoan = new TextBox();
            label1 = new Label();
            buttonDangNhap = new Button();
            label2 = new Label();
            label3 = new Label();
            textBoxMatKhau = new TextBox();
            pictureBoxMK = new PictureBox();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMK).BeginInit();
            SuspendLayout();
            // 
            // textBoxTaiKhoan
            // 
            textBoxTaiKhoan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTaiKhoan.Location = new Point(96, 98);
            textBoxTaiKhoan.Name = "textBoxTaiKhoan";
            textBoxTaiKhoan.Size = new Size(243, 27);
            textBoxTaiKhoan.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(165, 22);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 1;
            label1.Text = "Đăng nhập";
            // 
            // buttonDangNhap
            // 
            buttonDangNhap.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDangNhap.Location = new Point(96, 203);
            buttonDangNhap.Name = "buttonDangNhap";
            buttonDangNhap.Size = new Size(243, 34);
            buttonDangNhap.TabIndex = 2;
            buttonDangNhap.Text = "Đăng nhập";
            buttonDangNhap.UseVisualStyleBackColor = true;
            buttonDangNhap.Click += btDangNhap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(96, 75);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 4;
            label2.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(96, 128);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 6;
            label3.Text = "Mật khẩu";
            // 
            // textBoxMatKhau
            // 
            textBoxMatKhau.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMatKhau.Location = new Point(96, 151);
            textBoxMatKhau.Name = "textBoxMatKhau";
            textBoxMatKhau.Size = new Size(243, 27);
            textBoxMatKhau.TabIndex = 1;
            // 
            // pictureBoxMK
            // 
            pictureBoxMK.Image = Properties.Resources.eyeclose;
            pictureBoxMK.Location = new Point(315, 153);
            pictureBoxMK.Name = "pictureBoxMK";
            pictureBoxMK.Size = new Size(23, 23);
            pictureBoxMK.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMK.TabIndex = 7;
            pictureBoxMK.TabStop = false;
            pictureBoxMK.Click += pictureBoxMK_Click;
            pictureBoxMK.DoubleClick += pictureBoxMK_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(70, 256);
            label4.Name = "label4";
            label4.Size = new Size(233, 20);
            label4.TabIndex = 8;
            label4.Text = "Chưa có tài khoản ? Đăng ký ngay";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(309, 254);
            button1.Name = "button1";
            button1.Size = new Size(72, 27);
            button1.TabIndex = 3;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btDangKy_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 361);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(pictureBoxMK);
            Controls.Add(label3);
            Controls.Add(textBoxMatKhau);
            Controls.Add(label2);
            Controls.Add(buttonDangNhap);
            Controls.Add(label1);
            Controls.Add(textBoxTaiKhoan);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += DangNhap_Load;
            VisibleChanged += DangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTaiKhoan;
        private Label label1;
        private Button buttonDangNhap;
        private Label label2;
        private Label label3;
        private TextBox textBoxMatKhau;
        private PictureBox pictureBoxMK;
        private Label label4;
        private Button button1;
    }
}