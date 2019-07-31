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

namespace Project_1
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
       
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

            // Create your application here
        }
      
       

    }
}