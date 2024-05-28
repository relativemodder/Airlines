using Airlines.Models;
using Airlines.Services;

namespace Airlines.Forms
{
    public partial class ChangeFlightTimeForm : NavigatableForm
    {
        private int flightId;

        public ChangeFlightTimeForm(int flightId)
        {
            InitializeComponent();
            this.flightId = flightId;

            var flight = Client.GetClient().GetFlight(flightId);

            DateTimeOffset suggestedTime = DateTimeOffset.FromUnixTimeSeconds(flight.SuggestedTimestamp);
            string formattedSuggestedTime = suggestedTime.ToString("dd.MM.yy H:mm");

            SuggestedDateLabel.Text = $"{formattedSuggestedTime} GMT";

            DepartureDateTimePicker.Value = Utils.UnixTimeStampToDateTime(flight.DepartureTimestamp);
            DestinationDateTimePicker.Value = Utils.UnixTimeStampToDateTime(flight.DestinationTimestamp);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                var flight = Client.GetClient().EditFlight(new EditFlight()
                {
                    Id = flightId,
                    DepartureTimestamp = (int)((DateTimeOffset)DepartureDateTimePicker.Value).ToUnixTimeSeconds(),
                    DestinationTimestamp = (int)((DateTimeOffset)DestinationDateTimePicker.Value).ToUnixTimeSeconds()
                });

                MessageBox.Show("Подтверждено!");

                new FlightsControlOperatorForm().NavigateToFormFrom(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Не удалось внести изменения: {ex.Message}", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        private void DeleteFlightButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Точно удалить рейс?", "Удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Client.GetClient().DeleteFlight(flightId);
                MessageBox.Show("Груз успешно удалён!");

                new LoadsControlForm().NavigateToFormFrom(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось удалить рейс: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new FlightsControlOperatorForm().NavigateToFormFrom(this);
        }
    }
}
