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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (DB_QLKDEntities db = new DB_QLKDEntities())
                {
                    string username = txtUsername.Text;
                    string pass = txtPassword.Text;
                    if (db.LOGINs.Find(username)==null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác !","Thông báo");
                    }
                    else
                    {
                        if (db.LOGINs.Where(c=>c.USERNAME==username && c.PWD==pass).Count()!=0)
                        {
                            MessageBox.Show("Đăng nhập thành công !","Thông báo");
                            DB_QLKD.currentUser = username;
                            this.Hide();
                            FormManager formManager = new FormManager();
                            formManager.FormClosed += (s, args) => this.Close();
                            formManager.ShowDialog(); 
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác !", "Thông báo");
                        }
                    } 
                }
            }
            catch (Exception )
            {
                throw;
            }
        }
       

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Notification!!!!!!!", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
