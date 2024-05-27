using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airlines.Models;
using Airlines.Services;

namespace Airlines.Forms
{
    public partial class BuyTicketForm : NavigatableForm
    {
        public BuyTicketForm()
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

                FlightComboBox.Items.Add(flight1);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new DashboardForm().NavigateToFormFrom(this);
        }
    }
}
