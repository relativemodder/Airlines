namespace Airlines
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Forms.LoginForm());
        }
    }
}