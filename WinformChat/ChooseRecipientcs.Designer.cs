namespace WinformChat
{
    partial class ChooseRecipientcs
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
            OnlineUsersList = new CheckedListBox();
            UserSelectBtn = new Button();
            SuspendLayout();
            // 
            // OnlineUsersList
            // 
            OnlineUsersList.FormattingEnabled = true;
            OnlineUsersList.Location = new Point(22, 27);
            OnlineUsersList.Name = "OnlineUsersList";
            OnlineUsersList.Size = new Size(233, 346);
            OnlineUsersList.TabIndex = 0;
            // 
            // UserSelectBtn
            // 
            UserSelectBtn.Location = new Point(287, 338);
            UserSelectBtn.Name = "UserSelectBtn";
            UserSelectBtn.Size = new Size(122, 35);
            UserSelectBtn.TabIndex = 1;
            UserSelectBtn.Text = "Confirm";
            UserSelectBtn.UseVisualStyleBackColor = true;
            UserSelectBtn.Click += UserSelectBtn_Click;
            // 
            // ChooseRecipientcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 450);
            Controls.Add(UserSelectBtn);
            Controls.Add(OnlineUsersList);
            Name = "ChooseRecipientcs";
            Text = "ChooseRecipientcs";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox OnlineUsersList;
        private Button UserSelectBtn;
    }
}