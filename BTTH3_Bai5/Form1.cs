using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTTH3_Bai5
{
    public partial class Form1 : Form
    {
        private TextBox txtNumber1, txtNumber2, txtAnswer;
        private Label lblNum1, lblNum2, lblAnswer;
        private Button btnAdd, btnSub, btnMul, btnDiv;

        public Form1()
        {
            InitializeCalculator();
        }

        private void InitializeCalculator()
        {
            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            lblNum1 = new Label() 
            { 
                Text = "Number 1:", Location = new Point(50, 30), AutoSize = true 
            };
            lblNum2 = new Label() 
            { 
                Text = "Number 2:", Location = new Point(50, 70), AutoSize = true 
            };
            lblAnswer = new Label() 
            { 
                Text = "Answer:", Location = new Point(50, 180), AutoSize = true 
            };

            txtNumber1 = new TextBox() 
            { 
                Location = new Point(150, 30), Width = 270
            };
            txtNumber2 = new TextBox() 
            {
                Location = new Point(150, 70), Width = 270
            };
            txtAnswer = new TextBox() 
            { 
                Location = new Point(150, 180), Width = 270, ReadOnly = true, BackColor = Color.White 
            };

            btnAdd = new Button() 
            { 
                Text = "+", Location = new Point(100, 110), Size = new Size(60, 60) 
            };
            btnSub = new Button()
            { 
                Text = "-", Location = new Point(170, 110), Size = new Size(60, 60) 
            };
            btnMul = new Button() 
            { 
                Text = "*", Location = new Point(240, 110), Size = new Size(60, 60) 
            };
            btnDiv = new Button() 
            { 
                Text = "/", Location = new Point(310, 110), Size = new Size(60, 60) 
            };

            btnAdd.Click += (s, e) => TinhToan("+");
            btnSub.Click += (s, e) => TinhToan("-");
            btnMul.Click += (s, e) => TinhToan("*");
            btnDiv.Click += (s, e) => TinhToan("/");

            this.Controls.Add(lblNum1);
            this.Controls.Add(lblNum2);
            this.Controls.Add(lblAnswer);
            this.Controls.Add(txtNumber1);
            this.Controls.Add(txtNumber2);
            this.Controls.Add(txtAnswer);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnSub);
            this.Controls.Add(btnMul);
            this.Controls.Add(btnDiv);
        }

        private void TinhToan(string phepToan)
        {
            try
            {
                decimal so1 = decimal.Parse(txtNumber1.Text);
                decimal so2 = decimal.Parse(txtNumber2.Text);
                decimal ketQua = 0;

                switch (phepToan)
                {
                    case "+": ketQua = so1 + so2; break;
                    case "-": ketQua = so1 - so2; break;
                    case "*": ketQua = so1 * so2; break;
                    case "/":
                        if (so2 == 0)
                        {
                            MessageBox.Show("Khong the chia cho 0!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        ketQua = so1 / so2;
                        break;
                }

                txtAnswer.Text = ketQua.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui long nhap so hop le!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da co loi xay ra: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
