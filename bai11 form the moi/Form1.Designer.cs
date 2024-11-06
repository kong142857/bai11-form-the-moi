namespace bai11_form_the_moi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtMoTaChiTiet = new RichTextBox();
            cmbLoaiSP = new ComboBox();
            txtMoTaNgan = new TextBox();
            txtHinhAnh = new TextBox();
            txtDonGia = new TextBox();
            txtTen = new TextBox();
            txtMaSP = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            txtTimKiem = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMoTaChiTiet);
            panel1.Controls.Add(cmbLoaiSP);
            panel1.Controls.Add(txtMoTaNgan);
            panel1.Controls.Add(txtHinhAnh);
            panel1.Controls.Add(txtDonGia);
            panel1.Controls.Add(txtTen);
            panel1.Controls.Add(txtMaSP);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(18, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 348);
            panel1.TabIndex = 0;
            // 
            // txtMoTaChiTiet
            // 
            txtMoTaChiTiet.Location = new Point(106, 231);
            txtMoTaChiTiet.Name = "txtMoTaChiTiet";
            txtMoTaChiTiet.Size = new Size(184, 55);
            txtMoTaChiTiet.TabIndex = 12;
            txtMoTaChiTiet.Text = "";
            // 
            // cmbLoaiSP
            // 
            cmbLoaiSP.FormattingEnabled = true;
            cmbLoaiSP.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cmbLoaiSP.Location = new Point(106, 305);
            cmbLoaiSP.Name = "cmbLoaiSP";
            cmbLoaiSP.Size = new Size(184, 23);
            cmbLoaiSP.TabIndex = 0;
            // 
            // txtMoTaNgan
            // 
            txtMoTaNgan.Location = new Point(106, 184);
            txtMoTaNgan.Name = "txtMoTaNgan";
            txtMoTaNgan.Size = new Size(184, 23);
            txtMoTaNgan.TabIndex = 11;
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Location = new Point(106, 145);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(184, 23);
            txtHinhAnh.TabIndex = 10;
            txtHinhAnh.TextChanged += textBox4_TextChanged;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(106, 101);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(184, 23);
            txtDonGia.TabIndex = 9;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(106, 59);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(184, 23);
            txtTen.TabIndex = 8;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(106, 20);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(85, 23);
            txtMaSP.TabIndex = 7;
            txtMaSP.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 308);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 6;
            label7.Text = "Loai sp:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 234);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 5;
            label6.Text = "Mo ta chi tiet:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 187);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 4;
            label5.Text = "Mo ta ngan:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 148);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Hinh anh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 104);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Don gia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 62);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Ten sp:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Ma sp:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnThem);
            panel2.Location = new Point(12, 387);
            panel2.Name = "panel2";
            panel2.Size = new Size(313, 51);
            panel2.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(12, 13);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(76, 23);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Lam moi";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(172, 13);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(65, 23);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(243, 13);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(66, 23);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btxoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(94, 13);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(72, 23);
            btnThem.TabIndex = 1;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btthem_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(txtTimKiem);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(331, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(457, 421);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(421, 150);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button5
            // 
            button5.Location = new Point(337, 15);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 2;
            button5.Text = "Tim kiem:";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(80, 15);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(228, 23);
            txtTimKiem.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 20);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 0;
            label8.Text = "Tim kiem:";
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "quản lý sản phẩm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnXoa;
        private Button btnThem;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbLoaiSP;
        private TextBox txtMoTaNgan;
        private TextBox txtHinhAnh;
        private TextBox txtDonGia;
        private TextBox txtTen;
        private TextBox txtMaSP;
        private RichTextBox txtMoTaChiTiet;
        private Label label8;
        private Button button5;
        private TextBox txtTimKiem;
        private DataGridView dataGridView1;
        private Button btnSua;
        private Button btnLamMoi;
    }
}
