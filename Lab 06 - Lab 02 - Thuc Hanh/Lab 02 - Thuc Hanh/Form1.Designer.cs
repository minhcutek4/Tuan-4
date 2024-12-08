namespace Lab_02___Thuc_Hanh
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
            this.lbl_Number1 = new System.Windows.Forms.Label();
            this.lbl_Number2 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.bnt_cong = new System.Windows.Forms.Button();
            this.bnt_tru = new System.Windows.Forms.Button();
            this.bnt_nhan = new System.Windows.Forms.Button();
            this.bnt_chia = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.lbl_MayTinhCoBan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Number1
            // 
            this.lbl_Number1.AccessibleName = "lbl_Number1";
            this.lbl_Number1.AutoSize = true;
            this.lbl_Number1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Number1.Location = new System.Drawing.Point(116, 88);
            this.lbl_Number1.Name = "lbl_Number1";
            this.lbl_Number1.Size = new System.Drawing.Size(94, 23);
            this.lbl_Number1.TabIndex = 0;
            this.lbl_Number1.Text = "Number 1";
            // 
            // lbl_Number2
            // 
            this.lbl_Number2.AutoSize = true;
            this.lbl_Number2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Number2.Location = new System.Drawing.Point(116, 162);
            this.lbl_Number2.Name = "lbl_Number2";
            this.lbl_Number2.Size = new System.Drawing.Size(94, 23);
            this.lbl_Number2.TabIndex = 1;
            this.lbl_Number2.Text = "Number 2";
            // 
            // txtnum1
            // 
            this.txtnum1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum1.Location = new System.Drawing.Point(216, 82);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(409, 33);
            this.txtnum1.TabIndex = 2;
            // 
            // txtnum2
            // 
            this.txtnum2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum2.Location = new System.Drawing.Point(216, 156);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(409, 33);
            this.txtnum2.TabIndex = 3;
            // 
            // bnt_cong
            // 
            this.bnt_cong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_cong.Location = new System.Drawing.Point(151, 230);
            this.bnt_cong.Name = "bnt_cong";
            this.bnt_cong.Size = new System.Drawing.Size(59, 39);
            this.bnt_cong.TabIndex = 4;
            this.bnt_cong.Text = "+";
            this.bnt_cong.UseVisualStyleBackColor = true;
            this.bnt_cong.Click += new System.EventHandler(this.bnt_cong_Click);
            // 
            // bnt_tru
            // 
            this.bnt_tru.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_tru.Location = new System.Drawing.Point(266, 230);
            this.bnt_tru.Name = "bnt_tru";
            this.bnt_tru.Size = new System.Drawing.Size(59, 39);
            this.bnt_tru.TabIndex = 5;
            this.bnt_tru.Text = "-";
            this.bnt_tru.UseVisualStyleBackColor = true;
            this.bnt_tru.Click += new System.EventHandler(this.bnt_tru_Click);
            // 
            // bnt_nhan
            // 
            this.bnt_nhan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_nhan.Location = new System.Drawing.Point(383, 230);
            this.bnt_nhan.Name = "bnt_nhan";
            this.bnt_nhan.Size = new System.Drawing.Size(59, 39);
            this.bnt_nhan.TabIndex = 6;
            this.bnt_nhan.Text = "x";
            this.bnt_nhan.UseVisualStyleBackColor = true;
            this.bnt_nhan.Click += new System.EventHandler(this.bnt_nhan_Click);
            // 
            // bnt_chia
            // 
            this.bnt_chia.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_chia.Location = new System.Drawing.Point(515, 230);
            this.bnt_chia.Name = "bnt_chia";
            this.bnt_chia.Size = new System.Drawing.Size(59, 39);
            this.bnt_chia.TabIndex = 7;
            this.bnt_chia.Text = "/";
            this.bnt_chia.UseVisualStyleBackColor = true;
            this.bnt_chia.Click += new System.EventHandler(this.bnt_chia_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(216, 312);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(409, 33);
            this.txtAnswer.TabIndex = 8;
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Answer.Location = new System.Drawing.Point(116, 318);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(73, 23);
            this.lbl_Answer.TabIndex = 9;
            this.lbl_Answer.Text = "Answer";
            // 
            // lbl_MayTinhCoBan
            // 
            this.lbl_MayTinhCoBan.AccessibleName = "lbl_Number1";
            this.lbl_MayTinhCoBan.AutoSize = true;
            this.lbl_MayTinhCoBan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MayTinhCoBan.Location = new System.Drawing.Point(334, 30);
            this.lbl_MayTinhCoBan.Name = "lbl_MayTinhCoBan";
            this.lbl_MayTinhCoBan.Size = new System.Drawing.Size(142, 23);
            this.lbl_MayTinhCoBan.TabIndex = 10;
            this.lbl_MayTinhCoBan.Text = "Máy tính cơ bản";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_MayTinhCoBan);
            this.Controls.Add(this.lbl_Answer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.bnt_chia);
            this.Controls.Add(this.bnt_nhan);
            this.Controls.Add(this.bnt_tru);
            this.Controls.Add(this.bnt_cong);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lbl_Number2);
            this.Controls.Add(this.lbl_Number1);
            this.Name = "Form1";
            this.Text = "Lab 02 - Example - BT1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Number1;
        private System.Windows.Forms.Label lbl_Number2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Button bnt_cong;
        private System.Windows.Forms.Button bnt_tru;
        private System.Windows.Forms.Button bnt_nhan;
        private System.Windows.Forms.Button bnt_chia;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.Label lbl_MayTinhCoBan;
    }
}

