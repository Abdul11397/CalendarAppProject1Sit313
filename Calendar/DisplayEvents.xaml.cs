	using System;
	using System.Collections.Generic;

	using Xamarin.Forms;

	/**
	 * This class represents the event detailed display 
	 * Currently it loads a List with a set of pre defined strings
	 * The format of the data is to display the details of the Event
	 * like Event Title, Location, Date, Time and Mood
	 * In the future, this list will be loaded with the actual data saved
	 * by the user in the Create Event page
	 */
	namespace Calendar
	{
	    public partial class DisplayEvents : ContentPage
	    {
	        public DisplayEvents()
	        {
	            InitializeComponent();

				// Make string list data of sample events
				List<string> eventsList = new List<string>();

	            eventsList.Add("Beach, Melb, 15/8/17 2pm, Excited");
	            eventsList.Add("Study, Deakin, 18/8/17 1pm, Serious");
	            eventsList.Add("Footy, Etihad, 21/8/17 1pm, Happy");

				// Bind the list data
				this.BindingContext = eventsList;
	        }
	    }
	}
