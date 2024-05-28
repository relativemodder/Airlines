namespace Airlines.Forms.Dashboard
{
    public partial class DashboardFlightOperatorPanel : UserControl
    {
        public DashboardFlightOperatorPanel()
        {
            InitializeComponent();
        }

        private void ContactButton_Click(object sender, EventArgs e)
        {
            new FakeMailClient("Руководство").ShowDialog();
        }

        private void FlightsControlButton_Click(object sender, EventArgs e)
        {
            new FlightsControlOperatorForm().NavigateToFormFrom((NavigatableForm)(Parent ?? this));
        }
    }
}
