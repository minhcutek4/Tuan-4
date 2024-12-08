using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_06___Bai_Tap___Quan_Ly_Sinh_Vien
{

    public partial class QuanLySinhVien : Form
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string Khoa { get; set; }
        public double DiemTB { get; set; }

        public QuanLySinhVien SinhVien { get; private set; }
        public QuanLySinhVien()
        {
            InitializeComponent();
            cmbKhoa.SelectedIndex = 0;
        }

        private void bnt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bnt_add_Click(object sender, EventArgs e)
        {
           if (string.IsNullOrWhiteSpace(txtMSSV.Text) ||
           string.IsNullOrWhiteSpace(txtHoTen.Text) ||
           string.IsNullOrWhiteSpace(txtDTB.Text))
            {
                MessageBox.Show("Các thông tin Mã số, Tên Sinh Viên, Điểm là bắt buộc.", "Thông báo");
                return;
            }

            if (double.TryParse(txtDTB.Text, out double diem))
            {
                if (diem < 0 || diem > 10)
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng từ 0 - 10.", "Thông báo");
                    return;
                }

                SinhVien = new QuanLySinhVien
                {
                    MaSV = txtMSSV.Text,
                    TenSV = txtHoTen.Text,
                    Khoa = cmbKhoa.SelectedItem.ToString(),
                    DiemTB = diem
                };

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Điểm phải là số.", "Thông báo");
            }
        }
    }
}
