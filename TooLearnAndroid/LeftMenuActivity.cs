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
    [Activity(Label = "LeftMenuActivity")]
    public class LeftMenuActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.content_menu_left);

            Button myaccount_button = FindViewById<Button>(Resource.Id.button1);
            Button logout_button = FindViewById<Button>(Resource.Id.button2);
            Button joinquiz_button = FindViewById<Button>(Resource.Id.button3);
            Button settings_button = FindViewById<Button>(Resource.Id.button4);
            Button manual_button = FindViewById<Button>(Resource.Id.button5);
            Button about_button = FindViewById<Button>(Resource.Id.button6);
        }
    }
}