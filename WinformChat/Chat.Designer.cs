namespace WinformChat
{
    partial class Chat
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
            TextingBox = new Label();
            TargetUser = new Label();
            ChangeRecipient = new Button();
            SendText = new Button();
            TextBox = new TextBox();
            SuspendLayout();
            // 
            // TextingBox
            // 
            TextingBox.BackColor = Color.Silver;
            TextingBox.BorderStyle = BorderStyle.FixedSingle;
            TextingBox.Location = new Point(60, 55);
            TextingBox.Name = "TextingBox";
            TextingBox.Size = new Size(676, 284);
            TextingBox.TabIndex = 0;
            TextingBox.Click += TextingBox_Click;
            // 
            // TargetUser
            // 
            TargetUser.AutoSize = true;
            TargetUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TargetUser.Location = new Point(60, 25);
            TargetUser.Name = "TargetUser";
            TargetUser.Size = new Size(28, 21);
            TargetUser.TabIndex = 1;
            TargetUser.Text = "All";
            // 
            // ChangeRecipient
            // 
            ChangeRecipient.Location = new Point(616, 393);
            ChangeRecipient.Name = "ChangeRecipient";
            ChangeRecipient.Size = new Size(120, 30);
            ChangeRecipient.TabIndex = 2;
            ChangeRecipient.Text = "Change Recipient";
            ChangeRecipient.UseVisualStyleBackColor = true;
            ChangeRecipient.Click += ChangeRecipient_Click;
            // 
            // SendText
            // 
            SendText.Location = new Point(616, 357);
            SendText.Name = "SendText";
            SendText.Size = new Size(120, 30);
            SendText.TabIndex = 3;
            SendText.Text = "Send";
            SendText.UseVisualStyleBackColor = true;
            SendText.Click += SendText_Click;
            // 
            // TextBox
            // 
            TextBox.Location = new Point(60, 357);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(550, 23);
            TextBox.TabIndex = 4;
            // 
            // Chat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TextBox);
            Controls.Add(SendText);
            Controls.Add(ChangeRecipient);
            Controls.Add(TargetUser);
            Controls.Add(TextingBox);
            Name = "Chat";
            Text = "Chat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextingBox;
        private Label TargetUser;
        private Button ChangeRecipient;
        private Button SendText;
        private TextBox TextBox;
    }
}