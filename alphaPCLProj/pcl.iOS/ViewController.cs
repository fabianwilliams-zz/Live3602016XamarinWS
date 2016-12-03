using System;

using UIKit;

namespace pcl.iOS
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

			//For my PCL Demo

			pcl.Core.Maths math = new pcl.Core.Maths();

			var result = math.AddMe(3, 5);
			Console.WriteLine("My result is: " + result);

			//End My PCL

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
