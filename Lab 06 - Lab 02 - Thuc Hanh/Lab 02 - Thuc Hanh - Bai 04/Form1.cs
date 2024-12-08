using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_02___Thuc_Hanh___Bai_04
{
    public partial class Form1 : Form
    {

        private List<Form1> accounts = new List<Form1>();
        public Form1()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void bnt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeListView()
        {
            lstInfomation.Columns.Add("STT", 50);
            lstInfomation.Columns.Add("Mã tài khoản", 200);
            lstInfomation.Columns.Add("Tên khách hàng", 250);
            lstInfomation.Columns.Add("Địa chỉ", 250);
            lstInfomation.Columns.Add("Số tiền", 100);
        }

        public string STK { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public decimal SoTien { get; set; }

        private void bnt_Them_CapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_STK.Text) || string.IsNullOrWhiteSpace(txt_TenKH.Text) ||
                string.IsNullOrWhiteSpace(txt_DC.Text) || string.IsNullOrWhiteSpace(txt_STien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string STK = txt_STK.Text;
            var existingAccount = accounts.FirstOrDefault(a => a.STK == STK);

            if (existingAccount == null)
            {
                // Thêm mới
                var newAccount = new Form1
                {
                    STK = STK,
                    TenKH = txt_TenKH.Text,
                    DiaChi = txt_DC.Text,
                    SoTien= decimal.Parse(txt_STien.Text)
                };
                accounts.Add(newAccount);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cập nhật
                existingAccount.TenKH = txt_TenKH.Text;
                existingAccount.DiaChi = txt_DC.Text;
                existingAccount.SoTien = decimal.Parse(txt_STK.Text);
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            RefreshListView();
            UpdateTotalAmount();
        }

        private void RefreshListView()
        {
            lstInfomation.Items.Clear();
            int index = 1;
            foreach (var account in accounts)
            {
                var item = new ListViewItem(index.ToString());
                item.SubItems.Add(account.STK);
                item.SubItems.Add(account.TenKH);
                item.SubItems.Add(account.DiaChi);
                item.SubItems.Add(account.SoTien.ToString());
                lstInfomation.Items.Add(item);
                index++;
            }
        }

        private void UpdateTotalAmount()
        {
            decimal total = accounts.Sum(a => a.SoTien);
            txt_TongTien.Text = $"{total}";
        }

        private void listViewAccounts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                txt_STK.Text = e.Item.SubItems[1].Text;
                txt_TenKH.Text = e.Item.SubItems[2].Text;
                txt_DC.Text = e.Item.SubItems[3].Text;
                txt_STien.Text = e.Item.SubItems[4].Text;
            }
        }

        private void bnt_Delete_Click(object sender, EventArgs e)
        {
            string STK = txt_STK.Text;
            var existingAccount = accounts.FirstOrDefault(a => a.STK == STK);

            if (existingAccount != null)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    accounts.Remove(existingAccount);
                    MessageBox.Show("Xóa tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshListView();
                    UpdateTotalAmount();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
