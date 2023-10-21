using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoApp.Data;

namespace TodoApp.Screens
{
    public partial class AddTaskScreen : Form
    {
        private User _currentUser;

        public AddTaskScreen(User user)
        {
            InitializeComponent();

            _currentUser = user;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // save the task / todo
            Todo todo = new Todo();
            todo.UserId = _currentUser.Id;
            todo.Title = txtTitle.Text;
            todo.Description = txtDescription.Text;
            todo.Status = 0;
            todo.CreateAt = DateTime.Now.ToString();

            var result = DBHelper.Instance.CreateTodo(todo);
            if (result)
            {
                MessageBox.Show("Todo is added!", "Todo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add todo!", "Todo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.CloseForm();
        }

        private void CloseForm()
        {
            var todoScreen = this.Tag as TodoScreen;
            todoScreen!.Show();

            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }

        private void AddTaskScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
