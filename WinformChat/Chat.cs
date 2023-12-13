using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformChat
{
    public partial class Chat : Form
    {
        string? targetId;
        ChooseRecipientcs _chrecipients = new ChooseRecipientcs();
        public Chat()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeRecipient_Click(object sender, EventArgs e)
        {
            _chrecipients.Show();

            while (_chrecipients != null)
            {

            }
            TargetUser.Text = _chrecipients.targetName;
            targetId = _chrecipients.targetId;
            TextingBox.Text = "Recipient Changed!";
        }

        private void TextingBox_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTextingBox(string message)
        {
            TextingBox.Text += "\n" + message;
        }

        private void SendText_Click(object sender, EventArgs e)
        {
            string text = TextBox.Text;
                            ///////                     !!!! SEND TO SERVER
            UpdateTextingBox("You"+text+"\n");
          
        }
        public void RecieveText(string message)         //!!!!
        {
            UpdateTextingBox(message+"\n");
        }
    }
}
