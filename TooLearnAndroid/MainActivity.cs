using Android.App;
using Android.Widget;
using Android.OS;

namespace TooLearnAndroid
{
    [Activity(Label = "TooLearnAndroid")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button classroom_button = FindViewById<Button>(Resource.Id.button1);
            Button public_button = FindViewById<Button>(Resource.Id.button2);

            classroom_button.Click += delegate
            {
                StartActivity(typeof(SignInActivity));
            };

            public_button.Click += delegate
            {
                StartActivity(typeof(NicknameActivity));
            };

        }
    }
}

