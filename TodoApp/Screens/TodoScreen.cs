using TodoApp.Data;

namespace TodoApp.Screens
{
    public partial class TodoScreen : Form
    {
        private User _currentUser;

        public TodoScreen(User user)
        {
            InitializeComponent();

            _currentUser = user;
        }

        private void TodoScreen_Load(object sender, EventArgs e)
        {
            // set the first name and last name labels
            lblName.Text = _currentUser.FirstName + " " + _currentUser.LastName;

            var todoList = DBHelper.Instance.GetTodos(_currentUser.Id);

            foreach (var todo in todoList)
            {
                ListViewItem todoItem = new ListViewItem(
                    new[] { todo.Id.ToString(), todo.Title, todo.Description, todo.CreateAt, todo.Status == 0 ? "Pending" : "Done" }
                );

                lvTodo.Items.Add(todoItem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            var loginForm = this.Tag as Login;
            loginForm!.Show();

            this.Close();
        }

        private void AddTodo_Click(object sender, EventArgs e)
        {
            var addTaskForm = new AddTaskScreen(_currentUser);
            addTaskForm.Tag = this;
            addTaskForm.Show();

            this.Hide();
        }
    }
}
