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
    }
}
