namespace Lab_02___Thuc_Hanh___Bai_04
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bnt_Delete = new System.Windows.Forms.Button();
            this.bnt_Exit = new System.Windows.Forms.Button();
            this.bnt_Them_CapNhat = new System.Windows.Forms.Button();
            this.txt_STien = new System.Windows.Forms.TextBox();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.txt_DC = new System.Windows.Forms.TextBox();
            this.txt_STK = new System.Windows.Forms.TextBox();
            this.lbl_STien = new System.Windows.Forms.Label();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_stk = new System.Windows.Forms.Label();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.lstInfomation = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_thongtinsinhvien
            // 
            this.lbl_thongtinsinhvien.AutoSize = true;
            this.lbl_thongtinsinhvien.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thongtinsinhvien.Location = new System.Drawing.Point(368, 19);
            this.lbl_thongtinsinhvien.Name = "lbl_thongtinsinhvien";
            this.lbl_thongtinsinhvien.Size = new System.Drawing.Size(423, 40);
            this.lbl_thongtinsinhvien.TabIndex = 2;
            this.lbl_thongtinsinhvien.Text = "Quản lí thông tin tài khoản\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bnt_Delete);
            this.groupBox1.Controls.Add(this.bnt_Exit);
            this.groupBox1.Controls.Add(this.bnt_Them_CapNhat);
            this.groupBox1.Controls.Add(this.txt_STien);
            this.groupBox1.Controls.Add(this.txt_TenKH);
            this.groupBox1.Controls.Add(this.txt_DC);
            this.groupBox1.Controls.Add(this.txt_STK);
            this.groupBox1.Controls.Add(this.lbl_STien);
            this.groupBox1.Controls.Add(this.lbl_Ten);
            this.groupBox1.Controls.Add(this.lbl_DiaChi);
            this.groupBox1.Controls.Add(this.lbl_stk);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1138, 300);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // bnt_Delete
            // 
            this.bnt_Delete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Delete.Location = new System.Drawing.Point(572, 229);
            this.bnt_Delete.Name = "bnt_Delete";
            this.bnt_Delete.Size = new System.Drawing.Size(94, 43);
            this.bnt_Delete.TabIndex = 10;
            this.bnt_Delete.Text = "Xóa";
            this.bnt_Delete.UseVisualStyleBackColor = true;
            this.bnt_Delete.Click += new System.EventHandler(this.bnt_Delete_Click);
            // 
            // bnt_Exit
            // 
            this.bnt_Exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Exit.Location = new System.Drawing.Point(672, 229);
            this.bnt_Exit.Name = "bnt_Exit";
            this.bnt_Exit.Size = new System.Drawing.Size(140, 43);
            this.bnt_Exit.TabIndex = 9;
            this.bnt_Exit.Text = "Thoát";
            this.bnt_Exit.UseVisualStyleBackColor = true;
            this.bnt_Exit.Click += new System.EventHandler(this.bnt_Exit_Click);
            // 
            // bnt_Them_CapNhat
            // 
            this.bnt_Them_CapNhat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Them_CapNhat.Location = new System.Drawing.Point(412, 229);
            this.bnt_Them_CapNhat.Name = "bnt_Them_CapNhat";
            this.bnt_Them_CapNhat.Size = new System.Drawing.Size(154, 43);
            this.bnt_Them_CapNhat.TabIndex = 8;
            this.bnt_Them_CapNhat.Text = "Thêm / Cập nhật";
            this.bnt_Them_CapNhat.UseVisualStyleBackColor = true;
            this.bnt_Them_CapNhat.Click += new System.EventHandler(this.bnt_Them_CapNhat_Click);
            // 
            // txt_STien
            // 
            this.txt_STien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_STien.Location = new System.Drawing.Point(396, 179);
            this.txt_STien.Name = "txt_STien";
            this.txt_STien.Size = new System.Drawing.Size(416, 30);
            this.txt_STien.TabIndex = 7;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKH.Location = new System.Drawing.Point(397, 86);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(416, 30);
            this.txt_TenKH.TabIndex = 6;
            // 
            // txt_DC
            // 
            this.txt_DC.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DC.Location = new System.Drawing.Point(397, 130);
            this.txt_DC.Name = "txt_DC";
            this.txt_DC.Size = new System.Drawing.Size(416, 30);
            this.txt_DC.TabIndex = 5;
            // 
            // txt_STK
            // 
            this.txt_STK.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_STK.Location = new System.Drawing.Point(397, 41);
            this.txt_STK.Name = "txt_STK";
            this.txt_STK.Size = new System.Drawing.Size(416, 30);
            this.txt_STK.TabIndex = 4;
            // 
            // lbl_STien
            // 
            this.lbl_STien.AutoSize = true;
            this.lbl_STien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_STien.Location = new System.Drawing.Point(178, 185);
            this.lbl_STien.Name = "lbl_STien";
            this.lbl_STien.Size = new System.Drawing.Size(212, 24);
            this.lbl_STien.TabIndex = 3;
            this.lbl_STien.Text = "Số tiền trong tài khoản";
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten.Location = new System.Drawing.Point(239, 92);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(152, 24);
            this.lbl_Ten.TabIndex = 2;
            this.lbl_Ten.Text = "Tên khách hàng";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(211, 136);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(180, 24);
            this.lbl_DiaChi.TabIndex = 1;
            this.lbl_DiaChi.Text = "Địa chỉ khách hàng";
            // 
            // lbl_stk
            // 
            this.lbl_stk.AutoSize = true;
            this.lbl_stk.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stk.Location = new System.Drawing.Point(269, 47);
            this.lbl_stk.Name = "lbl_stk";
            this.lbl_stk.Size = new System.Drawing.Size(121, 24);
            this.lbl_stk.TabIndex = 0;
            this.lbl_stk.Text = "Số tài khoản";
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.Location = new System.Drawing.Point(574, 621);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(94, 24);
            this.lbl_TongTien.TabIndex = 11;
            this.lbl_TongTien.Text = "Tổng tiền";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(674, 615);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(476, 30);
            this.txt_TongTien.TabIndex = 11;
            // 
            // lstInfomation
            // 
            this.lstInfomation.HideSelection = false;
            this.lstInfomation.Location = new System.Drawing.Point(12, 378);
            this.lstInfomation.Name = "lstInfomation";
            this.lstInfomation.Size = new System.Drawing.Size(1138, 234);
            this.lstInfomation.TabIndex = 12;
            this.lstInfomation.UseCompatibleStateImageBehavior = false;
            this.lstInfomation.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 654);
            this.Controls.Add(this.lstInfomation);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.lbl_TongTien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_thongtinsinhvien);
            this.Name = "Form1";
            this.Text = "Quản lí thông tin tài khoản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_thongtinsinhvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_STien;
        private System.Windows.Forms.Label lbl_Ten;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_stk;
        private System.Windows.Forms.TextBox txt_STien;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.TextBox txt_DC;
        private System.Windows.Forms.TextBox txt_STK;
        private System.Windows.Forms.Button bnt_Delete;
        private System.Windows.Forms.Button bnt_Exit;
        private System.Windows.Forms.Button bnt_Them_CapNhat;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.ListView lstInfomation;
    }
}

