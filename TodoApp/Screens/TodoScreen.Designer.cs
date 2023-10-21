namespace TodoApp.Screens
{
    partial class TodoScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lvTodo = new ListView();
            idHeader = new ColumnHeader();
            titleHeader = new ColumnHeader();
            descriptionHeader = new ColumnHeader();
            createdAtHeader = new ColumnHeader();
            statusHeader = new ColumnHeader();
            btnAddTodo = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(46, 33);
            lblName.Name = "lblName";
            lblName.Size = new Size(81, 32);
            lblName.TabIndex = 0;
            lblName.Text = "NAME";
            // 
            // lvTodo
            // 
            lvTodo.Columns.AddRange(new ColumnHeader[] { idHeader, titleHeader, descriptionHeader, createdAtHeader, statusHeader });
            lvTodo.Location = new Point(46, 102);
            lvTodo.Name = "lvTodo";
            lvTodo.Size = new Size(1505, 789);
            lvTodo.TabIndex = 2;
            lvTodo.UseCompatibleStateImageBehavior = false;
            lvTodo.View = View.Details;
            lvTodo.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // idHeader
            // 
            idHeader.Text = "ID";
            idHeader.Width = 120;
            // 
            // titleHeader
            // 
            titleHeader.Text = "Title";
            titleHeader.Width = 300;
            // 
            // descriptionHeader
            // 
            descriptionHeader.Text = "Description";
            descriptionHeader.Width = 600;
            // 
            // createdAtHeader
            // 
            createdAtHeader.Text = "Created At";
            createdAtHeader.Width = 300;
            // 
            // statusHeader
            // 
            statusHeader.Text = "Status";
            statusHeader.Width = 150;
            // 
            // btnAddTodo
            // 
            btnAddTodo.Location = new Point(1401, 26);
            btnAddTodo.Name = "btnAddTodo";
            btnAddTodo.Size = new Size(150, 46);
            btnAddTodo.TabIndex = 3;
            btnAddTodo.Text = "Add Task";
            btnAddTodo.UseVisualStyleBackColor = true;
            btnAddTodo.Click += AddTodo_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1401, 932);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 46);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += Logout_Click;
            // 
            // TodoScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1603, 1002);
            ControlBox = false;
            Controls.Add(btnLogout);
            Controls.Add(btnAddTodo);
            Controls.Add(lvTodo);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "TodoScreen";
            Text = "Todo";
            Load += TodoScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private ListView lvTodo;
        private ColumnHeader idHeader;
        private ColumnHeader titleHeader;
        private ColumnHeader descriptionHeader;
        private ColumnHeader statusHeader;
        private ColumnHeader createdAtHeader;
        private Button btnAddTodo;
        private Button btnLogout;
    }
}
