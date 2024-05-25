using Airlines.Services;
using Airlines.Models;
using Airlines.Models.Exceptions;

namespace Airlines.Forms
{
    public partial class RegisterForm : NavigatableForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new LoginForm().NavigateToFormFrom(this);
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string fullName = FullNameTextBox.Text;
            string password = PasswordTextBox.Text;

            string[] fullNameParts = fullName.Split(' ');

            if (fullNameParts.Length < 3)
            {
                MessageBox.Show(
                    "Введите корректные ФИО",
                    "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                return;
            }

            try
            {
                var newUser = Client.GetClient().Register(
                    new CreateUser()
                    {
                        Username = username,
                        Password = password,
                        Surname = fullNameParts[0],
                        Name = fullNameParts[1],
                        Middlename = fullNameParts[2]
                    }
                );

                Session.GetSession().SetUser(newUser);
                new DashboardForm().NavigateToFormFrom(this);
            }
            catch (UserAlreadyExistsException exists)
            {
                MessageBox.Show(
                    $"Пользователь с таким логином уже существует!",
                    "Ошибка регистрации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Что-то определённо пошло не так: {ex.Message}",
                    "Ошибка регистрации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }

        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignUpButton_Click(sender, e);
            }
        }
    }
}
