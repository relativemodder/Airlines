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

            var flights = Client.GetClient().GetVerifiedFlights();

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

        private void ContactExpeditorButton_Click(object sender, EventArgs e)
        {
            new FakeMailClient("Экспедиторы").ShowDialog();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Оплатить?", "Fake payments form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result != DialogResult.Yes)
            {
                return;
            }

            MessageBox.Show("Благодарим за использование услуг авиакомпании!");

            BackButton_Click(sender, e);
        }
    }
}
