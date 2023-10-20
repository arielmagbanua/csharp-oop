namespace TodoApp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsername = new Label();
            lblPassword = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(58, 61);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(213, 32);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username / Email: ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(148, 144);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(123, 32);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(277, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(417, 39);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(277, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(417, 39);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(277, 232);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(212, 46);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(495, 232);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(199, 46);
            btnSignUp.TabIndex = 6;
            btnSignUp.Text = "Sign-up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += BtnSignUp_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 327);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button btnLogin;
        private Button btnSignUp;
    }
}