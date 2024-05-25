using Airlines.Services;
using Airlines.Models.Exceptions;

namespace Airlines.Forms
{
    public partial class LoginForm : NavigatableForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            try
            {
                var user = Client.GetClient().Login(
                    UsernameTextBox.Text,
                    PasswordTextBox.Text
                );

                Session.GetSession().SetUser(user);

                new DashboardForm().NavigateToFormFrom(this);
            }
            catch (LoginFailedException ex)
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            new RegisterForm().NavigateToFormFrom(this);
        }
    }
}
