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
        public string MainUser;
        public static FormManager instance;
        public FormManager(string username)
        {
            InitializeComponent();
            instance = this;
            LbUser.Text = username;
            MainUser = username;
            CheckUser();
        }
        private void CheckUser()
        {
            if (MainUser!="admin")
            {
                btnLapPhieuMuaHang.Enabled = false;
                tạoTàiKhoảnToolStripMenuItem1.Enabled = false;
            }
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            formLogin.FormClosed += (s, args) => this.Close();

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

        private void phiếuBánHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDanhSachPBH f = new FormDanhSachPBH();
            f.ShowDialog();
        }

        private void phiếuMuaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDanhSachPMH f = new FormDanhSachPMH();
            f.ShowDialog();
        }

        private void phiếuBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDanhSachSP f = new FormDanhSachSP(MainUser);
            f.ShowDialog();
        }

        private void tạoTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTaoTK f = new FormTaoTK();
            f.ShowDialog();
        }

        private void phiếuDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDanhSachPhieuDichVu f = new FormDanhSachPhieuDichVu();
            f.ShowDialog();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDanhSachDV f = new FormDanhSachDV(MainUser);
            f.ShowDialog();
        }
    }
}
