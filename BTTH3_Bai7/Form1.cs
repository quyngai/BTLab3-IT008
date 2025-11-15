using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;

namespace BTT3_Bai7
{
    public partial class Form1 : Form
    {
        private List<Button> selectedSeats = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            CreateSeats();
        }
        private void CreateSeats()
        {
            int seatNumber = 1;
            int startX = 55;
            int startY = 120;
            int w = 60, h = 40;

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Button seat = new Button();
                    seat.Width = w;
                    seat.Height = h;
                    seat.Left = startX + col * (w + 10);
                    seat.Top = startY + row * (h + 10);

                    seat.Text = seatNumber.ToString();
                    seat.Tag = seatNumber;

                    seat.BackColor = Color.White;

                    seat.Click += Seat_Click;

                    this.Controls.Add(seat);

                    seatNumber++;
                }
            }
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            Button seat = sender as Button;

            if (seat.BackColor == Color.Yellow)
            {
                MessageBox.Show($"Ghe {seat.Text} da duoc ban");
                return;
            }

            if (seat.BackColor == Color.LightBlue)
            {
                seat.BackColor = Color.White;
                selectedSeats.Remove(seat);
                return;
            }

            if (seat.BackColor == Color.White)
            {
                seat.BackColor = Color.LightBlue;
                selectedSeats.Add(seat);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int total = 0;

            foreach (Button seat in selectedSeats)
            {
                int seatNum = (int)seat.Tag;

                if (seatNum >= 1 && seatNum <= 5) total += 5000;
                else if (seatNum >= 6 && seatNum <= 10) total += 6500;
                else total += 8000;
                seat.BackColor = Color.Yellow;
            }

            selectedSeats.Clear();

            lblTongTien.Text = total.ToString();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Chon it nhat 1 ghe");
            }
            else
            {
                foreach (Button seat in selectedSeats)
                {
                    seat.BackColor = Color.White;
                }

                selectedSeats.Clear();
                lblTongTien.Text = "0";
            }
        }

        private void KetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
