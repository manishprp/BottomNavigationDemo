using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using BottomNavigationDemo;
using Toolbar = AndroidX.AppCompat.Widget.Toolbar;

namespace ToolbarMenu
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Toolbar toolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            new MenuInflater(this).Inflate(Resource.Menu.bottom_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.open_button_bottom)
            {
                Toast.MakeText(this, "Open", ToastLength.Short).Show();
            }
            else if (id == Resource.Id.save_button_bottom)
            {
                Toast.MakeText(this, "Save", ToastLength.Short).Show();
            }
            else if (id == Resource.Id.new_button_bottom)
            {
                Toast.MakeText(this, "New", ToastLength.Short).Show();
            }
            else
            {
                Toast.MakeText(this, "Delete", ToastLength.Short).Show();
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}