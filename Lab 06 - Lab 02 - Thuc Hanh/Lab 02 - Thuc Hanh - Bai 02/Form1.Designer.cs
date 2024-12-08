namespace Lab_02___Thuc_Hanh___Bai_02
{
    partial class Form1
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
            this.lbl_thongtinsinhvien = new System.Windows.Forms.Label();
            this.gb_ThongTinSinhVien = new System.Windows.Forms.GroupBox();
            this.cb_ChuyenNganh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.optFemale = new System.Windows.Forms.RadioButton();
            this.optMale = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtNu = new System.Windows.Forms.TextBox();
            this.bnt_Update = new System.Windows.Forms.Button();
            this.bnt_Delete = new System.Windows.Forms.Button();
            this.gb_ThongTinSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_thongtinsinhvien
            // 
            this.lbl_thongtinsinhvien.AutoSize = true;
            this.lbl_thongtinsinhvien.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thongtinsinhvien.Location = new System.Drawing.Point(485, 9);
            this.lbl_thongtinsinhvien.Name = "lbl_thongtinsinhvien";
            this.lbl_thongtinsinhvien.Size = new System.Drawing.Size(413, 40);
            this.lbl_thongtinsinhvien.TabIndex = 1;
            this.lbl_thongtinsinhvien.Text = "Quản lí thông tin sinh viên";
            // 
            // gb_ThongTinSinhVien
            // 
            this.gb_ThongTinSinhVien.Controls.Add(this.cb_ChuyenNganh);
            this.gb_ThongTinSinhVien.Controls.Add(this.label5);
            this.gb_ThongTinSinhVien.Controls.Add(this.txtDTB);
            this.gb_ThongTinSinhVien.Controls.Add(this.label4);
            this.gb_ThongTinSinhVien.Controls.Add(this.label3);
            this.gb_ThongTinSinhVien.Controls.Add(this.optFemale);
            this.gb_ThongTinSinhVien.Controls.Add(this.optMale);
            this.gb_ThongTinSinhVien.Controls.Add(this.txtHoTen);
            this.gb_ThongTinSinhVien.Controls.Add(this.label2);
            this.gb_ThongTinSinhVien.Controls.Add(this.txtMSSV);
            this.gb_ThongTinSinhVien.Controls.Add(this.label1);
            this.gb_ThongTinSinhVien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ThongTinSinhVien.Location = new System.Drawing.Point(36, 65);
            this.gb_ThongTinSinhVien.Name = "gb_ThongTinSinhVien";
            this.gb_ThongTinSinhVien.Size = new System.Drawing.Size(552, 398);
            this.gb_ThongTinSinhVien.TabIndex = 2;
            this.gb_ThongTinSinhVien.TabStop = false;
            this.gb_ThongTinSinhVien.Text = "Thông tin sinh viên";
            // 
            // cb_ChuyenNganh
            // 
            this.cb_ChuyenNganh.FormattingEnabled = true;
            this.cb_ChuyenNganh.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cb_ChuyenNganh.Location = new System.Drawing.Point(139, 346);
            this.cb_ChuyenNganh.Name = "cb_ChuyenNganh";
            this.cb_ChuyenNganh.Size = new System.Drawing.Size(392, 31);
            this.cb_ChuyenNganh.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chuyên ngành";
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(139, 261);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(392, 32);
            this.txtDTB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Điểm TB\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giới tính";
            // 
            // optFemale
            // 
            this.optFemale.AutoSize = true;
            this.optFemale.Checked = true;
            this.optFemale.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optFemale.Location = new System.Drawing.Point(254, 189);
            this.optFemale.Name = "optFemale";
            this.optFemale.Size = new System.Drawing.Size(66, 35);
            this.optFemale.TabIndex = 5;
            this.optFemale.TabStop = true;
            this.optFemale.Text = "Nữ";
            this.optFemale.UseVisualStyleBackColor = true;
            // 
            // optMale
            // 
            this.optMale.AutoSize = true;
            this.optMale.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMale.Location = new System.Drawing.Point(139, 189);
            this.optMale.Name = "optMale";
            this.optMale.Size = new System.Drawing.Size(83, 35);
            this.optMale.TabIndex = 4;
            this.optMale.Text = "Nam";
            this.optMale.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(139, 111);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(392, 32);
            this.txtHoTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(139, 52);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(392, 32);
            this.txtMSSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvStudent.Location = new System.Drawing.Point(594, 77);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvStudent.Size = new System.Drawing.Size(762, 468);
            this.dgvStudent.TabIndex = 3;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MSSV";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giới tính";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Điểm TB";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Khoa";
            this.Column5.Name = "Column5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(808, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tổng SV Nam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1087, 559);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tổng SV Nữ";
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(950, 551);
            this.txtNam.Name = "txtNam";
            this.txtNam.ReadOnly = true;
            this.txtNam.Size = new System.Drawing.Size(131, 32);
            this.txtNam.TabIndex = 11;
            // 
            // txtNu
            // 
            this.txtNu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNu.Location = new System.Drawing.Point(1214, 551);
            this.txtNu.Name = "txtNu";
            this.txtNu.ReadOnly = true;
            this.txtNu.Size = new System.Drawing.Size(142, 32);
            this.txtNu.TabIndex = 12;
            // 
            // bnt_Update
            // 
            this.bnt_Update.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Update.Location = new System.Drawing.Point(245, 494);
            this.bnt_Update.Name = "bnt_Update";
            this.bnt_Update.Size = new System.Drawing.Size(127, 35);
            this.bnt_Update.TabIndex = 13;
            this.bnt_Update.Text = "Thêm / sửa";
            this.bnt_Update.UseVisualStyleBackColor = true;
            this.bnt_Update.Click += new System.EventHandler(this.bnt_Update_Click);
            // 
            // bnt_Delete
            // 
            this.bnt_Delete.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Delete.Location = new System.Drawing.Point(401, 494);
            this.bnt_Delete.Name = "bnt_Delete";
            this.bnt_Delete.Size = new System.Drawing.Size(127, 35);
            this.bnt_Delete.TabIndex = 14;
            this.bnt_Delete.Text = "Xóa";
            this.bnt_Delete.UseVisualStyleBackColor = true;
            this.bnt_Delete.Click += new System.EventHandler(this.bnt_Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 586);
            this.Controls.Add(this.bnt_Delete);
            this.Controls.Add(this.bnt_Update);
            this.Controls.Add(this.txtNu);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.gb_ThongTinSinhVien);
            this.Controls.Add(this.lbl_thongtinsinhvien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_ThongTinSinhVien.ResumeLayout(false);
            this.gb_ThongTinSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_thongtinsinhvien;
        private System.Windows.Forms.GroupBox gb_ThongTinSinhVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton optFemale;
        private System.Windows.Forms.RadioButton optMale;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_ChuyenNganh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtNu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button bnt_Update;
        private System.Windows.Forms.Button bnt_Delete;
    }
}

