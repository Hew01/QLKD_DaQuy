namespace NewProject
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
            this.label9 = new System.Windows.Forms.Label();
            this.tbSoDienThoai = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TBSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBLoaiDV = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.tbSoPhieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKhachHang = new System.Windows.Forms.TextBox();
            this.tbTongTraTruoc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTongConLai = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtNgayGiao = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaDuocTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInPhieuDichVu = new System.Windows.Forms.Button();
            this.TBTraTruoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(367, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(353, 49);
            this.label9.TabIndex = 23;
            this.label9.Text = "PHIẾU DỊCH VỤ";
            // 
            // tbSoDienThoai
            // 
            this.tbSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoDienThoai.Location = new System.Drawing.Point(600, 161);
            this.tbSoDienThoai.Name = "tbSoDienThoai";
            this.tbSoDienThoai.Size = new System.Drawing.Size(274, 27);
            this.tbSoDienThoai.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(493, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 51;
            this.label11.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(507, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Trả trước:";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(250, 383);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(62, 31);
            this.BtnEdit.TabIndex = 48;
            this.BtnEdit.Text = "Sửa";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(168, 383);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(62, 31);
            this.BtnDelete.TabIndex = 47;
            this.BtnDelete.Text = "Xóa";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(92, 383);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(62, 31);
            this.BtnAdd.TabIndex = 46;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TBSoLuong
            // 
            this.TBSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSoLuong.Location = new System.Drawing.Point(139, 336);
            this.TBSoLuong.Name = "TBSoLuong";
            this.TBSoLuong.Size = new System.Drawing.Size(69, 27);
            this.TBSoLuong.TabIndex = 45;
            this.TBSoLuong.TextChanged += new System.EventHandler(this.TBSoLuong_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Số lượng:";
            // 
            // CBLoaiDV
            // 
            this.CBLoaiDV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBLoaiDV.FormattingEnabled = true;
            this.CBLoaiDV.Location = new System.Drawing.Point(138, 294);
            this.CBLoaiDV.Name = "CBLoaiDV";
            this.CBLoaiDV.Size = new System.Drawing.Size(285, 27);
            this.CBLoaiDV.TabIndex = 43;
            this.CBLoaiDV.SelectedIndexChanged += new System.EventHandler(this.CBLoaiDV_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Loại dịch vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 23);
            this.label7.TabIndex = 41;
            this.label7.Text = "Thông tin dịch vụ";
            // 
            // DateTime
            // 
            this.DateTime.CustomFormat = "dd/MM/yyyy";
            this.DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTime.Location = new System.Drawing.Point(600, 125);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(274, 27);
            this.DateTime.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(521, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ngày lập:";
            // 
            // tbTongTien
            // 
            this.tbTongTien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongTien.Location = new System.Drawing.Point(138, 196);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.ReadOnly = true;
            this.tbTongTien.Size = new System.Drawing.Size(165, 27);
            this.tbTongTien.TabIndex = 38;
            // 
            // tbSoPhieu
            // 
            this.tbSoPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoPhieu.Location = new System.Drawing.Point(138, 121);
            this.tbSoPhieu.Name = "tbSoPhieu";
            this.tbSoPhieu.Size = new System.Drawing.Size(283, 27);
            this.tbSoPhieu.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Tổng Tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Số phiếu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Thông tin khách hàng";
            // 
            // tbKhachHang
            // 
            this.tbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKhachHang.Location = new System.Drawing.Point(138, 160);
            this.tbKhachHang.Name = "tbKhachHang";
            this.tbKhachHang.Size = new System.Drawing.Size(283, 27);
            this.tbKhachHang.TabIndex = 53;
            // 
            // tbTongTraTruoc
            // 
            this.tbTongTraTruoc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbTongTraTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongTraTruoc.Location = new System.Drawing.Point(474, 196);
            this.tbTongTraTruoc.Name = "tbTongTraTruoc";
            this.tbTongTraTruoc.ReadOnly = true;
            this.tbTongTraTruoc.Size = new System.Drawing.Size(165, 27);
            this.tbTongTraTruoc.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(332, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 20);
            this.label12.TabIndex = 54;
            this.label12.Text = "Tổng tiền trả trước:";
            // 
            // tbTongConLai
            // 
            this.tbTongConLai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbTongConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongConLai.Location = new System.Drawing.Point(804, 196);
            this.tbTongConLai.Name = "tbTongConLai";
            this.tbTongConLai.ReadOnly = true;
            this.tbTongConLai.Size = new System.Drawing.Size(165, 27);
            this.tbTongConLai.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(672, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 20);
            this.label13.TabIndex = 56;
            this.label13.Text = "Tổng Tiền còn lại:";
            // 
            // dtNgayGiao
            // 
            this.dtNgayGiao.CustomFormat = "dd/MM/yyyy";
            this.dtNgayGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayGiao.Location = new System.Drawing.Point(589, 334);
            this.dtNgayGiao.Name = "dtNgayGiao";
            this.dtNgayGiao.Size = new System.Drawing.Size(285, 27);
            this.dtNgayGiao.TabIndex = 59;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(497, 336);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 20);
            this.label14.TabIndex = 58;
            this.label14.Text = "Ngày giao:";
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
            this.TraTruoc,
            this.ConLai,
            this.NgayGiao,
            this.TinhTrang});
            this.dataGridView1.Location = new System.Drawing.Point(50, 434);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 230);
            this.dataGridView1.TabIndex = 60;
            // 
            // Stt
            // 
            this.Stt.HeaderText = "STT";
            this.Stt.MinimumWidth = 6;
            this.Stt.Name = "Stt";
            this.Stt.ReadOnly = true;
            this.Stt.Width = 50;
            // 
            // LoaiDichVu
            // 
            this.LoaiDichVu.HeaderText = "Loại Dịch Vụ";
            this.LoaiDichVu.MinimumWidth = 6;
            this.LoaiDichVu.Name = "LoaiDichVu";
            this.LoaiDichVu.ReadOnly = true;
            this.LoaiDichVu.Width = 125;
            // 
            // DonGiaDV
            // 
            this.DonGiaDV.HeaderText = "Đơn giá dịch vụ";
            this.DonGiaDV.MinimumWidth = 6;
            this.DonGiaDV.Name = "DonGiaDV";
            this.DonGiaDV.ReadOnly = true;
            this.DonGiaDV.Width = 125;
            // 
            // DonGiaDuocTinh
            // 
            this.DonGiaDuocTinh.HeaderText = "Đơn Giá Được Tính";
            this.DonGiaDuocTinh.MinimumWidth = 6;
            this.DonGiaDuocTinh.Name = "DonGiaDuocTinh";
            this.DonGiaDuocTinh.ReadOnly = true;
            this.DonGiaDuocTinh.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 50;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 125;
            // 
            // TraTruoc
            // 
            this.TraTruoc.HeaderText = "Trả Trước";
            this.TraTruoc.MinimumWidth = 6;
            this.TraTruoc.Name = "TraTruoc";
            this.TraTruoc.ReadOnly = true;
            this.TraTruoc.Width = 125;
            // 
            // ConLai
            // 
            this.ConLai.HeaderText = "Còn Lại";
            this.ConLai.MinimumWidth = 6;
            this.ConLai.Name = "ConLai";
            this.ConLai.ReadOnly = true;
            this.ConLai.Width = 125;
            // 
            // NgayGiao
            // 
            this.NgayGiao.HeaderText = "Ngày Giao";
            this.NgayGiao.MinimumWidth = 6;
            this.NgayGiao.Name = "NgayGiao";
            this.NgayGiao.ReadOnly = true;
            this.NgayGiao.Width = 125;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            this.TinhTrang.Width = 125;
            // 
            // btnInPhieuDichVu
            // 
            this.btnInPhieuDichVu.Location = new System.Drawing.Point(938, 682);
            this.btnInPhieuDichVu.Name = "btnInPhieuDichVu";
            this.btnInPhieuDichVu.Size = new System.Drawing.Size(70, 26);
            this.btnInPhieuDichVu.TabIndex = 61;
            this.btnInPhieuDichVu.Text = "In";
            this.btnInPhieuDichVu.UseVisualStyleBackColor = true;
            // 
            // TBTraTruoc
            // 
            this.TBTraTruoc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBTraTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTraTruoc.Location = new System.Drawing.Point(589, 296);
            this.TBTraTruoc.Name = "TBTraTruoc";
            this.TBTraTruoc.ReadOnly = true;
            this.TBTraTruoc.Size = new System.Drawing.Size(285, 27);
            this.TBTraTruoc.TabIndex = 57;
            this.TBTraTruoc.TextChanged += new System.EventHandler(this.TBTraTruoc_TextChanged);
            // 
            // FormDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 728);
            this.Controls.Add(this.btnInPhieuDichVu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtNgayGiao);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TBTraTruoc);
            this.Controls.Add(this.tbTongConLai);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbTongTraTruoc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbKhachHang);
            this.Controls.Add(this.tbSoDienThoai);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TBSoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBLoaiDV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTongTien);
            this.Controls.Add(this.tbSoPhieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Name = "FormDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDichVu";
            this.Load += new System.EventHandler(this.FormDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSoDienThoai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TBSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBLoaiDV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.TextBox tbSoPhieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKhachHang;
        private System.Windows.Forms.TextBox tbTongTraTruoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbTongConLai;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtNgayGiao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaDuocTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.Button btnInPhieuDichVu;
        private System.Windows.Forms.TextBox TBTraTruoc;
    }
}