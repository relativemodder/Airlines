using Airlines.Services;

namespace Airlines.Forms
{
    public partial class DashboardForm : NavigatableForm
    {
        public DashboardForm()
        {
            InitializeComponent();

            var user = Session.GetSession().GetUser();

            if (user == null)
            {
                MessageBox.Show("Вы не вошли в систему.", "Ошибка сессии", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new LoginForm().NavigateToFormFrom(this);
                return;
            }

            FullNameLabel.Text = $"{user.Name} {user.Surname}";
            RoleLabel.Text = user.Role.Name;
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Session.GetSession().SetUser(null);
            new LoginForm().NavigateToFormFrom(this);
        }
    }
}
