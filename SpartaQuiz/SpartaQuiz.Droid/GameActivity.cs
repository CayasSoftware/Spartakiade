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
		Core.Game game;
		TextView question;
		Button btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4;

		protected override void OnCreate( Bundle savedInstanceState )
		{
			base.OnCreate(savedInstanceState);

			if(String.IsNullOrWhiteSpace(Intent.GetStringExtra("Playname")))
			{
				Toast.MakeText(this, "Sorry playname not valid!", ToastLength.Long).Show();
				Finish();
				return;
			}

			game = new Core.Game(Intent.GetStringExtra("Playname"));

			SetContentView(Resource.Layout.Game);

			question = FindViewById<TextView>(Resource.Id.GameQuestion);
			btnAnswer1 = FindViewById<Button>(Resource.Id.GameBtnAnswer1);
			btnAnswer2 = FindViewById<Button>(Resource.Id.GameBtnAnswer2);
			btnAnswer3 = FindViewById<Button>(Resource.Id.GameBtnAnswer3);
			btnAnswer4 = FindViewById<Button>(Resource.Id.GameBtnAnswer4);

            btnAnswer1.Click += (sender, args) => CheckAnswer(0);
            btnAnswer2.Click += (sender, args) => CheckAnswer(1);
            btnAnswer3.Click += (sender, args) => CheckAnswer(2);
            btnAnswer4.Click += (sender, args) => CheckAnswer(3);

			SetQuestionViews(game.GetCurrentQuestion());
		}

	    void SetQuestionViews( Core.QuestionItem questionItem )
		{
			question.Text = questionItem.Question;
			btnAnswer1.Text = questionItem.Answers[0];
			btnAnswer2.Text = questionItem.Answers[1];
			btnAnswer3.Text = questionItem.Answers[2];
			btnAnswer4.Text = questionItem.Answers[3];
		}

        private void CheckAnswer(int answer)
        {
            if (game.CheckAnswer(answer))
            {
                SetQuestionViews(game.GetCurrentQuestion());
            }
            else
            {
                Toast.MakeText(this, "Sorry Game Over!", ToastLength.Long).Show();
                Finish();
                return;
            }
        }
	}
}

