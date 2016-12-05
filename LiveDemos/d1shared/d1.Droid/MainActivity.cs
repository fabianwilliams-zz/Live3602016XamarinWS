using Android.App;
using Android.Widget;
using Android.OS;
using System; 

namespace d1.Droid
{
	[Activity(Label = "d1.Droid", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.myButton);

			//For my SP Demo

			d1.core.Maths math = new d1.core.Maths();

			var result = math.AddMe(3, 5);
			Console.WriteLine("My result is: " + result);

			//End My SP DEMo


			button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
		}
	}
}

