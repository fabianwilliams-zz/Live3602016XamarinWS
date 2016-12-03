using System;

using UIKit;

namespace mysp.ios
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			//For my SP Demo

			msp.core.Maths math = new msp.core.Maths();

			var result = math.AddMe(3, 5);
			Console.WriteLine("My result is: " + result);

			//End My SP DEMo
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
