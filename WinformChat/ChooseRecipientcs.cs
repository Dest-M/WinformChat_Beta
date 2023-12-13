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
    public partial class ChooseRecipientcs : Form
    {
        public string targetName;
        public string targetId;

        public ChooseRecipientcs()
        {
            InitializeComponent();
        }

        private void UserSelectBtn_Click(object sender, EventArgs e)
        {
            targetName = OnlineUsersList.CheckedItems.ToString();
            targetId = ///LINK SERVER HERE.

        }
    }
}
