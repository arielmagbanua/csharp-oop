using TodoApp.Data;

namespace TodoApp.Screens
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var firstName = txtFirstName.Text;
            var lastName = txtLastName.Text;
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            var confirmPassword = txtConfirmPassword.Text;

            if (!password.Equals(confirmPassword)) {
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                MessageBox.Show("The password does not match", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (email.Equals("")) {
                MessageBox.Show("Email is required.", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newUser = new User();
            newUser.FirstName = firstName;
            newUser.LastName = lastName;
            newUser.Email = email;
            newUser.Password = password;

            var insertedUser = DBHelper.Instance.CreateUser(newUser);

            if (insertedUser == null) {
                MessageBox.Show("User failed to create.", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("You have successfully registed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // restore the login form
            var loginForm = this.Tag as Login;
            loginForm!.Show();

            // close the signup form
            this.Close();
        }
    }
}
