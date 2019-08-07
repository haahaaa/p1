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
    [Activity(Label = "Activity2")]
    public class Activity2 : Activity
    {
        private List<Person> mItems;
        private ListView mListView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Xamarin.Essentials.Platform.Init(this, bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.layout2);

            mListView = FindViewById<ListView>(Resource.Id.myListView);
            mItems = new List<Person>();
            mItems.Add(new Person() { Name = "Jason", Major = "IT technical support", Location = "VIC", Gender = "Male" });
            mItems.Add(new Person() { Name = "Lily", Major = "Accounting tutoring", Location = "NSW", Gender = "Female" });
            mItems.Add(new Person() { Name = "James", Major = "Game leveling", Location = "QLD", Gender = "Male" });
            mItems.Add(new Person() { Name = "Boyi", Major = "Professional translator", Location = "VIC", Gender = "Male" });
            mItems.Add(new Person() { Name = "Victor", Major = "Education agent", Location = "VIC", Gender = "Male" });

            MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);

            mListView.Adapter = adapter;
           





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