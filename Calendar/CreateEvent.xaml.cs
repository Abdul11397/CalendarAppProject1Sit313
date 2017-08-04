	using System;
	using System.Collections.Generic;

	using Xamarin.Forms;

	/**
	 * This class represents the Create Event class logic
	 * Currently it handles the push to the events detail page on button select
	 * The data handling of the fields entered for the create event form is for future development
	 * 
	 */
	namespace Calendar
	{
	    public partial class CreateEvent : ContentPage
	    {
	        public CreateEvent()
	        {
	            InitializeComponent();
	        }

	        void Handle_DateSelected(object sender, Xamarin.Forms.DateChangedEventArgs e)
	        {
	            //Handle and save selected date
	        }

			private async void Handle_CreateEvent_Saved(object sender, System.EventArgs e)
			{
				//Move to events listing page
	            await Navigation.PushAsync(new DisplayEvents());
			}
		}
	}
