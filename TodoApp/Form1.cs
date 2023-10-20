namespace TodoApp
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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}