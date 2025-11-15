using System;
using System.Windows.Forms;

namespace BTTH3_Bai1
{
    public partial class Form1 : Form
    {
        private ListBox lstEvents;
        private Button OpenWinBtn;

        public Form1()
        {
            InitializeComponent();

            lstEvents = new ListBox();
            lstEvents.Dock = DockStyle.Fill; 
            this.Controls.Add(lstEvents);

            this.Load += Form1_Load;
            this.Shown += Form1_Shown;
            this.Activated += Form1_Activated;
            this.Deactivate += Form1_Deactivate;
            this.FormClosing += Form1_FormClosing;
            this.FormClosed += Form1_FormClosed;

            OpenWinBtn = new Button();
            OpenWinBtn.Text = "Mo cua so";
            OpenWinBtn.Dock = DockStyle.Top;
            OpenWinBtn.Height = 30;
            OpenWinBtn.Click += BtnClick;
            this.Controls.Add(OpenWinBtn);
        }
        private void BtnClick(object sender, EventArgs e)
        {
            AddEvent($"{DateTime.Now:T}: Cua so duoc mo");
            MessageBox.Show("Day la cua so thong bao");
        }

        private void AddEvent(string message)
        {
            lstEvents.Items.Add($"{DateTime.Now:HH:mm:ss} - {message}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddEvent($"{DateTime.Now:T}: Form dang Load");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            AddEvent($"{DateTime.Now:T}: Form da hien thi");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            AddEvent($"{DateTime.Now:T}: Form duoc kich hoat");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            AddEvent($"{DateTime.Now:T}: Form bi thoat");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            AddEvent($"{DateTime.Now:T}: Form sap dong");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            AddEvent($"{DateTime.Now:T}: Form da dong");
        }
    }
}
