namespace QuanLy
{
    partial class FormBanHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChonPhieu = new System.Windows.Forms.Button();
            this.tbSoPhieuXuat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NgayXuat = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaKH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.lbMaHang = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.SoPhieuXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuongXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChonPhieu);
            this.panel1.Controls.Add(this.tbSoPhieuXuat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(69, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 52);
            this.panel1.TabIndex = 0;
            // 
            // btnChonPhieu
            // 
            this.btnChonPhieu.Location = new System.Drawing.Point(340, 12);
            this.btnChonPhieu.Name = "btnChonPhieu";
            this.btnChonPhieu.Size = new System.Drawing.Size(118, 27);
            this.btnChonPhieu.TabIndex = 2;
            this.btnChonPhieu.Text = "Chọn phiếu...";
            this.btnChonPhieu.UseVisualStyleBackColor = true;
            // 
            // tbSoPhieuXuat
            // 
            this.tbSoPhieuXuat.Location = new System.Drawing.Point(131, 9);
            this.tbSoPhieuXuat.Name = "tbSoPhieuXuat";
            this.tbSoPhieuXuat.Size = new System.Drawing.Size(190, 27);
            this.tbSoPhieuXuat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu xuất:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NgayXuat);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(536, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 52);
            this.panel2.TabIndex = 1;
            // 
            // NgayXuat
            // 
            this.NgayXuat.CustomFormat = "dd/MM/yyyy";
            this.NgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayXuat.Location = new System.Drawing.Point(131, 12);
            this.NgayXuat.Name = "NgayXuat";
            this.NgayXuat.Size = new System.Drawing.Size(250, 27);
            this.NgayXuat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách hàng:";
            // 
            // MaKH
            // 
            this.MaKH.FormattingEnabled = true;
            this.MaKH.Location = new System.Drawing.Point(200, 70);
            this.MaKH.Name = "MaKH";
            this.MaKH.Size = new System.Drawing.Size(270, 28);
            this.MaKH.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ghi chú:";
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(603, 67);
            this.tbGhiChu.Multiline = true;
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(314, 80);
            this.tbGhiChu.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(200, 109);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 38);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(299, 109);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 38);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(393, 109);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 38);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuXuat,
            this.STT,
            this.MaHang,
            this.SoLuongXuat,
            this.ThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(113, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(691, 273);
            this.dataGridView1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbTongTien);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(613, 579);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 52);
            this.panel3.TabIndex = 10;
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(131, 9);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.ReadOnly = true;
            this.tbTongTien.Size = new System.Drawing.Size(190, 27);
            this.tbTongTien.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = " Tổng Tiền";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(960, 582);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(105, 38);
            this.btnInHoaDon.TabIndex = 11;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // lbMaHang
            // 
            this.lbMaHang.AutoSize = true;
            this.lbMaHang.Location = new System.Drawing.Point(113, 164);
            this.lbMaHang.Name = "lbMaHang";
            this.lbMaHang.Size = new System.Drawing.Size(73, 20);
            this.lbMaHang.TabIndex = 12;
            this.lbMaHang.Text = "Mã Hàng:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(200, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(113, 205);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(75, 20);
            this.lbSoLuong.TabIndex = 14;
            this.lbSoLuong.Text = "Số Lượng:";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(200, 202);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(44, 27);
            this.tbSoLuong.TabIndex = 15;
            // 
            // SoPhieuXuat
            // 
            this.SoPhieuXuat.HeaderText = "Số phiếu xuất";
            this.SoPhieuXuat.MinimumWidth = 6;
            this.SoPhieuXuat.Name = "SoPhieuXuat";
            this.SoPhieuXuat.Width = 125;
            // 
            // STT
            // 
            this.STT.HeaderText = "Số thứ tự";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 125;
            // 
            // MaHang
            // 
            this.MaHang.FillWeight = 200F;
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            this.MaHang.Width = 125;
            // 
            // SoLuongXuat
            // 
            this.SoLuongXuat.HeaderText = "Số Lượng Bán";
            this.SoLuongXuat.MinimumWidth = 6;
            this.SoLuongXuat.Name = "SoLuongXuat";
            this.SoLuongXuat.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 125;
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 637);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbMaHang);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbGhiChu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormBanHang";
            this.Text = "Lập Hóa Đơn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox tbSoPhieuXuat;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private DateTimePicker NgayXuat;
        private Label label3;
        private ComboBox MaKH;
        private Label label4;
        private TextBox tbGhiChu;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dataGridView1;
        private Panel panel3;
        private TextBox tbTongTien;
        private Label label5;
        private Button btnInHoaDon;
        private Button btnChonPhieu;
        private Label lbMaHang;
        private ComboBox comboBox1;
        private Label lbSoLuong;
        private TextBox tbSoLuong;
        private DataGridViewTextBoxColumn SoPhieuXuat;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewComboBoxColumn MaHang;
        private DataGridViewTextBoxColumn SoLuongXuat;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}