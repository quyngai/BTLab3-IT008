using System;
using System.Drawing.Imaging;
using System.Windows.Forms;
namespace BTTH3_Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnQuaPhai_Click(object sender, EventArgs e)
        {
            if (LstMonHoc1.SelectedItem == null)
            {
                MessageBox.Show("Chon mon truoc khi di chuyen");
                return;
            }

            LstMonHoc2.Items.Add(LstMonHoc1.SelectedItem);
            LstMonHoc1.Items.Remove(LstMonHoc1.SelectedItem);
        }
        private void BtnQuaTrai_Click(object sender, EventArgs e)
        {
            if (LstMonHoc2.SelectedItem == null)
            {
                MessageBox.Show("Chon mon truoc khi di chuyen");
                return;
            }
            LstMonHoc1.Items.Add(LstMonHoc2.SelectedItem);
            LstMonHoc2.Items.Remove(LstMonHoc2.SelectedItem);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MSVBox.Text) ||
                string.IsNullOrWhiteSpace(HTBox.Text))
            {
                MessageBox.Show("Vui long dien day du thong tin");
                return;
            }
            if (!NamBtn.Checked && !NuBtn.Checked)
            {
                MessageBox.Show("Vui long chon gioi tinh");
                return;
            }
            string gioitinh = NamBtn.Checked ? "Nam" : "Nu";
            int soMon = LstMonHoc2.Items.Count;
            DsSV.Rows.Add(MSVBox.Text, HTBox.Text, ChuyenNganhBox.Text, gioitinh, soMon);
            MessageBox.Show("Da luu");
            MSVBox.Clear();
            HTBox.Clear();
            NamBtn.Checked = false;
            NuBtn.Checked = false;
            for (int i = 0; i < LstMonHoc2.Items.Count; i++)
            {
                LstMonHoc1.Items.Add(LstMonHoc2.Items[i]);
            }
            LstMonHoc2.Items.Clear();
        }

        private void DsSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = DsSV.Rows[e.RowIndex];

            MSVBox.Text = row.Cells[0].Value?.ToString();
            HTBox.Text = row.Cells[1].Value?.ToString();
            ChuyenNganhBox.Text = row.Cells[2].Value?.ToString();

            string gt = row.Cells[3].Value?.ToString();
            NamBtn.Checked = (gt == "Nam");
            NuBtn.Checked = (gt == "Nu");
            int soMon = Convert.ToInt32(row.Cells[4].Value);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (DsSV.SelectedRows.Count > 0)
            {
                DsSV.Rows.Remove(DsSV.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Chon dong can xoa");
            }
        }
    }
}
