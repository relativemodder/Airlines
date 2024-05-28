using Airlines.Models;
using Airlines.Services;

namespace Airlines.Forms
{
    public partial class FlightsControlExpeditorForm : NavigatableForm
    {
        public FlightsControlExpeditorForm()
        {
            InitializeComponent();

            var flights = Client.GetClient().GetFlights();

            foreach (var flight in flights)
            {
                FlightComboBoxElement flight1 = new FlightComboBoxElement()
                {
                    Id = flight.Id,
                    Departure = flight.Departure,
                    DepartureTimestamp = flight.DepartureTimestamp,
                    Destination = flight.Destination,
                    DestinationTimestamp = flight.DestinationTimestamp,
                    Passengers = flight.Passengers,
                    Plane = flight.Plane,
                    SuggestedTimestamp = flight.SuggestedTimestamp
                };

                FlightsList.Items.Add(flight1);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new DashboardForm().NavigateToFormFrom(this);
        }

        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            new AddFlightForm().NavigateToFormFrom(this);
        }
    }
}
