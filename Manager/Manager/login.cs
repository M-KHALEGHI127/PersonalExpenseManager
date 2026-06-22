namespace Manager
{

    public partial class loginform : Form
    {

        public loginform()
        {
            InitializeComponent();

        }

        private void boxpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "1234";

            if (
                boxuser.Text == username && boxpass.Text == password
            )
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(".نام کاربری یا رمزعبور نادرست است", "!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void boxuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
