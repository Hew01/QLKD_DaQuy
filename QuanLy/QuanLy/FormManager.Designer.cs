namespace QuanLy
{
    partial class FormManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infomationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infomatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBaoCaoTonKho = new System.Windows.Forms.Button();
            this.btnDanhSachPhieuDichVu = new System.Windows.Forms.Button();
            this.btnLapPhieuDichVu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLapPhieuBanHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infomationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infomationToolStripMenuItem
            // 
            this.infomationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infomatToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.infomationToolStripMenuItem.Name = "infomationToolStripMenuItem";
            this.infomationToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.infomationToolStripMenuItem.Text = "Tai Khoan";
            // 
            // infomatToolStripMenuItem
            // 
            this.infomatToolStripMenuItem.Name = "infomatToolStripMenuItem";
            this.infomatToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.infomatToolStripMenuItem.Text = "Thong tin tai khoan";
            this.infomatToolStripMenuItem.Click += new System.EventHandler(this.infomatToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.logoutToolStripMenuItem.Text = "Dang Xuat";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBaoCaoTonKho);
            this.panel1.Controls.Add(this.btnDanhSachPhieuDichVu);
            this.panel1.Controls.Add(this.btnLapPhieuDichVu);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnLapPhieuBanHang);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 388);
            this.panel1.TabIndex = 1;
            // 
            // btnBaoCaoTonKho
            // 
            this.btnBaoCaoTonKho.Location = new System.Drawing.Point(30, 149);
            this.btnBaoCaoTonKho.Name = "btnBaoCaoTonKho";
            this.btnBaoCaoTonKho.Size = new System.Drawing.Size(317, 67);
            this.btnBaoCaoTonKho.TabIndex = 4;
            this.btnBaoCaoTonKho.Text = "Báo Cáo Tồn Kho";
            this.btnBaoCaoTonKho.UseVisualStyleBackColor = true;
            this.btnBaoCaoTonKho.Click += new System.EventHandler(this.btnBaoCaoTonKho_Click);
            // 
            // btnDanhSachPhieuDichVu
            // 
            this.btnDanhSachPhieuDichVu.Location = new System.Drawing.Point(30, 295);
            this.btnDanhSachPhieuDichVu.Name = "btnDanhSachPhieuDichVu";
            this.btnDanhSachPhieuDichVu.Size = new System.Drawing.Size(317, 67);
            this.btnDanhSachPhieuDichVu.TabIndex = 3;
            this.btnDanhSachPhieuDichVu.Text = "Danh Sách Phiếu Dịch Vụ";
            this.btnDanhSachPhieuDichVu.UseVisualStyleBackColor = true;
            this.btnDanhSachPhieuDichVu.Click += new System.EventHandler(this.btnDanhSachPhieuDichVu_Click);
            // 
            // btnLapPhieuDichVu
            // 
            this.btnLapPhieuDichVu.Location = new System.Drawing.Point(30, 222);
            this.btnLapPhieuDichVu.Name = "btnLapPhieuDichVu";
            this.btnLapPhieuDichVu.Size = new System.Drawing.Size(317, 67);
            this.btnLapPhieuDichVu.TabIndex = 2;
            this.btnLapPhieuDichVu.Text = "Lập Phiếu Dịch Vụ";
            this.btnLapPhieuDichVu.UseVisualStyleBackColor = true;
            this.btnLapPhieuDichVu.Click += new System.EventHandler(this.btnLapPhieuDichVu_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(317, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lập Phiếu Mua Hàng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLapPhieuBanHang
            // 
            this.btnLapPhieuBanHang.Location = new System.Drawing.Point(30, 3);
            this.btnLapPhieuBanHang.Name = "btnLapPhieuBanHang";
            this.btnLapPhieuBanHang.Size = new System.Drawing.Size(317, 67);
            this.btnLapPhieuBanHang.TabIndex = 0;
            this.btnLapPhieuBanHang.Text = "Lập Phiếu Bán Hàng";
            this.btnLapPhieuBanHang.UseVisualStyleBackColor = true;
            this.btnLapPhieuBanHang.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(518, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 98);
            this.label2.TabIndex = 3;
            this.label2.Text = "CHƯƠNG TRÌNH QUẢN LÝ CỬA HÀNG VÀNG BẠC ĐÁ QUÝ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(534, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Liên Hệ Bảo Trì: 0123456789";
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 477);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Cửa Hàng Vàng Bạc Đá Quý";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem infomationToolStripMenuItem;
        private ToolStripMenuItem infomatToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Panel panel1;
        private Button btnLapPhieuBanHang;
        private Button button2;
        private Button btnLapPhieuDichVu;
        private Button btnDanhSachPhieuDichVu;
        private Button btnBaoCaoTonKho;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}