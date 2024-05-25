namespace Airlines.Forms
{
    public class NavigatableForm : Form
    {
        public NavigatableForm NavigateToFormFrom(NavigatableForm from)
        {
            from.Hide();
            ShowDialog();
            from.Close();

            return this;
        }
    }
}
