namespace Lab_06___Bai_Tap___Quan_Ly_Sinh_Vien
{
    partial class QuanLySinhVien
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
            this.lbl_MSSV = new System.Windows.Forms.Label();
            this.lbl_DTB = new System.Windows.Forms.Label();
            this.lbl_Khoa = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.bnt_add = new System.Windows.Forms.Button();
            this.bnt_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_MSSV
            // 
            this.lbl_MSSV.AutoSize = true;
            this.lbl_MSSV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MSSV.Location = new System.Drawing.Point(83, 62);
            this.lbl_MSSV.Name = "lbl_MSSV";
            this.lbl_MSSV.Size = new System.Drawing.Size(127, 21);
            this.lbl_MSSV.TabIndex = 0;
            this.lbl_MSSV.Text = "Mã số sinh viên";
            // 
            // lbl_DTB
            // 
            this.lbl_DTB.AutoSize = true;
            this.lbl_DTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DTB.Location = new System.Drawing.Point(78, 214);
            this.lbl_DTB.Name = "lbl_DTB";
            this.lbl_DTB.Size = new System.Drawing.Size(132, 21);
            this.lbl_DTB.TabIndex = 1;
            this.lbl_DTB.Text = "Điểm trung bình";
            // 
            // lbl_Khoa
            // 
            this.lbl_Khoa.AutoSize = true;
            this.lbl_Khoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Khoa.Location = new System.Drawing.Point(155, 161);
            this.lbl_Khoa.Name = "lbl_Khoa";
            this.lbl_Khoa.Size = new System.Drawing.Size(50, 21);
            this.lbl_Khoa.TabIndex = 2;
            this.lbl_Khoa.Text = "Khoa";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.Location = new System.Drawing.Point(123, 109);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(82, 21);
            this.lbl_HoTen.TabIndex = 3;
            this.lbl_HoTen.Text = "Họ và tên";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.Location = new System.Drawing.Point(212, 56);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(402, 27);
            this.txtMSSV.TabIndex = 4;
            // 
            // txtDTB
            // 
            this.txtDTB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDTB.Location = new System.Drawing.Point(216, 208);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(398, 27);
            this.txtDTB.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(212, 103);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(402, 27);
            this.txtHoTen.TabIndex = 6;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmbKhoa.Location = new System.Drawing.Point(212, 161);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(402, 27);
            this.cmbKhoa.TabIndex = 7;
            // 
            // bnt_add
            // 
            this.bnt_add.BackColor = System.Drawing.Color.Green;
            this.bnt_add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_add.Location = new System.Drawing.Point(351, 281);
            this.bnt_add.Name = "bnt_add";
            this.bnt_add.Size = new System.Drawing.Size(103, 44);
            this.bnt_add.TabIndex = 8;
            this.bnt_add.Text = "Thêm mới";
            this.bnt_add.UseVisualStyleBackColor = false;
            this.bnt_add.Click += new System.EventHandler(this.bnt_add_Click);
            // 
            // bnt_exit
            // 
            this.bnt_exit.BackColor = System.Drawing.Color.Red;
            this.bnt_exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_exit.ForeColor = System.Drawing.Color.White;
            this.bnt_exit.Location = new System.Drawing.Point(488, 281);
            this.bnt_exit.Name = "bnt_exit";
            this.bnt_exit.Size = new System.Drawing.Size(103, 44);
            this.bnt_exit.TabIndex = 9;
            this.bnt_exit.Text = "Thoát";
            this.bnt_exit.UseVisualStyleBackColor = false;
            this.bnt_exit.Click += new System.EventHandler(this.bnt_exit_Click);
            // 
            // QuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnt_exit);
            this.Controls.Add(this.bnt_add);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.lbl_HoTen);
            this.Controls.Add(this.lbl_Khoa);
            this.Controls.Add(this.lbl_DTB);
            this.Controls.Add(this.lbl_MSSV);
            this.Name = "QuanLySinhVien";
            this.Text = "QuanLySinhVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MSSV;
        private System.Windows.Forms.Label lbl_DTB;
        private System.Windows.Forms.Label lbl_Khoa;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Button bnt_add;
        private System.Windows.Forms.Button bnt_exit;
    }
}