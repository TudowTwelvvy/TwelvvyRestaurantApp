using TwelvvyRestaurantApp.Data;

namespace TwelvvyRestaurantApp
{
    public partial class App : Application
    {
        private readonly DatabaseService _databaseService;

        public App(DatabaseService databaseService)
        {
            InitializeComponent();

            MainPage = new AppShell();
            _databaseService = databaseService;
        }

       protected override async void OnStart()
        {
            base.OnStart();
            //initialize and seed Database
            await _databaseService.InitializeDatabaseAsync();
   

        }
    }
}
