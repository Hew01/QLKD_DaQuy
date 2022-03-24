namespace QuanLy
{
    partial class FormBaoCaoTonKho
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbThang = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tondau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongMuaVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongBanRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInBaoCaoTonKho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(348, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO TỒN KHO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng:";
            // 
            // tbThang
            // 
            this.tbThang.Location = new System.Drawing.Point(150, 109);
            this.tbThang.Name = "tbThang";
            this.tbThang.Size = new System.Drawing.Size(123, 27);
            this.tbThang.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.Sanpham,
            this.tondau,
            this.SoLuongMuaVao,
            this.SoLuongBanRa,
            this.TonCuoi,
            this.DonViTinh});
            this.dataGridView1.Location = new System.Drawing.Point(95, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(855, 271);
            this.dataGridView1.TabIndex = 3;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // Sanpham
            // 
            this.Sanpham.HeaderText = "Sản Phẩm";
            this.Sanpham.MinimumWidth = 6;
            this.Sanpham.Name = "Sanpham";
            this.Sanpham.Width = 125;
            // 
            // tondau
            // 
            this.tondau.HeaderText = "Tồn Đầu";
            this.tondau.MinimumWidth = 6;
            this.tondau.Name = "tondau";
            this.tondau.Width = 125;
            // 
            // SoLuongMuaVao
            // 
            this.SoLuongMuaVao.HeaderText = "Số Lượng Mua Vào";
            this.SoLuongMuaVao.MinimumWidth = 6;
            this.SoLuongMuaVao.Name = "SoLuongMuaVao";
            this.SoLuongMuaVao.Width = 125;
            // 
            // SoLuongBanRa
            // 
            this.SoLuongBanRa.HeaderText = "Số Lượng Bán Ra";
            this.SoLuongBanRa.MinimumWidth = 6;
            this.SoLuongBanRa.Name = "SoLuongBanRa";
            this.SoLuongBanRa.Width = 125;
            // 
            // TonCuoi
            // 
            this.TonCuoi.HeaderText = "Tồn Cuối";
            this.TonCuoi.MinimumWidth = 6;
            this.TonCuoi.Name = "TonCuoi";
            this.TonCuoi.Width = 125;
            // 
            // DonViTinh
            // 
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Width = 125;
            // 
            // btnInBaoCaoTonKho
            // 
            this.btnInBaoCaoTonKho.Location = new System.Drawing.Point(752, 484);
            this.btnInBaoCaoTonKho.Name = "btnInBaoCaoTonKho";
            this.btnInBaoCaoTonKho.Size = new System.Drawing.Size(195, 43);
            this.btnInBaoCaoTonKho.TabIndex = 4;
            this.btnInBaoCaoTonKho.Text = "In Báo Cáo Tồn Kho";
            this.btnInBaoCaoTonKho.UseVisualStyleBackColor = true;
            // 
            // FormBaoCaoTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 565);
            this.Controls.Add(this.btnInBaoCaoTonKho);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBaoCaoTonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBaoCaoTonKho";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbThang;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn Sanpham;
        private DataGridViewTextBoxColumn tondau;
        private DataGridViewTextBoxColumn SoLuongMuaVao;
        private DataGridViewTextBoxColumn SoLuongBanRa;
        private DataGridViewTextBoxColumn TonCuoi;
        private DataGridViewTextBoxColumn DonViTinh;
        private Button btnInBaoCaoTonKho;
    }
}