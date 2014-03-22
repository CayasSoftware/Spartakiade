// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace SpartaQuiz.iOS
{
	[Register ("GameController")]
	partial class GameController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton BtnAnswer1 { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (BtnAnswer1 != null) {
				BtnAnswer1.Dispose ();
				BtnAnswer1 = null;
			}
		}
	}
}
