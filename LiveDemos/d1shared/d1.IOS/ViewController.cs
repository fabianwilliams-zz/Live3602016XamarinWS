using System;

using UIKit;

namespace d1.IOS
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

			d1.core.Maths math = new d1.core.Maths();

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
