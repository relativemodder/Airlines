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
    public partial class DashboardPassengerPanel : UserControl
    {
        public DashboardPassengerPanel()
        {
            InitializeComponent();
        }

        private void RequestTheLoadButton_Click(object sender, EventArgs e)
        {
            new FakeMailClient("Экспедиторы").ShowDialog();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            new BuyTicketForm().NavigateToFormFrom((NavigatableForm)(Parent ?? this));
        }
    }
}
