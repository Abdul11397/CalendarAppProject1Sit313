	using Xamarin.Forms;

	/*
	 * This class relates to the main page of the application
	 * When the app is launched and the first screen has to be loaded
	 * this class will create an instance of the CalendarPage and load it 
	 * into the Main Page
	 */
	namespace Calendar
	{
	    public partial class App : Application
	    {
	        public App()
	        {
	            InitializeComponent();

	            //Create new instance of Main Page
	            MainPage = new CalendarPage();
	        }

	        protected override void OnStart()
	        {
	            // Handle when your app starts
	        }

	        protected override void OnSleep()
	        {
	            // Handle when your app sleeps
	        }

	        protected override void OnResume()
	        {
	            // Handle when your app resumes
	        }
	    }
	}
