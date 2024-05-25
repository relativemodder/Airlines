using Airlines.Services;

namespace Airlines.Forms
{
    public partial class FakeMailClient : NavigatableForm
    {
        public FakeMailClient(string to)
        {
            InitializeComponent();

            var user = Session.GetSession().GetUser();

            if (user == null)
            {
                MessageBox.Show(
                    "Не найдена сессия, войдите в аккаунт!",
                    "Ошибка доступа",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                new LoginForm().NavigateToFormFrom(this);

                return;
            }

            FromTextBox.Text = user.Username;
            ToTextBox.Text = to;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Сообщение доставлено успешно!",
                "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );

            Close();
        }

        private void FakeMailClient_Load(object sender, EventArgs e)
        {
            MessageBodyRTFBox.Focus();
        }
    }
}
