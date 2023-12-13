using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsChat
{
    public partial class InputWindow : Form
    {
        private readonly AuthorizeForm _authorizeForm;
        private readonly RegistrationForm _registrationForm;

        public InputWindow(AuthorizeForm authorizeForm, RegistrationForm registrationForm)
        {
            InitializeComponent();
            _authorizeForm = authorizeForm;
            _registrationForm = registrationForm;
        }

        private void AuthorizeBtn_Click(object sender, EventArgs e)
        {
            _authorizeForm.Show();
            this.Hide();
        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            _registrationForm.Show();
            this.Hide();
        }
    }
}
