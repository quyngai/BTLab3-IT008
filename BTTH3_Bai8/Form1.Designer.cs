namespace BTTH3_Bai8
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
            STK = new TextBox();
            TKH = new TextBox();
            DCKH = new TextBox();
            STTK = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Exit = new Button();
            Xoa = new Button();
            Them = new Button();
            Bang = new ListView();
            STT = new ColumnHeader();
            MaTK = new ColumnHeader();
            TenKH = new ColumnHeader();
            Diachi = new ColumnHeader();
            SoTien = new ColumnHeader();
            TongTien = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // STK
            // 
            STK.Location = new Point(208, 96);
            STK.Margin = new Padding(3, 6, 3, 10);
            STK.Name = "STK";
            STK.Size = new Size(513, 27);
            STK.TabIndex = 1;
            // 
            // TKH
            // 
            TKH.Location = new Point(208, 139);
            TKH.Margin = new Padding(3, 10, 3, 10);
            TKH.Name = "TKH";
            TKH.Size = new Size(513, 27);
            TKH.TabIndex = 2;
            // 
            // DCKH
            // 
            DCKH.Location = new Point(208, 186);
            DCKH.Margin = new Padding(3, 10, 3, 10);
            DCKH.Name = "DCKH";
            DCKH.Size = new Size(513, 27);
            DCKH.TabIndex = 3;
            // 
            // STTK
            // 
            STTK.Location = new Point(208, 233);
            STTK.Margin = new Padding(3, 10, 3, 10);
            STTK.Name = "STTK";
            STTK.Size = new Size(513, 27);
            STTK.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 99);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 5;
            label1.Text = "Số tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 142);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 6;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 189);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 7;
            label3.Text = "Địa chỉ khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 236);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 8;
            label4.Text = "Số tiền trong tài khoản";
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(841, 90);
            label5.TabIndex = 9;
            label5.Text = "QUẢN LÝ THÔNG TIN KHÁCH HÀNG";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            Exit.Location = new Point(627, 273);
            Exit.Margin = new Padding(15, 3, 15, 3);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 10;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Xoa
            // 
            Xoa.Location = new Point(503, 273);
            Xoa.Margin = new Padding(15, 3, 15, 3);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(94, 29);
            Xoa.TabIndex = 11;
            Xoa.Text = "Xóa";
            Xoa.UseVisualStyleBackColor = true;
            Xoa.Click += Xoa_Click;
            // 
            // Them
            // 
            Them.Location = new Point(350, 273);
            Them.Margin = new Padding(15, 3, 15, 3);
            Them.Name = "Them";
            Them.Size = new Size(123, 29);
            Them.TabIndex = 12;
            Them.Text = "Thêm/Cập nhật";
            Them.UseVisualStyleBackColor = true;
            Them.Click += Them_Click;
            // 
            // Bang
            // 
            Bang.Columns.AddRange(new ColumnHeader[] { STT, MaTK, TenKH, Diachi, SoTien });
            Bang.FullRowSelect = true;
            Bang.Location = new Point(27, 308);
            Bang.Name = "Bang";
            Bang.Size = new Size(787, 282);
            Bang.TabIndex = 13;
            Bang.UseCompatibleStateImageBehavior = false;
            Bang.View = View.Details;
            Bang.SelectedIndexChanged += Bang_SelectedIndexChanged;
            // 
            // STT
            // 
            STT.Text = "STT";
            STT.Width = 50;
            // 
            // MaTK
            // 
            MaTK.Text = "Mã tài khoản";
            MaTK.Width = 130;
            // 
            // TenKH
            // 
            TenKH.Text = "Tên khách hàng";
            TenKH.Width = 200;
            // 
            // Diachi
            // 
            Diachi.Text = "Địa Chỉ";
            Diachi.Width = 250;
            // 
            // SoTien
            // 
            SoTien.Text = "Số tiền";
            SoTien.Width = 150;
            // 
            // TongTien
            // 
            TongTien.BackColor = Color.White;
            TongTien.Location = new Point(447, 596);
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            TongTien.Size = new Size(367, 27);
            TongTien.TabIndex = 14;
            TongTien.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(369, 599);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 15;
            label6.Text = "Tổng tiền";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 635);
            Controls.Add(label6);
            Controls.Add(TongTien);
            Controls.Add(Bang);
            Controls.Add(Them);
            Controls.Add(Xoa);
            Controls.Add(Exit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(STTK);
            Controls.Add(DCKH);
            Controls.Add(TKH);
            Controls.Add(STK);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox STK;
        private TextBox TKH;
        private TextBox DCKH;
        private TextBox STTK;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Exit;
        private Button Xoa;
        private Button Them;
        private ListView Bang;
        private ColumnHeader STT;
        private ColumnHeader MaTK;
        private ColumnHeader TenKH;
        private ColumnHeader Diachi;
        private ColumnHeader SoTien;
        private TextBox TongTien;
        private Label label6;
    }
}
