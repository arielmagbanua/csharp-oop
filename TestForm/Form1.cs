namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // get the username and password
            var username = usernameTextBox.Text;
            var password = passwordTextBox.Text;

            if (username.Equals("arielmagbanua") && password.Equals("112233"))
            {
                // TODO: hide the login form

                // TODO: Show the success dialog

            }
        }
    }
}