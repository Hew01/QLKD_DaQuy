namespace NewProject
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBLoaiSP = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBSoLuong = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TB_NameKH = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CBSanPham = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TBDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_IDPhieu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LbSumMoney = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày xuất phiếu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Khách Hàng:";
            // 
            // TxbGhiChu
            // 
            this.TxbGhiChu.Location = new System.Drawing.Point(717, 78);
            this.TxbGhiChu.Multiline = true;
            this.TxbGhiChu.Name = "TxbGhiChu";
            this.TxbGhiChu.Size = new System.Drawing.Size(258, 95);
            this.TxbGhiChu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(644, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ghi chú:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Loại Sản phẩm:";
            // 
            // CBLoaiSP
            // 
            this.CBLoaiSP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBLoaiSP.FormattingEnabled = true;
            this.CBLoaiSP.Items.AddRange(new object[] {
            "a",
            "b"});
            this.CBLoaiSP.Location = new System.Drawing.Point(290, 208);
            this.CBLoaiSP.Name = "CBLoaiSP";
            this.CBLoaiSP.Size = new System.Drawing.Size(285, 27);
            this.CBLoaiSP.TabIndex = 8;
            this.CBLoaiSP.SelectedIndexChanged += new System.EventHandler(this.CBLoaiSP_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(209, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số lượng:";
            // 
            // TBSoLuong
            // 
            this.TBSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSoLuong.Location = new System.Drawing.Point(290, 274);
            this.TBSoLuong.Name = "TBSoLuong";
            this.TBSoLuong.Size = new System.Drawing.Size(75, 27);
            this.TBSoLuong.TabIndex = 10;
            this.TBSoLuong.TextChanged += new System.EventHandler(this.TBSoLuong_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.LoaiSanPham,
            this.SanPham,
            this.SoLuong,
            this.DonViTinh,
            this.DonGia,
            this.ThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(186, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(817, 221);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 50;
            // 
            // LoaiSanPham
            // 
            this.LoaiSanPham.HeaderText = "Loại Sản Phẩm";
            this.LoaiSanPham.MinimumWidth = 6;
            this.LoaiSanPham.Name = "LoaiSanPham";
            this.LoaiSanPham.ReadOnly = true;
            this.LoaiSanPham.Width = 150;
            // 
            // SanPham
            // 
            this.SanPham.HeaderText = "Sản Phẩm";
            this.SanPham.MinimumWidth = 6;
            this.SanPham.Name = "SanPham";
            this.SanPham.ReadOnly = true;
            this.SanPham.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 75;
            // 
            // DonViTinh
            // 
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            this.DonViTinh.Width = 75;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 125;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(717, 244);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(62, 31);
            this.BtnAdd.TabIndex = 12;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TB_NameKH
            // 
            this.TB_NameKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NameKH.Location = new System.Drawing.Point(290, 110);
            this.TB_NameKH.Name = "TB_NameKH";
            this.TB_NameKH.Size = new System.Drawing.Size(285, 27);
            this.TB_NameKH.TabIndex = 13;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(793, 244);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(62, 31);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.Text = "Xóa";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(869, 244);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(62, 31);
            this.BtnEdit.TabIndex = 15;
            this.BtnEdit.Text = "Sửa";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(935, 529);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(70, 35);
            this.btnIn.TabIndex = 16;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(702, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tổng Tiền:";
            // 
            // CBSanPham
            // 
            this.CBSanPham.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSanPham.FormattingEnabled = true;
            this.CBSanPham.Items.AddRange(new object[] {
            "a",
            "b"});
            this.CBSanPham.Location = new System.Drawing.Point(290, 241);
            this.CBSanPham.Name = "CBSanPham";
            this.CBSanPham.Size = new System.Drawing.Size(285, 27);
            this.CBSanPham.TabIndex = 20;
            this.CBSanPham.SelectedIndexChanged += new System.EventHandler(this.CBSanPham_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(203, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sản phẩm:";
            // 
            // TBDate
            // 
            this.TBDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDate.Location = new System.Drawing.Point(290, 146);
            this.TBDate.Name = "TBDate";
            this.TBDate.Size = new System.Drawing.Size(285, 27);
            this.TBDate.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(424, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(354, 43);
            this.label9.TabIndex = 22;
            this.label9.Text = "PHIẾU BÁN HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số phiếu xuất:";
            // 
            // TB_IDPhieu
            // 
            this.TB_IDPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_IDPhieu.Location = new System.Drawing.Point(290, 75);
            this.TB_IDPhieu.Name = "TB_IDPhieu";
            this.TB_IDPhieu.Size = new System.Drawing.Size(285, 27);
            this.TB_IDPhieu.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(130, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "Thông tin khách hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(130, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 23);
            this.label11.TabIndex = 23;
            this.label11.Text = "Thông tin sản phẩm mua";
            // 
            // LbSumMoney
            // 
            this.LbSumMoney.AutoSize = true;
            this.LbSumMoney.Location = new System.Drawing.Point(831, 538);
            this.LbSumMoney.Name = "LbSumMoney";
            this.LbSumMoney.Size = new System.Drawing.Size(52, 17);
            this.LbSumMoney.TabIndex = 24;
            this.LbSumMoney.Text = "0 đồng";
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1168, 563);
            this.Controls.Add(this.LbSumMoney);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TBDate);
            this.Controls.Add(this.CBSanPham);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TB_IDPhieu);
            this.Controls.Add(this.TB_NameKH);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TBSoLuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBLoaiSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxbGhiChu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Hóa Đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBLoaiSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBSoLuong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TB_NameKH;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBSanPham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_IDPhieu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LbSumMoney;
    }
}