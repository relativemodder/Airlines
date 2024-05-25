using Airlines.Forms.Dashboard;
using Airlines.Models;
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

            PanelPositionAnchor.Visible = false;

            switch (user.Role.Level)
            {
                case RoleLevel.PASSENGER:
                    Controls.Add(new DashboardPassengerPanel()
                    {
                        Left = PanelPositionAnchor.Left,
                        Top = PanelPositionAnchor.Top
                    });
                    break;

                case RoleLevel.STAFF:
                    Controls.Add(new DashboardStaffPanel()
                    {
                        Left = PanelPositionAnchor.Left,
                        Top = PanelPositionAnchor.Top
                    });
                    break;

                case RoleLevel.FLIGHT_OPERATOR:
                    Controls.Add(new DashboardFlightOperatorPanel()
                    {
                        Left = PanelPositionAnchor.Left,
                        Top = PanelPositionAnchor.Top
                    });
                    break;

                case RoleLevel.EXPEDITOR:
                    Controls.Add(new DashboardExpeditorPanel()
                    {
                        Left = PanelPositionAnchor.Left,
                        Top = PanelPositionAnchor.Top
                    });
                    break;

                default:
                    MessageBox.Show(
                        $"Ваша роль имеет неизвестный для системы уровень!",
                        "Ошибка доступа",
                        MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                    break;
            }
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Session.GetSession().SetUser(null);
            new LoginForm().NavigateToFormFrom(this);
        }
    }
}
