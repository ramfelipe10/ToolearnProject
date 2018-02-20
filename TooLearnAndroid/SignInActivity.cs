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

namespace TooLearnAndroid
{
    [Activity(Label = "SignInActivity")]
    public class SignInActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_signin);

            Button signup_button = FindViewById<Button>(Resource.Id.button2);
            Button signin_button = FindViewById<Button>(Resource.Id.button1);

            signin_button.Click += delegate
            {
                StartActivity(typeof(MainmenuActivity));
            };

            signup_button.Click += delegate
            {
                StartActivity(typeof(SignUpActivity));
            };
        }
    }
}