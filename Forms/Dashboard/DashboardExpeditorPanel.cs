using Airlines.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airlines.Forms.Dashboard
{
    public partial class DashboardExpeditorPanel : UserControl
    {
        public DashboardExpeditorPanel()
        {
            InitializeComponent();
        }

        private void ContactButton_Click(object sender, EventArgs e)
        {
            new FakeMailClient("Руководство").ShowDialog();
        }

        private void FlightsControlButton_Click(object sender, EventArgs e)
        {
            new FlightsControlExpeditorForm().NavigateToFormFrom((NavigatableForm)(Parent ?? this));
        }

        private void ControlLoadButton_Click(object sender, EventArgs e)
        {

        }
    }
}
