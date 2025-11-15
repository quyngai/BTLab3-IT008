namespace BTTH3_Bai9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            MSVBox = new TextBox();
            HTBox = new TextBox();
            ChuyenNganhBox = new ComboBox();
            NamBtn = new RadioButton();
            NuBtn = new RadioButton();
            LstMonHoc1 = new ListBox();
            LstMonHoc2 = new ListBox();
            BtnQuaPhai = new Button();
            BtnQuaTrai = new Button();
            SaveBtn = new Button();
            CancelBtn = new Button();
            DsSV = new DataGridView();
            MSV = new DataGridViewTextBoxColumn();
            HT = new DataGridViewTextBoxColumn();
            CN = new DataGridViewTextBoxColumn();
            GT = new DataGridViewTextBoxColumn();
            SM = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DsSV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(30, 24);
            label1.Name = "label1";
            label1.Size = new Size(788, 379);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 14);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 1;
            label2.Text = "Thông tin sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 45);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 2;
            label3.Text = "Mã sinh viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 82);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Họ tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 119);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 4;
            label5.Text = "Chuyên ngành";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 156);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 5;
            label6.Text = "Giới tính";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(200, 190);
            label7.Name = "label7";
            label7.Size = new Size(194, 20);
            label7.TabIndex = 6;
            label7.Text = "Chọn các môn học tham gia";
            // 
            // MSVBox
            // 
            MSVBox.Location = new Point(376, 42);
            MSVBox.Margin = new Padding(3, 3, 3, 7);
            MSVBox.Name = "MSVBox";
            MSVBox.Size = new Size(171, 27);
            MSVBox.TabIndex = 7;
            // 
            // HTBox
            // 
            HTBox.Location = new Point(376, 79);
            HTBox.Margin = new Padding(3, 3, 3, 7);
            HTBox.Name = "HTBox";
            HTBox.Size = new Size(311, 27);
            HTBox.TabIndex = 8;
            // 
            // ChuyenNganhBox
            // 
            ChuyenNganhBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ChuyenNganhBox.FormattingEnabled = true;
            ChuyenNganhBox.Items.AddRange(new object[] { "Hệ thống thông tin", "Công nghệ thông tin", "Khoa học máy tính", "Kỹ thuật phần mềm", "Mạng MT và truyền thông" });
            ChuyenNganhBox.Location = new Point(376, 116);
            ChuyenNganhBox.Margin = new Padding(3, 3, 3, 7);
            ChuyenNganhBox.Name = "ChuyenNganhBox";
            ChuyenNganhBox.Size = new Size(311, 28);
            ChuyenNganhBox.TabIndex = 9;
            // 
            // NamBtn
            // 
            NamBtn.AutoSize = true;
            NamBtn.Location = new Point(376, 154);
            NamBtn.Name = "NamBtn";
            NamBtn.Size = new Size(62, 24);
            NamBtn.TabIndex = 10;
            NamBtn.TabStop = true;
            NamBtn.Text = "Nam";
            NamBtn.UseVisualStyleBackColor = true;
            // 
            // NuBtn
            // 
            NuBtn.AutoSize = true;
            NuBtn.Location = new Point(444, 154);
            NuBtn.Name = "NuBtn";
            NuBtn.Size = new Size(50, 24);
            NuBtn.TabIndex = 11;
            NuBtn.TabStop = true;
            NuBtn.Text = "Nữ";
            NuBtn.UseVisualStyleBackColor = true;
            // 
            // LstMonHoc1
            // 
            LstMonHoc1.FormattingEnabled = true;
            LstMonHoc1.Items.AddRange(new object[] { "Cơ sở dữ liệu", "Cơ sở DL NC", "PTTK Hệ Thống thông tin", "Giải tích" });
            LstMonHoc1.Location = new Point(200, 224);
            LstMonHoc1.Name = "LstMonHoc1";
            LstMonHoc1.Size = new Size(253, 104);
            LstMonHoc1.TabIndex = 12;
            // 
            // LstMonHoc2
            // 
            LstMonHoc2.FormattingEnabled = true;
            LstMonHoc2.Location = new Point(533, 224);
            LstMonHoc2.Name = "LstMonHoc2";
            LstMonHoc2.Size = new Size(253, 104);
            LstMonHoc2.TabIndex = 13;
            // 
            // BtnQuaPhai
            // 
            BtnQuaPhai.Location = new Point(459, 237);
            BtnQuaPhai.Name = "BtnQuaPhai";
            BtnQuaPhai.Size = new Size(68, 38);
            BtnQuaPhai.TabIndex = 14;
            BtnQuaPhai.Text = ">";
            BtnQuaPhai.UseVisualStyleBackColor = true;
            BtnQuaPhai.Click += BtnQuaPhai_Click;
            // 
            // BtnQuaTrai
            // 
            BtnQuaTrai.Location = new Point(459, 281);
            BtnQuaTrai.Name = "BtnQuaTrai";
            BtnQuaTrai.Size = new Size(68, 38);
            BtnQuaTrai.TabIndex = 15;
            BtnQuaTrai.Text = "<";
            BtnQuaTrai.UseVisualStyleBackColor = true;
            BtnQuaTrai.Click += BtnQuaTrai_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(352, 349);
            SaveBtn.Margin = new Padding(3, 3, 7, 3);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(128, 29);
            SaveBtn.TabIndex = 16;
            SaveBtn.Text = "Lưu thông tin";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(490, 349);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(101, 29);
            CancelBtn.TabIndex = 17;
            CancelBtn.Text = "Xóa chọn";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // DsSV
            // 
            DsSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DsSV.Columns.AddRange(new DataGridViewColumn[] { MSV, HT, CN, GT, SM });
            DsSV.Location = new Point(30, 432);
            DsSV.Name = "DsSV";
            DsSV.ReadOnly = true;
            DsSV.RowHeadersWidth = 51;
            DsSV.Size = new Size(788, 302);
            DsSV.TabIndex = 18;
            DsSV.CellClick += DsSV_CellClick;
            // 
            // MSV
            // 
            MSV.HeaderText = "MSSV";
            MSV.MinimumWidth = 6;
            MSV.Name = "MSV";
            MSV.ReadOnly = true;
            MSV.Width = 105;
            // 
            // HT
            // 
            HT.HeaderText = "Họ tên";
            HT.MinimumWidth = 6;
            HT.Name = "HT";
            HT.ReadOnly = true;
            HT.Width = 205;
            // 
            // CN
            // 
            CN.HeaderText = "Chuyên ngành";
            CN.MinimumWidth = 6;
            CN.Name = "CN";
            CN.ReadOnly = true;
            CN.Width = 210;
            // 
            // GT
            // 
            GT.HeaderText = "Giới tính";
            GT.MinimumWidth = 6;
            GT.Name = "GT";
            GT.ReadOnly = true;
            GT.Width = 125;
            // 
            // SM
            // 
            SM.HeaderText = "Số môn";
            SM.MinimumWidth = 6;
            SM.Name = "SM";
            SM.ReadOnly = true;
            SM.Width = 90;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 757);
            Controls.Add(DsSV);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(BtnQuaTrai);
            Controls.Add(BtnQuaPhai);
            Controls.Add(LstMonHoc2);
            Controls.Add(LstMonHoc1);
            Controls.Add(NuBtn);
            Controls.Add(NamBtn);
            Controls.Add(ChuyenNganhBox);
            Controls.Add(HTBox);
            Controls.Add(MSVBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DsSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox MSVBox;
        private TextBox HTBox;
        private ComboBox ChuyenNganhBox;
        private RadioButton NamBtn;
        private RadioButton NuBtn;
        private ListBox LstMonHoc1;
        private ListBox LstMonHoc2;
        private Button BtnQuaPhai;
        private Button BtnQuaTrai;
        private Button SaveBtn;
        private Button CancelBtn;
        private DataGridView DsSV;
        private DataGridViewTextBoxColumn MSV;
        private DataGridViewTextBoxColumn HT;
        private DataGridViewTextBoxColumn CN;
        private DataGridViewTextBoxColumn GT;
        private DataGridViewTextBoxColumn SM;
    }
}
