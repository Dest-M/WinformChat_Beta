
using WinformChat;
using WinformsChat.Models;
using WinformsChat.Repositories;

namespace WinformsChat
{
    public partial class RegistrationForm : Form
    {
        private readonly IUserRepository _userRepository;

        private readonly Chat _chat;
        public RegistrationForm(Chat chat, IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _chat = chat;
        }



        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var login = Usernmtxt.Text; 
            var password = psswrdtxt.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Вы ввели некоректные данные", "Логин или пароль неверный", MessageBoxButtons.OK);
                return;
            }

            _userRepository.Create(new User() { Login = login, Password = password });

            _chat.Show();
            this.Hide();
        }
    }
}
