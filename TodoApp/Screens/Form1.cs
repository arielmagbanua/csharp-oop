using TodoApp.Data;

namespace TodoApp.Screens
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            // instantiate and show the signup form
            var signUpForm = new SignUp();
            signUpForm.Tag = this;
            signUpForm.Show(this);

            // hide the login form
            this.Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var email = txtLoginEmail.Text;
            var password = txtLoginPassword.Text;

            var user = DBHelper.Instance.GetUserByEmail(email);
            if (user == null)
            {
                MessageBox.Show("Invalid User", "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!password.Equals(user.Password)) {
                MessageBox.Show("Invalid Credentials", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var todoScreen = new TodoScreen();
            todoScreen.Tag = this;
            todoScreen.Show(this);

            this.Hide();
        }
    }
}