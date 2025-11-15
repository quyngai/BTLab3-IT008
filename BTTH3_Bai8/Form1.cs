using System;
using System.Drawing.Imaging;
using System.Windows.Forms;
namespace BTTH3_Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(STK.Text) ||
                string.IsNullOrWhiteSpace(TKH.Text) ||
                string.IsNullOrWhiteSpace(DCKH.Text) ||
                string.IsNullOrWhiteSpace(STTK.Text))
            {
                MessageBox.Show("Vui long nhap day du thong tin");
                return;
            }
            ListViewItem found = null;
            foreach (ListViewItem item in Bang.Items)
            {
                if (item.SubItems[1].Text == STK.Text)
                {
                    found = item;
                    break;
                }
            }
            if (found == null)
            {
                ListViewItem newItem = new ListViewItem((Bang.Items.Count + 1).ToString());
                newItem.SubItems.Add(STK.Text);
                newItem.SubItems.Add(TKH.Text);
                newItem.SubItems.Add(DCKH.Text);
                newItem.SubItems.Add(STTK.Text);
                Bang.Items.Add(newItem);
                MessageBox.Show("Da them thanh cong");
            }
            else
            {
                found.SubItems[2].Text = TKH.Text;
                found.SubItems[3].Text = DCKH.Text;
                found.SubItems[4].Text = STTK.Text;

                MessageBox.Show("Cap nhat thanh cong");
            }
            TinhTongTien();
        }
        private void TinhTongTien()
        {
            long tong = 0;
            foreach (ListViewItem item in Bang.Items)
            {
                long sotien = int.Parse(item.SubItems[4].Text);
                tong += sotien;
            }
            TongTien.Text = tong.ToString("N0");
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            string soTK = STK.Text;
            ListViewItem found = null;
            foreach (ListViewItem item in Bang.Items)
            {
                if (item.SubItems[1].Text == soTK)
                {
                    found = item;
                    break;
                }
            }
            if (found == null)
            {
                MessageBox.Show("Khong tim thay tai khoan");
                return;
            }
            DialogResult result = MessageBox.Show("Ban co muon xoa tai khoan nay?", "Xac nhan", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Bang.Items.Remove(found);
                MessageBox.Show("Da xoa tai khoan");
                TinhTongTien();
                
            }
        }

        private void Bang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Bang.SelectedItems.Count == 0) return;
            ListViewItem item = Bang.SelectedItems[0];
            STK.Text = item.SubItems[1].Text;
            TKH.Text = item.SubItems[2].Text;
            DCKH.Text = item.SubItems[3].Text;
            STTK.Text = item.SubItems[4].Text;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
