using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTTH3_Bai4
{
    public partial class Form1 : Form
    {
        private MenuStrip menuStrip;
        private ToolStripMenuItem formatMenu;
        private ToolStripMenuItem colorMenuItem;
        private ColorDialog colorDialog;

        public Form1()
        {
            InitializeComponent();

            menuStrip = new MenuStrip();
            menuStrip.BackColor = Color.LightGray;
            formatMenu = new ToolStripMenuItem("Format");
            formatMenu.BackColor = Color.AliceBlue;

            colorMenuItem = new ToolStripMenuItem("Color");
            colorMenuItem.Click += ColorMenuItem_Click;
            colorMenuItem.BackColor = Color.AliceBlue;
            formatMenu.DropDownItems.Add(colorMenuItem);
            menuStrip.Items.Add(formatMenu);

            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);

            colorDialog = new ColorDialog();
        }

        private void ColorMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color; 
            }
        }
    }
}
