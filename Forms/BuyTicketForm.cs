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

            foreach ( var flight in flights )
            {
                FlightComboBoxElement flight1 = (FlightComboBoxElement)flight;
                FlightComboBox.Items.Add(flight1);
            }
        }
    }
}
