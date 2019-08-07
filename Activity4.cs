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
    [Activity(Label = "Activity4")]
    public class Activity4 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Xamarin.Essentials.Platform.Init(this, bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.layout4);

            Button clickButton = FindViewById<Button>(Resource.Id.back_button);
            Button submit_area = FindViewById<Button>(Resource.Id.submit_area);
            submit_area.Click += BtnClick;




            clickButton.Click += (sender, e) =>
           {

               var intent = new Intent(this, typeof(MainActivity));
               StartActivity(intent);
           };


            // Create your application here
        }
        private void BtnClick(object sender, EventArgs e)
        {
            AlertDialog.Builder alertdialog = new AlertDialog.Builder(this);
            alertdialog.SetTitle("Message");
            alertdialog.SetMessage("Submission Sucessful!");
            alertdialog.SetNeutralButton("OK", delegate
            {
            });
        }
    }
}