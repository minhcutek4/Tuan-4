using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02___Thuc_Hanh___Bai_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_ChuyenNganh.SelectedIndex = 0;
        }

        private int GetSelectedRow(string StudentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value.ToString() == StudentID)
                {
                    return i;
                }
            }
            return -1;
        }

        private void InsertUpdate(int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = txtMSSV.Text;
            dgvStudent.Rows[selectedRow].Cells[1].Value = txtHoTen.Text;
            dgvStudent.Rows[selectedRow].Cells[2].Value = optFemale.Checked ? "Nữ" : "Nam";
            dgvStudent.Rows[selectedRow].Cells[3].Value = float.Parse(txtDTB.Text).ToString();
            dgvStudent.Rows[selectedRow].Cells[4].Value = cb_ChuyenNganh.Text;
        }

        private void bnt_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMSSV.Text == "" || txtHoTen.Text == "" || txtDTB.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên !!!");

                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvStudent.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm mới dữ liệu thành công !!!", "Notification", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cập nhật dữ liệu thành công !!!", "Notification", MessageBoxButtons.OK);
                }
                UpdateGenderCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bnt_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy mã số sinh viên cần xóa !!!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "Yes/No", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvStudent.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa sinh viên thành công !!! ", "Thông báo", MessageBoxButtons.OK);
                        UpdateGenderCount();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateGenderCount()
        {
            int maleCount = 0;
            int femaleCount = 0;

            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    if (row.Cells[2].Value.ToString() == "Nam")
                    {
                        maleCount++;
                    }
                    else if (row.Cells[2].Value.ToString() == "Nữ")
                    {
                        femaleCount++;
                    }
                }
            }
            txtNam.Text = maleCount.ToString();
            txtNu.Text = femaleCount.ToString();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
                txtMSSV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Nữ")
                {
                    optFemale.Checked = true;
                }
                else
                {
                    optMale.Checked = true;
                }
                txtDTB.Text = row.Cells[3].Value.ToString();
                cb_ChuyenNganh.Text = row.Cells[4].Value.ToString();
                UpdateGenderCount();
            }
        }
    }
}
