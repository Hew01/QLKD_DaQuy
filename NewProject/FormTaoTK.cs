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
    public partial class FormTaoTK : Form
    {
        public FormTaoTK()
        {
            InitializeComponent();
            BtnOK.Enabled = false;
        }

        private void CheckEmpty()
        {
            if (TbUsername.Text != "" && TbPassword.Text != "" && TbRePass.Text != "")
                BtnOK.Enabled = true;
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (TbPassword.Text != TbRePass.Text)
                MessageBox.Show("Mật khẩu và mật khẩu nhập lại không trùng với nhau!", "Thông báo!");
            else
            {
                using (DB_QLKDEntities db = new DB_QLKDEntities())
                {
                    string username = TbUsername.Text;
                    string password = TbPassword.Text;
                    if (db.LOGINs.Find(username) != null)
                        MessageBox.Show("Tài khoản này đã tồn tại!", "Thông báo");
                    else
                    {
                        LOGIN lg = new LOGIN
                        {
                            USERNAME = username,
                            PWD = password,
                            ROLE = "USER"
                        };
                        db.LOGINs.Add(lg);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo");
                    this.Close();
                }
            }
        }

        private void TBTextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
