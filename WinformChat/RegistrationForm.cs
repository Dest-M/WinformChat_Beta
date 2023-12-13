using WinFormsApp4.Models;
using WinFormsApp4.Repositories;

namespace WinFormsApp4
{
    public partial class RegistrationForm : Form
    {
        private readonly IUserRepository _userRepository;

        private readonly MainWindow _mainWindow;
        public RegistrationForm(MainWindow mainWindow, IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _mainWindow = mainWindow;
        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Вы ввели некоректные данные", "Логин или пароль неверный", MessageBoxButtons.OK);
                return;
            }

            _userRepository.Create(new User() { Login = login, Password = password });

            _mainWindow.Show();
            this.Hide();

        }
    }
}
