namespace TodoApp.Screens
{
    public partial class TodoScreen : Form
    {
        public TodoScreen()
        {
            InitializeComponent();
        }

        private void TodoScreen_Load(object sender, EventArgs e)
        {
            // create an item
            ListViewItem item = new ListViewItem(
                new[] { "1", "Task 1", "Do the laundry", DateTime.Now.ToString(), "Pending" }
            );

            // add an item
            lvTodo.Items.Add(item);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
