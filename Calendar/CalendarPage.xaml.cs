	using Xamarin.Forms;

	/**
	 * This class represents the first view of the app
	 * It is the master view of a master detail layout.
	 * It contains the user options buttons for the app functionality
	 * It also contains the click action handlers
	 * 
	 */
	namespace Calendar
	{
	    public partial class CalendarPage : MasterDetailPage
	    {
	        public CalendarPage()
	        {
	            InitializeComponent();

	            //Intialize the detail view with Display of all Calendar Events created
	            Detail = new NavigationPage(new DisplayEvents());

	            IsPresented = true;
	        }

	        void Handle_CreateEvent_Clicked(object sender, System.EventArgs e)
	        {
	            //When create event action is clicked, navigate to the Create Event page
	            Detail = new NavigationPage(new CreateEvent());
	            IsPresented = false;
	        }

			void Handle_DisplayEvent_Clicked(object sender, System.EventArgs e)
			{
	            //When display event action is clicked, navigate to the Display Events page
	            Detail = new NavigationPage(new DisplayEvents());
	            IsPresented = false;
			}

			void Handle_DisplayProfile_Clicked(object sender, System.EventArgs e)
			{
	            //When the user profile action is clicked, navigate to the User Profile page
	            Detail = new NavigationPage(new UserProfile());
				IsPresented = false;
			}
	    }
	}
