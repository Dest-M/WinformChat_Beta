using WinformChat;
using WinformsChat.Repositories;

namespace WinformsChat
{
    public partial class AuthorizeForm : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly Chat _chat;
        public AuthorizeForm(IUserRepository userRepository, Chat chat)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _chat = chat;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Authorize_Click(object sender, EventArgs e)
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;
            var users = _userRepository.GetUsers();
            var user = users.FirstOrDefault(u => u.Login.Trim() == login);

         

            if(user == null)
            {
                MessageBox.Show("Вы ввели некоректные данные", "Не найден пользователь", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("Вы ввели коректные данные", "Найден пользователь", MessageBoxButtons.OK);

            _chat.Show();
            this.Hide(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}