using Airlines.Models;
using Airlines.Services;

namespace Airlines.Forms
{
    public partial class FlightsControlOperatorForm : NavigatableForm
    {
        public FlightsControlOperatorForm()
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

        private void FlightsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FlightsList.SelectedItem == null)
            {
                return;
            }

            var flight = (FlightComboBoxElement)FlightsList.SelectedItem;

            new ChangeFlightTimeForm(flight.Id).NavigateToFormFrom(this);
        }
    }
}
