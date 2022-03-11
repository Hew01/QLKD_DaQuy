namespace QuanLy
{
    partial class FormDanhSachPhieuDichVu
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(280, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH PHIẾU DỊCH VỤ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SoPhieu,
            this.KhachHang,
            this.TongTien,
            this.TraTruoc,
            this.ConLai,
            this.TinhTrang});
            this.dataGridView1.Location = new System.Drawing.Point(31, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(928, 329);
            this.dataGridView1.TabIndex = 1;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 125;
            // 
            // SoPhieu
            // 
            this.SoPhieu.HeaderText = "Số Phiếu";
            this.SoPhieu.MinimumWidth = 6;
            this.SoPhieu.Name = "SoPhieu";
            this.SoPhieu.Width = 125;
            // 
            // KhachHang
            // 
            this.KhachHang.HeaderText = "Khách Hàng";
            this.KhachHang.MinimumWidth = 6;
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.Width = 125;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 125;
            // 
            // TraTruoc
            // 
            this.TraTruoc.HeaderText = "Trả Trước";
            this.TraTruoc.MinimumWidth = 6;
            this.TraTruoc.Name = "TraTruoc";
            this.TraTruoc.Width = 125;
            // 
            // ConLai
            // 
            this.ConLai.HeaderText = "Còn Lại";
            this.ConLai.MinimumWidth = 6;
            this.ConLai.Name = "ConLai";
            this.ConLai.Width = 125;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 125;
            // 
            // FormDanhSachPhieuDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 476);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormDanhSachPhieuDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH PHIẾU DỊCH VỤ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn SoPhieu;
        private DataGridViewTextBoxColumn KhachHang;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn TraTruoc;
        private DataGridViewTextBoxColumn ConLai;
        private DataGridViewTextBoxColumn TinhTrang;
    }
}