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

            navigationView.NavigationItemSelected += HomeNavigationView_NavigationItemSelected;

            /*

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
        private void HomeNavigationView_NavigationItemSelected(object sender, NavigationView.NavigationItemSelectedEventArgs e)
        {
            var menuItem = e.MenuItem;
            menuItem.SetChecked(!menuItem.IsChecked);
            Intent intent;
            switch (menuItem.ItemId)
            {
                case Resource.Id.nav_myaccount:
                    intent = new Intent(this, typeof(MyAccountActivity));
                    StartActivity(intent); break;

                case Resource.Id.nav_logout:
                    intent = new Intent(this, typeof(LogoutActivity));
                    StartActivity(intent); break;

                case Resource.Id.nav_joinquiz:
                    intent = new Intent(this, typeof(JoinQuizActivity));
                    StartActivity(intent); break;

                case Resource.Id.nav_settings:
                    intent = new Intent(this, typeof(SettingsActivity));
                    StartActivity(intent); break;

                case Resource.Id.nav_manual:
                    intent = new Intent(this, typeof(ManualActivity));
                    StartActivity(intent); break;

                case Resource.Id.nav_about:
                    intent = new Intent(this, typeof(AboutActivity));
                    StartActivity(intent); break;
            }
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