using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02___Thuc_Hanh___Bai_03
{
    public partial class Form1 : Form
    {
        private List<Button> buttons;
        private List<int> selectedSeats;
        private int totalPrice;
        public Form1()
        {
            InitializeComponent();
            InitializeButtons();
            selectedSeats = new List<int>();
            totalPrice = 0;
        }

        private void InitializeButtons()
        {
            buttons = new List<Button>
            {
                button1, button2, button3, button4, button5,
                button6, button7, button8, button9, button10,
                button11, button12, button13, button14, button15,
                button16, button17, button18, button19, button20
            };

            foreach (var button in buttons)
            {
                button.BackColor = Color.White;
                button.Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int seatIndex = buttons.IndexOf(button) + 1;

            if (button.BackColor == Color.White) 
            {
                button.BackColor = Color.Green; 
                selectedSeats.Add(seatIndex);
            }
            else if (button.BackColor == Color.Green)
            {
                button.BackColor = Color.White; 
                selectedSeats.Remove(seatIndex);
            }
            else if (button.BackColor == Color.Yellow) 
            {
                MessageBox.Show("Ghế đã được bán!", "Thông báo", MessageBoxButtons.OK);
            }

            TinhTien();
        }

        private void bnt_Select(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.White)
                button.BackColor = Color.Yellow;
            else if (button.BackColor == Color.Yellow)
                MessageBox.Show("Ghế đã được bán", "Thông báo", MessageBoxButtons.OK);
        }

        private void TinhTien()
        {
            totalPrice = 0;
            foreach (var seat in selectedSeats)
            {
                if (seat <= 5) totalPrice += 30000; 
                else if (seat <= 10) totalPrice += 40000; 
                else if (seat <= 15) totalPrice += 50000; 
                else if (seat <= 20) totalPrice += 80000; 
            }
            txtThanhTien.Text = totalPrice.ToString("N0") + "đ";
        }

        private void bnt_HuyBo_Click(object sender, EventArgs e)
        {
            foreach (var seat in selectedSeats)
            {
                Button button = buttons[seat - 1];
                button.BackColor = Color.White; 
            }
            selectedSeats.Clear(); 
            totalPrice = 0;
            TinhTien();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            foreach (var seat in selectedSeats)
            {
                Button button = buttons[seat - 1];
                button.BackColor = Color.Yellow; 
            }
            selectedSeats.Clear(); 
            totalPrice = 0;
            TinhTien();
        }

        private void bnt_End_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
