namespace WinformsChat
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            RegistrationBtn = new Button();
            UsernameLabel = new Label();
            PsswrdLbl = new Label();
            Usernmtxt = new TextBox();
            psswrdtxt = new TextBox();
            RegisterBtn = new Button();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(233, 98);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(325, 23);
            LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(233, 186);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(325, 23);
            PasswordTextBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(162, 101);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(37, 15);
            LoginLabel.TabIndex = 2;
            LoginLabel.Text = "Login";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(162, 189);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // RegistrationBtn
            // 
            RegistrationBtn.Location = new Point(324, 263);
            RegistrationBtn.Name = "RegistrationBtn";
            RegistrationBtn.Size = new Size(147, 54);
            RegistrationBtn.TabIndex = 4;
            RegistrationBtn.Text = "Registration";
            RegistrationBtn.UseVisualStyleBackColor = true;

            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(91, 103);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(66, 15);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username: ";
            // 
            // PsswrdLbl
            // 
            PsswrdLbl.AutoSize = true;
            PsswrdLbl.Location = new Point(91, 170);
            PsswrdLbl.Name = "PsswrdLbl";
            PsswrdLbl.Size = new Size(63, 15);
            PsswrdLbl.TabIndex = 1;
            PsswrdLbl.Text = "Password: ";
            // 
            // Usernmtxt
            // 
            Usernmtxt.Location = new Point(185, 100);
            Usernmtxt.Name = "Usernmtxt";
            Usernmtxt.Size = new Size(234, 23);
            Usernmtxt.TabIndex = 2;
            // 
            // psswrdtxt
            // 
            psswrdtxt.Location = new Point(185, 170);
            psswrdtxt.Name = "psswrdtxt";
            psswrdtxt.Size = new Size(234, 23);
            psswrdtxt.TabIndex = 3;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Location = new Point(233, 247);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(75, 23);
            RegisterBtn.TabIndex = 4;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // RegistrationForm
            // 
            ClientSize = new Size(577, 416);
            Controls.Add(RegisterBtn);
            Controls.Add(psswrdtxt);
            Controls.Add(Usernmtxt);
            Controls.Add(PsswrdLbl);
            Controls.Add(UsernameLabel);
            Name = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Label LoginLabel;
        private Label PasswordLabel;
        private Button RegistrationBtn;
        private Label UsernameLabel;
        private Label PsswrdLbl;
        private TextBox Usernmtxt;
        private TextBox psswrdtxt;
        private Button RegisterBtn;
    }
}