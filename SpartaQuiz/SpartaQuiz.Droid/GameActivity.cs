using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SpartaQuiz.Droid
{
	[Activity(Label = "GameActivity")]			
	public class GameActivity : Activity
	{
		protected override void OnCreate( Bundle savedInstanceState )
		{
			base.OnCreate(savedInstanceState);

			if(String.IsNullOrWhiteSpace(Intent.GetStringExtra("Playname")))
			{
				Toast.MakeText(this, "Sorry playname not valid!", ToastLength.Long).Show();
				Finish();
				return;
			}

			SetContentView(Resource.Layout.Game);
		}
	}
}

