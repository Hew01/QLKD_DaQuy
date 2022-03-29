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
            this.tbTongTraTruoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTongConLai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CBLoaiDV = new System.Windows.Forms.ComboBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TBSoLuong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TBTraTruoc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtNgayGiao = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSoDienThoai
            // 
            this.tbSoDienThoai.Location = new System.Drawing.Point(649, 148);
            this.tbSoDienThoai.Name = "tbSoDienThoai";
            this.tbSoDienThoai.Size = new System.Drawing.Size(261, 27);
            this.tbSoDienThoai.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Số điện thoại:";
            // 
            // DateTime
            // 
            this.DateTime.CustomFormat = "dd/MM/yyyy";
            this.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTime.Location = new System.Drawing.Point(649, 113);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(261, 27);
            this.DateTime.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Khách hàng:";
            // 
            // tbSoPhieu
            // 
            this.tbSoPhieu.Location = new System.Drawing.Point(139, 113);
            this.tbSoPhieu.Name = "tbSoPhieu";
            this.tbSoPhieu.Size = new System.Drawing.Size(304, 27);
            this.tbSoPhieu.TabIndex = 13;
            // 
            // lbsophieu
            // 
            this.lbsophieu.AutoSize = true;
            this.lbsophieu.Location = new System.Drawing.Point(63, 120);
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
            this.label1.Size = new System.Drawing.Size(271, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "PHIẾU DỊCH VỤ";
            // 
            // tbKhachHang
            // 
            this.tbKhachHang.Location = new System.Drawing.Point(139, 151);
            this.tbKhachHang.Name = "tbKhachHang";
            this.tbKhachHang.Size = new System.Drawing.Size(304, 27);
            this.tbKhachHang.TabIndex = 23;
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(139, 184);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(165, 27);
            this.tbTongTien.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tổng Tiền:";
            // 
            // tbTongTraTruoc
            // 
            this.tbTongTraTruoc.Location = new System.Drawing.Point(471, 184);
            this.tbTongTraTruoc.Name = "tbTongTraTruoc";
            this.tbTongTraTruoc.Size = new System.Drawing.Size(165, 27);
            this.tbTongTraTruoc.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tổng tiền trả trước:";
            // 
            // tbTongConLai
            // 
            this.tbTongConLai.Location = new System.Drawing.Point(805, 184);
            this.tbTongConLai.Name = "tbTongConLai";
            this.tbTongConLai.Size = new System.Drawing.Size(165, 27);
            this.tbTongConLai.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 191);
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
            this.TraTruoc,
            this.ConLai,
            this.NgayGiao,
            this.TinhTrang});
            this.dataGridView1.Location = new System.Drawing.Point(12, 441);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 281);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnWidthChanged);
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
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
            this.DonGiaDV.HeaderText = "Đơn Giá Dịch Vụ";
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
            this.ConLai.HeaderText = "Còn lại";
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
            this.btnInPhieuDichVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInPhieuDichVu.Location = new System.Drawing.Point(950, 728);
            this.btnInPhieuDichVu.Name = "btnInPhieuDichVu";
            this.btnInPhieuDichVu.Size = new System.Drawing.Size(84, 35);
            this.btnInPhieuDichVu.TabIndex = 31;
            this.btnInPhieuDichVu.Text = "In";
            this.btnInPhieuDichVu.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "Thông tin khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(15, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "Thông tin dịch vụ";
            // 
            // CBLoaiDV
            // 
            this.CBLoaiDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLoaiDV.FormattingEnabled = true;
            this.CBLoaiDV.Items.AddRange(new object[] {
            "a",
            "b"});
            this.CBLoaiDV.Location = new System.Drawing.Point(139, 300);
            this.CBLoaiDV.Name = "CBLoaiDV";
            this.CBLoaiDV.Size = new System.Drawing.Size(318, 28);
            this.CBLoaiDV.TabIndex = 41;
            this.CBLoaiDV.SelectedIndexChanged += new System.EventHandler(this.CBLoaiDV_SelectedIndexChanged);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(236, 378);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(94, 29);
            this.BtnEdit.TabIndex = 37;
            this.BtnEdit.Text = "Sửa";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(136, 378);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(94, 29);
            this.BtnDelete.TabIndex = 38;
            this.BtnDelete.Text = "Xóa";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(36, 378);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 29);
            this.BtnAdd.TabIndex = 39;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TBSoLuong
            // 
            this.TBSoLuong.Location = new System.Drawing.Point(136, 334);
            this.TBSoLuong.Name = "TBSoLuong";
            this.TBSoLuong.Size = new System.Drawing.Size(321, 27);
            this.TBSoLuong.TabIndex = 36;
            this.TBSoLuong.TextChanged += new System.EventHandler(this.TBSoLuong_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Số lượng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 33;
            this.label12.Text = "Loại dịch vụ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(577, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Trả trước";
            // 
            // TBTraTruoc
            // 
            this.TBTraTruoc.Location = new System.Drawing.Point(649, 303);
            this.TBTraTruoc.Name = "TBTraTruoc";
            this.TBTraTruoc.Size = new System.Drawing.Size(321, 27);
            this.TBTraTruoc.TabIndex = 36;
            this.TBTraTruoc.TextChanged += new System.EventHandler(this.TBTraTruoc_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(562, 341);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Ngày giao:";
            // 
            // dtNgayGiao
            // 
            this.dtNgayGiao.CustomFormat = "dd/MM/yyyy";
            this.dtNgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayGiao.Location = new System.Drawing.Point(649, 337);
            this.dtNgayGiao.Name = "dtNgayGiao";
            this.dtNgayGiao.Size = new System.Drawing.Size(261, 27);
            this.dtNgayGiao.TabIndex = 16;
            // 
            // FormDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 782);
            this.Controls.Add(this.CBLoaiDV);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TBTraTruoc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TBSoLuong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnInPhieuDichVu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbTongConLai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTongTraTruoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSoDienThoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtNgayGiao);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSoPhieu);
            this.Controls.Add(this.lbsophieu);
            this.Name = "FormDichVu";
            this.Text = "Phiếu dịch vụ";
            this.Load += new System.EventHandler(this.FormDichVu_Load);
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
        private TextBox tbTongTraTruoc;
        private Label label6;
        private TextBox tbTongConLai;
        private Label label7;
        private DataGridView dataGridView1;
        private Button btnInPhieuDichVu;
        private DataGridViewTextBoxColumn Stt;
        private DataGridViewTextBoxColumn LoaiDichVu;
        private DataGridViewTextBoxColumn DonGiaDV;
        private DataGridViewTextBoxColumn DonGiaDuocTinh;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn TraTruoc;
        private DataGridViewTextBoxColumn ConLai;
        private DataGridViewTextBoxColumn NgayGiao;
        private DataGridViewTextBoxColumn TinhTrang;
        private Label label8;
        private Label label9;
        private ComboBox CBLoaiDV;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnAdd;
        private TextBox TBSoLuong;
        private Label label11;
        private Label label12;
        private Label label10;
        private TextBox TBTraTruoc;
        private Label label13;
        private DateTimePicker dtNgayGiao;
    }
}