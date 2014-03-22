using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SpartaQuiz.iOS
{
	public class GameStartController : UIViewController
	{
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			View.BackgroundColor = UIColor.White;

			var gameNameLabel = new UILabel(new RectangleF(10, 80, View.Frame.Width - 20, 20));
			gameNameLabel.Text = "Spartakiade Quiz";

			View.AddSubview(gameNameLabel);

			var playname = new UITextView(new RectangleF(10, 110, View.Frame.Width - 20, 20));
			playname.BackgroundColor = UIColor.Brown;

			View.AddSubview(playname);

			var btnStartGame = new UIButton(new RectangleF(10, 140, View.Frame.Width - 20, 20));
			btnStartGame.SetTitle("Start game", UIControlState.Normal);
			btnStartGame.BackgroundColor = UIColor.Blue;
			btnStartGame.TouchUpInside += delegate
			{
				NavigationController.PushViewController(new PlayGameController(playname.Text), true);
			};

			View.AddSubview(btnStartGame);
		}
	}
}

