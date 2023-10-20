namespace TodoApp.Screens
{
    partial class SignUp
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
            lblEmail = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(125, 46);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(141, 32);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name: ";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(128, 106);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(138, 32);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(183, 167);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(83, 32);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email: ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(143, 225);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(123, 32);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password: ";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(50, 289);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(216, 32);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Confirm Password: ";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(272, 46);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(450, 39);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(272, 106);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(450, 39);
            txtLastName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(272, 167);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(450, 39);
            txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(272, 225);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(450, 39);
            txtPassword.TabIndex = 8;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(272, 289);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(450, 39);
            txtConfirmPassword.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(416, 366);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(572, 366);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 454);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnSave;
        private Button btnCancel;
    }
}