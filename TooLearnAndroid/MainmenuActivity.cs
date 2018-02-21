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
    [Activity(Label = "MainmenuActivity")]
    public class MainmenuActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_mainmenu);
            /*
            Button myaccount_button = FindViewById<Button>(Resource.Id.button1);
            Button logout_button = FindViewById<Button>(Resource.Id.button2);
            Button joinquiz_button = FindViewById<Button>(Resource.Id.button3);
            Button settings_button = FindViewById<Button>(Resource.Id.button4);
            Button manual_button = FindViewById<Button>(Resource.Id.button5);
            Button about_button = FindViewById<Button>(Resource.Id.button6);

            myaccount_button.Click += delegate
            {
                MyAccountFragment fragment = new MyAccountFragment();
                FragmentTransaction fragmentTx = this.FragmentManager.BeginTransaction();
                fragmentTx.Replace(Resource.Id.fragment_container, fragment);
                fragmentTx.Commit();
            };

            logout_button.Click += delegate
            {
                LogOutFragment fragment = new LogOutFragment();
                FragmentTransaction fragmentTx = this.FragmentManager.BeginTransaction();
                fragmentTx.Replace(Resource.Id.fragment_container, fragment);
                fragmentTx.Commit();
            };

            joinquiz_button.Click += delegate
            {
                JoinQuizFragment fragment = new JoinQuizFragment();
                FragmentTransaction fragmentTx = this.FragmentManager.BeginTransaction();
                fragmentTx.Replace(Resource.Id.fragment_container, fragment);
                fragmentTx.Commit();
            };
            */
        }
    }
}