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
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        EditText mTitle;
        EditText mDescription;
        EditText mLocation;
        EditText mDeadline;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.layout1);
            Button clickButton = FindViewById<Button>(Resource.Id.back_button);


            clickButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

            Button clickButton1 = FindViewById<Button>(Resource.Id.submit_area);
            mTitle = FindViewById<EditText>(Resource.Id.titleText);
            mDescription = FindViewById<EditText>(Resource.Id.dsText);
            mDeadline = FindViewById<EditText>(Resource.Id.deText);
            mLocation = FindViewById<EditText>(Resource.Id.lcText);



            clickButton1.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Activity3));
                User user = new User()
                {
                    
                    Title = mTitle.Text,
                    Description = mDescription.Text,
                    Location1 = mLocation.Text,
                    Deadline = mDeadline.Text

                };

                intent.PutExtra("User", JsonConvert.SerializeObject(user));
               
                StartActivity(intent);
            };

            // Create your application here
        }



    }
}