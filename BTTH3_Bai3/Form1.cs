using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTTH3_Bai3
{
    public partial class Form1 : Form
    {
        private Button btnChangeColor;
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            btnChangeColor = new Button();
            btnChangeColor.Text = "Change Color";
            btnChangeColor.Width = 150;
            btnChangeColor.Height = 40;
            btnChangeColor.Location = new Point((this.ClientSize.Width - btnChangeColor.Width) / 2,
                                                (this.ClientSize.Height - btnChangeColor.Height) / 2);

            btnChangeColor.Click += BtnChangeColor_Click;

            Controls.Add(btnChangeColor);

            this.Resize += Form1_Resize;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            btnChangeColor.Location = new Point((this.ClientSize.Width - btnChangeColor.Width) / 2,
                                                (this.ClientSize.Height - btnChangeColor.Height) / 2);
        }

        private void BtnChangeColor_Click(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            this.BackColor = randomColor;
        }
    }
}
