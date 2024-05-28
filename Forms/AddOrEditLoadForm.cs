using Airlines.Models;
using Airlines.Services;

namespace Airlines.Forms
{
    public partial class AddOrEditLoadForm : NavigatableForm
    {
        private int loadId = 0;

        public AddOrEditLoadForm(int loadId = 0)
        {
            InitializeComponent();

            var flights = Client.GetClient().GetFlights();
            var cutomers = Client.GetClient().GetUsers();

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

            foreach (var user in cutomers)
            {
                UserComboBoxElement user1 = new UserComboBoxElement()
                {
                    Id = user.Id,
                    Middlename = user.Middlename,
                    Name = user.Name,
                    PasswordHash = user.PasswordHash,
                    Role = user.Role,
                    Surname = user.Surname,
                    Username = user.Username
                };

                CustomerComboBox.Items.Add(user1);
            }

            this.loadId = loadId;

            if (loadId != 0)
            {
                var existingLoad = Client.GetClient().GetLoad(loadId);

                int flightIndex = 0;
                int customerIndex = 0;

                for (int index = 0; index < FlightComboBox.Items.Count; index++)
                {
                    if (((FlightComboBoxElement)FlightComboBox.Items[index]).Id == existingLoad.Flight.Id)
                    {
                        flightIndex = index;
                    }
                }

                for (int index = 0; index < CustomerComboBox.Items.Count; index++)
                {
                    if (((UserComboBoxElement)CustomerComboBox.Items[index]).Id == existingLoad.Customer.Id)
                    {
                        customerIndex = index;
                    }
                }

                FlightComboBox.SelectedIndex = flightIndex;
                CustomerComboBox.SelectedIndex = customerIndex;
                WeightTextBox.Text = existingLoad.Weight.ToString();
                PriceTextBox.Text = existingLoad.Price.ToString();
                DescriptionRTFBox.Text = existingLoad.Description;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new LoadsControlForm().NavigateToFormFrom(this);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (FlightComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите рейс!", "Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CustomerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите заказчика!", "Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int flightID = ((FlightComboBoxElement)FlightComboBox.SelectedItem).Id;
            int customerID = ((UserComboBoxElement)CustomerComboBox.SelectedItem).Id;
            int weight;
            float price;
            string description = DescriptionRTFBox.Text;

            try
            {
                weight = int.Parse(WeightTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Вес введён неверно: {ex.Message}", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
                return;
            }

            try
            {
                price = float.Parse(PriceTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Цена введена неверно: {ex.Message}", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
                return;
            }

            try
            {
                var load = Client.GetClient().CreateOrEditLoad(new CreateOrEditLoad()
                {
                    Id = loadId,
                    CustomerUserId = customerID,
                    Weight = weight,
                    Description = description,
                    FlightId = flightID,
                    Price = price
                });

                MessageBox.Show("Груз оформлен!");

                new LoadsControlForm().NavigateToFormFrom(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка оформления груза: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        private void DeleteLoadButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Точно удалить груз?", "Удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Client.GetClient().DeleteLoad(loadId);
                MessageBox.Show("Груз успешно удалён!");

                new LoadsControlForm().NavigateToFormFrom(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось удалить груз: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
