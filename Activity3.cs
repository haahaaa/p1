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
using Newtonsoft.Json;

namespace Project_1
{
    [Activity(Label = "Activity3")]
    public class Activity3 : Activity
    {
        TextView mTitle;
        TextView mDescription;
        TextView mLocation;
        TextView mDeadline;
        User mTask;
        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);
            Xamarin.Essentials.Platform.Init(this, bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.layout3);

            mTitle = FindViewById<TextView>(Resource.Id.txt_title);
            mDescription = FindViewById<TextView>(Resource.Id.txt_description);
            mLocation = FindViewById<TextView>(Resource.Id.txt_location);
            mDeadline = FindViewById<TextView>(Resource.Id.txt_deadline);


            mTask = JsonConvert.DeserializeObject<User>(Intent.GetStringExtra("User"));
            mTitle.Text = mTask.Title;
            mDescription.Text = mTask.Description;
            mLocation.Text = mTask.Location1;
            mDeadline.Text = mTask.Deadline;







            Button clickButton = FindViewById<Button>(Resource.Id.back_button);

            clickButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
            // Create your application here
        }
    }
}