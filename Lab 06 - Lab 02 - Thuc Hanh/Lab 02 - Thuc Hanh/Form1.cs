using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02___Thuc_Hanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_cong_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtnum1.Text);
                float number2 = float.Parse(txtnum2.Text);
                float result = number1 + number2;
                txtAnswer.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng yêu cầu !!!");
            }
        }

        private void bnt_tru_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtnum1.Text);
                float number2 = float.Parse(txtnum2.Text);
                float result = number1 - number2;
                txtAnswer.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng yêu cầu !!!");
            }
        }

        private void bnt_nhan_Click(object sender, EventArgs e)
        {
            try
            {
            float number1 = float.Parse(txtnum1.Text);
            float number2 = float.Parse(txtnum2.Text);
            float result = number1 * number2;
            txtAnswer.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng yêu cầu !!!");
            }
}

        private void bnt_chia_Click(object sender, EventArgs e)
        {
            try
            {
            float number1 = float.Parse(txtnum1.Text);
            float number2 = float.Parse(txtnum2.Text);
            float result = number1 / number2;
            txtAnswer.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng yêu cầu !!!");
            }
        }
    }
}
