using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProject
{
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.FormClosed += (s, args) => this.Close();
            formLogin.ShowDialog();
        }

        private Form CurrentChildFrom;
        private void OpenChildForm(Form ChildForm)
        {
            if(CurrentChildFrom != null)
            {
                CurrentChildFrom.Close();
            }
            CurrentChildFrom = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            PanelBody.Controls.Add(ChildForm);
            PanelBody.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnLapPhieuBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanHang());

        }

        private void btnLapPhieuMuaHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMuaHang());
        }

        private void btnLapPhieuDichVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDichVu());
        }

        private void btnBaoCaoTonKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBaoCaoTonKho());
        }

        private void btnDanhSachPhieuDichVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDanhSachPhieuDichVu());
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinTaiKhoan f=new FormThongTinTaiKhoan();
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CurrentChildFrom!=null)
            {
                CurrentChildFrom.Close();
            }
        }
    }
}
