using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SpartaQuiz.Droid
{
	[Activity(Label = "SpartaQuiz.Droid", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate( Bundle savedInstanceState )
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.GameStart_StartBtn);
			button.Click += delegate
			{
				var playname = FindViewById<EditText>(Resource.Id.GameStart_PlaynameEdtxt).Text;

				var intent = new Intent(this, typeof(GameActivity));
				intent.PutExtra("Playname", playname);

				StartActivity(intent);
			};
		}
	}
}