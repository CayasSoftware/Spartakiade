using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SpartaQuiz.iOS
{
	public partial class PlayGameController : UIViewController
	{
		string playername;
		Core.Game game;
		UILabel question;
		UIButton btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4;

		public PlayGameController( string playname )
		{
			this.playername = playname;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			
			game = new SpartaQuiz.Core.Game(playername);

			question = new UILabel(new RectangleF(10, 80, View.Frame.Width - 20, 20));
			View.AddSubview(question);

			btnAnswer1 = new UIButton(new RectangleF(10, 80, View.Frame.Width - 20, 20));
			View.AddSubview(btnAnswer1);

			btnAnswer2 = new UIButton(new RectangleF(10, 110, View.Frame.Width - 20, 20));
			View.AddSubview(btnAnswer2);

			btnAnswer3 = new UIButton(new RectangleF(10, 140, View.Frame.Width - 20, 20));
			View.AddSubview(btnAnswer3);

			btnAnswer4 = new UIButton(new RectangleF(10, 170, View.Frame.Width - 20, 20));
			View.AddSubview(btnAnswer4);
		}
	}
}

