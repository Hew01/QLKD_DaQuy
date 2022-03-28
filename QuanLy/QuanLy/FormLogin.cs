namespace QuanLy
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;
           //if (ListAccount.Instance.IsValidAccount(username, password))
            {
                MessageBox.Show("Successfully logged in!");
                this.Hide();
                FormManager formManager = new FormManager();
                formManager.FormClosed += (s, args) => this.Close();
                formManager.ShowDialog();
            }
            //else
            MessageBox.Show("Wrong username or password");
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Notification!!!!!!!", MessageBoxButtons.OKCancel) != DialogResult.OK)
            { 
                e.Cancel = true;
            }
        }

        private void txbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txbPassword.Focus();
        }

        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ButtonLogin_Click(sender, e);
        }
    }
}