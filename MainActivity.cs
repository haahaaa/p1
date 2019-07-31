using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using System.Collections.Generic;

namespace Project_1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button clickButton = FindViewById<Button>(Resource.Id.publish_button);
            Button clickButton1 = FindViewById<Button>(Resource.Id.expert_button);
            Button clickButton2 = FindViewById<Button>(Resource.Id.task_button);
            Button clickButton3 = FindViewById<Button>(Resource.Id.hand_button);

            clickButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Activity1));
                StartActivity(intent);
            };

            clickButton1.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Activity2));
                StartActivity(intent);
            };
            clickButton2.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Activity3));
                StartActivity(intent);
            };
            clickButton3.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Activity4));
                StartActivity(intent);
            };







        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}