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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TB_TenKH = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CBSanPham = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_IDPBH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LbSumMoney = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pbh_DateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày xuất phiếu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Khách Hàng:";
            // 
            // TxbGhiChu
            // 
            this.TxbGhiChu.Location = new System.Drawing.Point(466, 73);
            this.TxbGhiChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxbGhiChu.Multiline = true;
            this.TxbGhiChu.Name = "TxbGhiChu";
            this.TxbGhiChu.Size = new System.Drawing.Size(194, 78);
            this.TxbGhiChu.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ghi chú:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
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
            this.CBLoaiSP.Location = new System.Drawing.Point(146, 179);
            this.CBLoaiSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBLoaiSP.Name = "CBLoaiSP";
            this.CBLoaiSP.Size = new System.Drawing.Size(215, 24);
            this.CBLoaiSP.TabIndex = 5;
            this.CBLoaiSP.DropDown += new System.EventHandler(this.CBLoaiSP_DropDown);
            this.CBLoaiSP.SelectedIndexChanged += new System.EventHandler(this.CBLoaiSP_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số lượng:";
            // 
            // TBSoLuong
            // 
            this.TBSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSoLuong.Location = new System.Drawing.Point(146, 232);
            this.TBSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBSoLuong.Name = "TBSoLuong";
            this.TBSoLuong.Size = new System.Drawing.Size(57, 23);
            this.TBSoLuong.TabIndex = 7;
            this.TBSoLuong.TextChanged += new System.EventHandler(this.TBSoLuong_TextChanged);
            this.TBSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_IDPBH_KeyPress);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(448, 211);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(46, 25);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TB_TenKH
            // 
            this.TB_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TenKH.Location = new System.Drawing.Point(146, 99);
            this.TB_TenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_TenKH.Name = "TB_TenKH";
            this.TB_TenKH.Size = new System.Drawing.Size(215, 23);
            this.TB_TenKH.TabIndex = 2;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(506, 211);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(46, 25);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Xóa";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(562, 211);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(46, 25);
            this.BtnEdit.TabIndex = 10;
            this.BtnEdit.Text = "Sửa";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(638, 493);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(52, 28);
            this.btnIn.TabIndex = 16;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(464, 498);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
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
            this.CBSanPham.Location = new System.Drawing.Point(146, 206);
            this.CBSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBSanPham.Name = "CBSanPham";
            this.CBSanPham.Size = new System.Drawing.Size(215, 24);
            this.CBSanPham.TabIndex = 6;
            this.CBSanPham.DropDown += new System.EventHandler(this.CBSanPham_DropDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 211);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sản phẩm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(242, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(282, 35);
            this.label9.TabIndex = 22;
            this.label9.Text = "PHIẾU BÁN HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số phiếu xuất:";
            // 
            // TB_IDPBH
            // 
            this.TB_IDPBH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TB_IDPBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_IDPBH.Location = new System.Drawing.Point(146, 71);
            this.TB_IDPBH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_IDPBH.Name = "TB_IDPBH";
            this.TB_IDPBH.Size = new System.Drawing.Size(215, 23);
            this.TB_IDPBH.TabIndex = 1;
            this.TB_IDPBH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_IDPBH_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Thông tin khách hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 158);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Thông tin sản phẩm mua";
            // 
            // LbSumMoney
            // 
            this.LbSumMoney.AutoSize = true;
            this.LbSumMoney.Location = new System.Drawing.Point(560, 500);
            this.LbSumMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbSumMoney.Name = "LbSumMoney";
            this.LbSumMoney.Size = new System.Drawing.Size(41, 13);
            this.LbSumMoney.TabIndex = 24;
            this.LbSumMoney.Text = "0 đồng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(708, 191);
            this.dataGridView1.TabIndex = 25;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(615, 211);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(54, 25);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Xem";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pbh_DateTime
            // 
            this.pbh_DateTime.CustomFormat = "MM/dd/yyyy";
            this.pbh_DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbh_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pbh_DateTime.Location = new System.Drawing.Point(146, 128);
            this.pbh_DateTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbh_DateTime.Name = "pbh_DateTime";
            this.pbh_DateTime.Size = new System.Drawing.Size(215, 23);
            this.pbh_DateTime.TabIndex = 3;
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 566);
            this.Controls.Add(this.pbh_DateTime);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LbSumMoney);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CBSanPham);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TB_IDPBH);
            this.Controls.Add(this.TB_TenKH);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TBSoLuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBLoaiSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxbGhiChu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TB_TenKH;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBSanPham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_IDPBH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LbSumMoney;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DateTimePicker pbh_DateTime;
    }
}