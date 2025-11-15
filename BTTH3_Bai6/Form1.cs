using System;
using System.Drawing;
using System.Windows.Forms;
namespace BTTH3_Bai6
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string operation = "";
        bool isOperationClicked = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (TextDisplay.Text == "0" || isOperationClicked)
                TextDisplay.Clear();

            TextDisplay.Text += btn.Text;
            isOperationClicked = false;
        }

        private void TinhToan_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            firstNumber = double.Parse(TextDisplay.Text);
            operation = btn.Text;
            isOperationClicked = true;
        }

        private void Bang_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(TextDisplay.Text);
            double result = 0;

            switch (operation)
            {
                case "+": result = firstNumber + secondNumber; break;
                case "-": result = firstNumber - secondNumber; break;
                case "*": result = firstNumber * secondNumber; break;
                case "/":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                        MessageBox.Show("Không thể chia cho 0!");
                    break;
            }

            TextDisplay.Text = result.ToString();
            isOperationClicked = false;
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text.Length > 1)
                TextDisplay.Text = TextDisplay.Text.Substring(0, TextDisplay.Text.Length - 1);
            else
                TextDisplay.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = "0";
        }

        private void C_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = "0";
            firstNumber = 0;
            operation = "";
            isOperationClicked = false;
        }
    }
}
