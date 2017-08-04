	using System;
	using System.Collections.Generic;

	using Xamarin.Forms;

	/**
	 * This class represents the UserProfile 
	 * It contains the handlers for data filled by user in the user profile form
	 * On saving the data in the user profile, the navigation handler takes the app
	 * view to the main master screen.
	 * Currently the data handling is not implemented and kept for next project
	 * 
	 */
	namespace Calendar
	{
	    public partial class UserProfile : ContentPage
	    {
	        public UserProfile()
	        {
	            InitializeComponent();
	        }

			void Handle_DateSelected(object sender, Xamarin.Forms.DateChangedEventArgs e)
			{
				//Handle and save selected date
			}

			private async void Handle_Profile_Saved(object sender, System.EventArgs e)
			{
				//Move to events listing page
	            await Navigation.PushAsync(new CalendarPage());
			}
	    }
	}
