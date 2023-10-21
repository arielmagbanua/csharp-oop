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
            lblFirstName = new Label();
            lblLastName = new Label();
            lvTodo = new ListView();
            idHeader = new ColumnHeader();
            titleHeader = new ColumnHeader();
            descriptionHeader = new ColumnHeader();
            createdAtHeader = new ColumnHeader();
            statusHeader = new ColumnHeader();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(46, 33);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(146, 32);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "FIRST NAME";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(198, 33);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(141, 32);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "LAST NAME";
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
            // TodoScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1605, 945);
            Controls.Add(lvTodo);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "TodoScreen";
            Text = "TodoScreen";
            Load += TodoScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private ListView lvTodo;
        private ColumnHeader idHeader;
        private ColumnHeader titleHeader;
        private ColumnHeader descriptionHeader;
        private ColumnHeader statusHeader;
        private ColumnHeader createdAtHeader;
    }
}
