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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loaisanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_IDPhieu = new System.Windows.Forms.TextBox();
            this.TB_NameKH = new System.Windows.Forms.TextBox();
            this.TBDate = new System.Windows.Forms.TextBox();
            this.TxbGhiChu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LbSumMoney = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TBSoLuong = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.CBLoaiSP = new System.Windows.Forms.ComboBox();
            this.CBSanPham = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Loaisanpham,
            this.Sanpham,
            this.SoLuong,
            this.DonViTinh,
            this.DonGia,
            this.ThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(47, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(885, 273);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // Loaisanpham
            // 
            this.Loaisanpham.HeaderText = "Loại sản phẩm";
            this.Loaisanpham.MinimumWidth = 6;
            this.Loaisanpham.Name = "Loaisanpham";
            this.Loaisanpham.ReadOnly = true;
            this.Loaisanpham.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Loaisanpham.Width = 150;
            // 
            // Sanpham
            // 
            this.Sanpham.HeaderText = "Sản phẩm";
            this.Sanpham.MinimumWidth = 6;
            this.Sanpham.Name = "Sanpham";
            this.Sanpham.ReadOnly = true;
            this.Sanpham.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sanpham.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 125;
            // 
            // DonViTinh
            // 
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            this.DonViTinh.Width = 75;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 125;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(831, 721);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(105, 38);
            this.btnInHoaDon.TabIndex = 11;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(361, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU BÁN HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phiếu xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày lập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ghi chú";
            // 
            // TB_IDPhieu
            // 
            this.TB_IDPhieu.Location = new System.Drawing.Point(170, 93);
            this.TB_IDPhieu.Name = "TB_IDPhieu";
            this.TB_IDPhieu.Size = new System.Drawing.Size(321, 27);
            this.TB_IDPhieu.TabIndex = 0;
            // 
            // TB_NameKH
            // 
            this.TB_NameKH.Location = new System.Drawing.Point(170, 133);
            this.TB_NameKH.Name = "TB_NameKH";
            this.TB_NameKH.Size = new System.Drawing.Size(321, 27);
            this.TB_NameKH.TabIndex = 13;
            // 
            // TBDate
            // 
            this.TBDate.Location = new System.Drawing.Point(170, 170);
            this.TBDate.Name = "TBDate";
            this.TBDate.Size = new System.Drawing.Size(321, 27);
            this.TBDate.TabIndex = 13;
            // 
            // TxbGhiChu
            // 
            this.TxbGhiChu.Location = new System.Drawing.Point(612, 93);
            this.TxbGhiChu.Multiline = true;
            this.TxbGhiChu.Name = "TxbGhiChu";
            this.TxbGhiChu.Size = new System.Drawing.Size(320, 104);
            this.TxbGhiChu.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 730);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tổng tiền:";
            // 
            // LbSumMoney
            // 
            this.LbSumMoney.AutoSize = true;
            this.LbSumMoney.Location = new System.Drawing.Point(708, 730);
            this.LbSumMoney.Name = "LbSumMoney";
            this.LbSumMoney.Size = new System.Drawing.Size(56, 20);
            this.LbSumMoney.TabIndex = 15;
            this.LbSumMoney.Text = "0 đồng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(47, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Thông tin khách hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(47, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Thông tin sản phẩm mua:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Loại sản phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Sản phẩm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(96, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Số lượng";
            // 
            // TBSoLuong
            // 
            this.TBSoLuong.Location = new System.Drawing.Point(168, 341);
            this.TBSoLuong.Name = "TBSoLuong";
            this.TBSoLuong.Size = new System.Drawing.Size(321, 27);
            this.TBSoLuong.TabIndex = 13;
            this.TBSoLuong.TextChanged += new System.EventHandler(this.TBSoLuong_TextChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(556, 312);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 29);
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(656, 312);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(94, 29);
            this.BtnDelete.TabIndex = 17;
            this.BtnDelete.Text = "Xóa";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(756, 312);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(94, 29);
            this.BtnEdit.TabIndex = 17;
            this.BtnEdit.Text = "Sửa";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // CBLoaiSP
            // 
            this.CBLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLoaiSP.FormattingEnabled = true;
            this.CBLoaiSP.Items.AddRange(new object[] {
            "a",
            "b"});
            this.CBLoaiSP.Location = new System.Drawing.Point(171, 272);
            this.CBLoaiSP.Name = "CBLoaiSP";
            this.CBLoaiSP.Size = new System.Drawing.Size(318, 28);
            this.CBLoaiSP.TabIndex = 18;
            this.CBLoaiSP.SelectedIndexChanged += new System.EventHandler(this.CBLoaiSP_SelectedIndexChanged);
            // 
            // CBSanPham
            // 
            this.CBSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSanPham.FormattingEnabled = true;
            this.CBSanPham.Items.AddRange(new object[] {
            "a",
            "b"});
            this.CBSanPham.Location = new System.Drawing.Point(171, 307);
            this.CBSanPham.Name = "CBSanPham";
            this.CBSanPham.Size = new System.Drawing.Size(318, 28);
            this.CBSanPham.TabIndex = 18;
            this.CBSanPham.SelectedIndexChanged += new System.EventHandler(this.CBSanPham_SelectedIndexChanged);
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 784);
            this.Controls.Add(this.CBSanPham);
            this.Controls.Add(this.CBLoaiSP);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LbSumMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxbGhiChu);
            this.Controls.Add(this.TBSoLuong);
            this.Controls.Add(this.TBDate);
            this.Controls.Add(this.TB_NameKH);
            this.Controls.Add(this.TB_IDPhieu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormBanHang";
            this.Text = "Lập Hóa Đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private Button btnInHoaDon;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private TextBox TB_IDPhieu;
        private TextBox TB_NameKH;
        private TextBox TBDate;
        private TextBox TxbGhiChu;
        private Label label5;
        private Label LbSumMoney;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Loaisanpham;
        private DataGridViewTextBoxColumn Sanpham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonViTinh;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox TBSoLuong;
        private Button BtnAdd;
        private Button BtnDelete;
        private Button BtnEdit;
        private ComboBox CBLoaiSP;
        private ComboBox CBSanPham;
    }
}