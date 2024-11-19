namespace ANDROIDAPP
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            
            Routing.RegisterRoute("Income", typeof(IncomePage));
            Routing.RegisterRoute("Vacations", typeof(VacationsPage));
        }
    }
}
