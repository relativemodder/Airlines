using Airlines.Models;
using Airlines.Services;

namespace Airlines.Forms
{
    public partial class LoadsControlForm : NavigatableForm
    {
        public LoadsControlForm()
        {
            InitializeComponent();

            var loads = Client.GetClient().GetLoads();

            foreach (var load in loads)
            {
                LoadComboBoxElement load1 = new LoadComboBoxElement()
                {
                    Id = load.Id,
                    Customer = load.Customer,
                    Description = load.Description,
                    Flight = load.Flight,
                    Price = load.Price,
                    Weight = load.Weight
                };

                LoadsList.Items.Add(load1);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new DashboardForm().NavigateToFormFrom(this);
        }

        private void AddLoadButton_Click(object sender, EventArgs e)
        {
            new AddOrEditLoadForm().NavigateToFormFrom(this);
        }

        private void LoadsList_DoubleClick(object sender, EventArgs e)
        {
            if (LoadsList.SelectedItem == null)
            {
                return;
            }

            var load = (LoadComboBoxElement)LoadsList.SelectedItem;

            new AddOrEditLoadForm(load.Id).NavigateToFormFrom(this);
        }
    }
}
