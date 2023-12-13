namespace WinformsChat
{
    partial class AuthorizeForm
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
            Authorize = new Button();
            LoginTextBox = new TextBox();
            LoginLabel = new Label();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            SuspendLayout();
            // 
            // Authorize
            // 
            Authorize.Location = new Point(285, 414);
            Authorize.Name = "Authorize";
            Authorize.Size = new Size(296, 30);
            Authorize.TabIndex = 0;
            Authorize.Text = "Авторизоваться";
            Authorize.UseVisualStyleBackColor = true;
            Authorize.Click += Authorize_Click;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(258, 187);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(367, 23);
            LoginTextBox.TabIndex = 1;
            LoginTextBox.TextChanged += textBox1_TextChanged;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(199, 195);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(41, 15);
            LoginLabel.TabIndex = 2;
            LoginLabel.Text = "Логин";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(258, 252);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(367, 23);
            PasswordTextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(199, 260);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(49, 15);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Пароль";
            PasswordLabel.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 861);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginLabel);
            Controls.Add(LoginTextBox);
            Controls.Add(Authorize);
            MinimumSize = new Size(900, 900);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Authorize;
        private TextBox LoginTextBox;
        private Label LoginLabel;
        private TextBox PasswordTextBox;
        private Label PasswordLabel;
    }
}