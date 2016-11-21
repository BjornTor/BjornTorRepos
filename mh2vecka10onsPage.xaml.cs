using Xamarin.Forms;
using Xamarin.Forms.Maps;
using System;

namespace mh2vecka10ons
{
	public partial class mh2vecka10onsPage : ContentPage
	{
		public mh2vecka10onsPage()
		{
			InitializeComponent();
			// AIzaSyBVfcFZ3M52FBlp2eX-ABEdNHo8sIWWumo
			MyMap.MapType = MapType.Hybrid;

			MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(56.037959, 12.698178), Distance.FromMeters(1000)));

			/*
			var pin = new Pin
			{
				Type = PinType.Place,
				Position = new Position(56.037959, 12.698178),
				Label = "custom pin",
				Address = "custom detail info"
			};
			MyMap.Pins.Add(pin);

			var pin2 = new Pin
			{
				Type = PinType.Place,
				Position = new Position(56.039014, 12.698505),
				Label = "Campus",
				Address = "Ingång"
			};
			pin2.Clicked += async (sender, e) => {
				System.Diagnostics.Debug.WriteLine("KLICKA PÅ PINNE!!");
			};

			MyMap.Pins.Add(pin2);
			*/

			makePin(56.037959, 12.698178, "Pinne 1");
			makePin(56.038959, 12.697478, "Pinne 2");
			makePin(56.038559, 12.697978, "Pinne 3");
			makePin(56.039259, 12.698378, "Pinne 4");
			makePin(56.039759, 12.698278, "Pinne 5");


		}

		void makePin(double lat, double lon, string title)
		{ 
			var pin = new Pin
			{
				Type = PinType.Place,
				Position = new Position(lat, lon),
				Label = title
			};
			MyMap.Pins.Add(pin);
		}

		void addPin(object sender, EventArgs e)
		{
			System.Diagnostics.Debug.WriteLine(MyMap.VisibleRegion.LatitudeDegrees.ToString());
			makePin(MyMap.VisibleRegion.Center.Latitude, MyMap.VisibleRegion.Center.Longitude, "Egen pinne");
		}

	}
}
