using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace mysp.droid
{
	[Activity(Label = "mysp.droid", MainLauncher = true, Icon = "@mipmap/icon")]
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

			msp.core.Maths math = new msp.core.Maths();

			var result = math.AddMe(3, 5);
			Console.WriteLine("My result is: " + result);


			//End My SP DEMo

			button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
		}
	}
}

