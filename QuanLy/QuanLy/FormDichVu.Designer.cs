namespace QuanLy
{
    partial class FormDichVu
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
            this.tbSoDienThoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoPhieu = new System.Windows.Forms.TextBox();
            this.lbsophieu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKhachHang = new System.Windows.Forms.TextBox();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaDuocTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInPhieuDichVu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSoDienThoai
            // 
            this.tbSoDienThoai.Location = new System.Drawing.Point(702, 148);
            this.tbSoDienThoai.Name = "tbSoDienThoai";
            this.tbSoDienThoai.Size = new System.Drawing.Size(261, 27);
            this.tbSoDienThoai.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Số điện thoại:";
            // 
            // DateTime
            // 
            this.DateTime.CustomFormat = "dd/MM/yyyy";
            this.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTime.Location = new System.Drawing.Point(702, 96);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(261, 27);
            this.DateTime.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Khách hàng:";
            // 
            // tbSoPhieu
            // 
            this.tbSoPhieu.Location = new System.Drawing.Point(110, 98);
            this.tbSoPhieu.Name = "tbSoPhieu";
            this.tbSoPhieu.Size = new System.Drawing.Size(304, 27);
            this.tbSoPhieu.TabIndex = 13;
            // 
            // lbsophieu
            // 
            this.lbsophieu.AutoSize = true;
            this.lbsophieu.Location = new System.Drawing.Point(34, 105);
            this.lbsophieu.Name = "lbsophieu";
            this.lbsophieu.Size = new System.Drawing.Size(70, 20);
            this.lbsophieu.TabIndex = 12;
            this.lbsophieu.Text = "Số phiếu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(358, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "PHIẾU DỊCH VỤ";
            // 
            // tbKhachHang
            // 
            this.tbKhachHang.Location = new System.Drawing.Point(110, 151);
            this.tbKhachHang.Name = "tbKhachHang";
            this.tbKhachHang.Size = new System.Drawing.Size(304, 27);
            this.tbKhachHang.TabIndex = 23;
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(110, 202);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(165, 27);
            this.tbTongTien.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tổng Tiền:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(461, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 27);
            this.textBox1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tổng tiền trả trước:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(798, 202);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 27);
            this.textBox2.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tổng Tiền còn lại:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stt,
            this.LoaiDichVu,
            this.DonGiaDV,
            this.DonGiaDuocTinh,
            this.SoLuong,
            this.ThanhTien,
            this.ThanhToan,
            this.NgayGiao,
            this.TinhTrang});
            this.dataGridView1.Location = new System.Drawing.Point(12, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 281);
            this.dataGridView1.TabIndex = 30;
            // 
            // Stt
            // 
            this.Stt.HeaderText = "STT";
            this.Stt.MinimumWidth = 6;
            this.Stt.Name = "Stt";
            this.Stt.Width = 50;
            // 
            // LoaiDichVu
            // 
            this.LoaiDichVu.HeaderText = "Loại Dịch Vụ";
            this.LoaiDichVu.MinimumWidth = 6;
            this.LoaiDichVu.Name = "LoaiDichVu";
            this.LoaiDichVu.Width = 125;
            // 
            // DonGiaDV
            // 
            this.DonGiaDV.HeaderText = "Đơn Giá Dịch Vụ";
            this.DonGiaDV.MinimumWidth = 6;
            this.DonGiaDV.Name = "DonGiaDV";
            this.DonGiaDV.Width = 125;
            // 
            // DonGiaDuocTinh
            // 
            this.DonGiaDuocTinh.HeaderText = "Đơn Giá Được Tính";
            this.DonGiaDuocTinh.MinimumWidth = 6;
            this.DonGiaDuocTinh.Name = "DonGiaDuocTinh";
            this.DonGiaDuocTinh.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 50;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 125;
            // 
            // ThanhToan
            // 
            this.ThanhToan.HeaderText = "Thanh Toán";
            this.ThanhToan.MinimumWidth = 6;
            this.ThanhToan.Name = "ThanhToan";
            this.ThanhToan.Width = 125;
            // 
            // NgayGiao
            // 
            this.NgayGiao.HeaderText = "Ngày Giao";
            this.NgayGiao.MinimumWidth = 6;
            this.NgayGiao.Name = "NgayGiao";
            this.NgayGiao.Width = 125;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 125;
            // 
            // btnInPhieuDichVu
            // 
            this.btnInPhieuDichVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInPhieuDichVu.Location = new System.Drawing.Point(950, 534);
            this.btnInPhieuDichVu.Name = "btnInPhieuDichVu";
            this.btnInPhieuDichVu.Size = new System.Drawing.Size(84, 35);
            this.btnInPhieuDichVu.TabIndex = 31;
            this.btnInPhieuDichVu.Text = "In";
            this.btnInPhieuDichVu.UseVisualStyleBackColor = true;
            // 
            // FormDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 580);
            this.Controls.Add(this.btnInPhieuDichVu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSoDienThoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSoPhieu);
            this.Controls.Add(this.lbsophieu);
            this.Name = "FormDichVu";
            this.Text = "Phiếu dịch vụ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbSoDienThoai;
        private Label label5;
        private DateTimePicker DateTime;
        private Label label3;
        private Label label2;
        private TextBox tbSoPhieu;
        private Label lbsophieu;
        private Label label1;
        private TextBox tbKhachHang;
        private TextBox tbTongTien;
        private Label label4;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Stt;
        private DataGridViewTextBoxColumn LoaiDichVu;
        private DataGridViewTextBoxColumn DonGiaDV;
        private DataGridViewTextBoxColumn DonGiaDuocTinh;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn ThanhToan;
        private DataGridViewTextBoxColumn NgayGiao;
        private DataGridViewTextBoxColumn TinhTrang;
        private Button btnInPhieuDichVu;
    }
}