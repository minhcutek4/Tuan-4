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
    public partial class Form1 : Form
    {

        private List<QuanLySinhVien> sinhVienList = new List<QuanLySinhVien>();
        public Form1()
        {
            InitializeComponent();
            Load += MainForm_Load;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            QuanLySinhVien formNhapLieu = new QuanLySinhVien();
            if (formNhapLieu.ShowDialog() == DialogResult.OK)
            {
                var sinhVien = formNhapLieu.SinhVien;
                if (sinhVien != null)
                {
                    sinhVienList.Add(sinhVien);
                    LoadDataGridView();
                }
            }
        }

        private void LoadDataGridView()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < sinhVienList.Count; i++)
            {
                var sv = sinhVienList[i];
                dataGridView1.Rows.Add(i + 1, sv.MaSV, sv.TenSV, sv.Khoa, sv.DiemTB);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Khởi tạo DataGridView
            dataGridView1.Columns.Add("STT", "Số TT");
            dataGridView1.Columns.Add("MaSV", "Mã Số SV");
            dataGridView1.Columns.Add("TenSV", "Tên Sinh Viên");
            dataGridView1.Columns.Add("Khoa", "Khoa");
            dataGridView1.Columns.Add("DiemTB", "Điểm TB");
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            var searchText = txtTimKiem.Text.ToLower();
            var filteredList = sinhVienList.Where(sv => sv.TenSV.ToLower().Contains(searchText)).ToList();

            dataGridView1.Rows.Clear();
            for (int i = 0; i < filteredList.Count; i++)
            {
                var sv = filteredList[i];
                dataGridView1.Rows.Add(i + 1, sv.MaSV, sv.TenSV, sv.Khoa, sv.DiemTB);
            }
        }
    }
}
