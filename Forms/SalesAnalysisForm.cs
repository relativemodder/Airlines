using Airlines.Services;

namespace Airlines.Forms
{
    public partial class SalesAnalysisForm : NavigatableForm
    {
        public SalesAnalysisForm()
        {
            InitializeComponent();

            var sales = Client.GetClient().GetSalesAnalysis();

            SalesAnalysisLabel.Text = $"Всего рейсов проведено: {sales.AllFlightsCount} {Environment.NewLine}" +
                $"Выручка от всех перевозок грузов: {sales.RevenueOfAllShips} {Environment.NewLine}" +
                $"Средняя цена перевозки: {sales.AverageShipCost} {Environment.NewLine}" +
                $"Клиентов в системе: {sales.UsersCount} {Environment.NewLine}" +
                $"Среднее число вылетов на клиента: {sales.AverageFlightCountPerClient}";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new DashboardForm().NavigateToFormFrom(this);
        }
    }
}
