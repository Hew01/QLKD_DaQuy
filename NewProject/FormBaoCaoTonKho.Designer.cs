namespace NewProject
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "BÁO CÁO TỒN KHO";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(140, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 27);
            this.textBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tháng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SanPham,
            this.TonDau,
            this.SoLuongMuaVao,
            this.SoLuongBanRa,
            this.TonCuoi,
            this.DonViTinh});
            this.dataGridView1.Location = new System.Drawing.Point(110, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(746, 282);
            this.dataGridView1.TabIndex = 10;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 125;
            // 
            // SanPham
            // 
            this.SanPham.HeaderText = "Sản Phẩm";
            this.SanPham.MinimumWidth = 6;
            this.SanPham.Name = "SanPham";
            this.SanPham.Width = 125;
            // 
            // TonDau
            // 
            this.TonDau.HeaderText = "Tồn Đầu";
            this.TonDau.MinimumWidth = 6;
            this.TonDau.Name = "TonDau";
            this.TonDau.Width = 125;
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
            this.btnInBaoCaoTonKho.Location = new System.Drawing.Point(754, 461);
            this.btnInBaoCaoTonKho.Name = "btnInBaoCaoTonKho";
            this.btnInBaoCaoTonKho.Size = new System.Drawing.Size(101, 28);
            this.btnInBaoCaoTonKho.TabIndex = 11;
            this.btnInBaoCaoTonKho.Text = "In";
            this.btnInBaoCaoTonKho.UseVisualStyleBackColor = true;
            // 
            // FormBaoCaoTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 505);
            this.Controls.Add(this.btnInBaoCaoTonKho);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FormBaoCaoTonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Tồn Kho";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongMuaVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongBanRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonCuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.Button btnInBaoCaoTonKho;
    }
}