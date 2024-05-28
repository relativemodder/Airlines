using Airlines.Models;
using Airlines.Services;

namespace Airlines.Forms
{
    public partial class AddFlightForm : NavigatableForm
    {
        public AddFlightForm()
        {
            InitializeComponent();

            var planes = Client.GetClient().GetPlanes();

            foreach (var plane in planes)
            {
                PlaneComboBoxElement plane1 = new PlaneComboBoxElement()
                {
                    Id = plane.Id,
                    Model = plane.Model
                };

                PlaneComboBox.Items.Add(plane1);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new FlightsControlExpeditorForm().NavigateToFormFrom(this);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (PlaneComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите самолёт!", "Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string departure = DepartureTextBox.Text;
            string destination = DestinationTextBox.Text;
            int passengers = int.Parse(PassengerCountTextBox.Text);
            int planeID = ((PlaneComboBoxElement)PlaneComboBox.SelectedItem).Id;
            int suggestedTimestamp = (int)((DateTimeOffset)SuggestedDateTimePicker.Value).ToUnixTimeSeconds();

            try
            {
                var flight = Client.GetClient().CreateFlight(new CreateFlight()
                {
                    Departure = departure,
                    Destination = destination,
                    Passengers = passengers,
                    PlaneId = planeID,
                    SuggestedTimestamp = suggestedTimestamp
                });

                MessageBox.Show("Рейс успешно создан!");

                new FlightsControlExpeditorForm().NavigateToFormFrom(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка занесения в БД: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
