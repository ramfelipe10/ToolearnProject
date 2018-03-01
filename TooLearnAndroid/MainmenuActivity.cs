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
using Android.Support.V7.App;
using Android.Support.V4.Widget;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.Design.Widget;

namespace TooLearnAndroid
{
    [Activity(Label = "MainmenuActivity", Theme = "@style/Theme.DesignDemo")]
    public class MainmenuActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_mainmenu);
            DrawerLayout drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            // Create ActionBarDrawerToggle button and add it to the toolbar  
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            var drawerToggle = new ActionBarDrawerToggle(this, drawerLayout, toolbar, Resource.String.drawer_open, Resource.String.drawer_close);
            drawerLayout.AddDrawerListener(drawerToggle);
            drawerToggle.SyncState();
            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            setupDrawerContent(navigationView); //Calling Function  

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
        void setupDrawerContent(NavigationView navigationView)
        {
            navigationView.NavigationItemSelected += (sender, e) =>
            {
                DrawerLayout drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
                e.MenuItem.SetChecked(true);
                drawerLayout.CloseDrawers();
            };
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.InflateMenu(Resource.Menu.nav_menu); //Navigation Drawer Layout Menu Creation  
            return true;
        }
    }
}