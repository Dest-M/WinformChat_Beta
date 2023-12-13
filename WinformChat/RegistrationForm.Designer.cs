namespace WinformsChat
{
    partial class RegistrationForm : RegistrationFormBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            RegistrationBtn.Click += RegistrationBtn_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RegistrationBtn);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Label LoginLabel;
        private Label PasswordLabel;
        private Button RegistrationBtn;
    }
}