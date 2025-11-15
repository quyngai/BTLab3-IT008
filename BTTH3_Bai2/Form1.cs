using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTTH3_Bai2
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private Button btnRefresh;  

        public Form1()
        {
            InitializeComponent();

            btnRefresh = new Button();
            btnRefresh.Text = "Draw";
            btnRefresh.Dock = DockStyle.Bottom;
            btnRefresh.Height = 40;
            btnRefresh.Click += BtnRefresh_Click;
            Controls.Add(btnRefresh);

            this.Paint += Form1_Paint;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int x = rand.Next(Width - 150);
            int y = rand.Next(Height - 100);
            Color randomColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            Brush rndbrush = new SolidBrush(randomColor);
            e.Graphics.DrawString(
                "Paint Event",
                new Font("Arial", 20, FontStyle.Bold),
                rndbrush,
                x,
                y
            );
        }
    }
}
