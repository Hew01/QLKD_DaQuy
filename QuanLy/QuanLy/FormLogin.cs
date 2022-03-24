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
            FormManager formManager = new FormManager();
            this.Hide();
            formManager.ShowDialog();
            Application.Exit();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Notification!!!!!!!", MessageBoxButtons.OKCancel) != DialogResult.OK)
            { 
                e.Cancel = true;
            }
        }
    }
}