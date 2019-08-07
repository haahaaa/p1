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
    class MyListViewAdapter : BaseAdapter<Person>
    {
        public List<Person> mItems;
        private Context mContext;

        public MyListViewAdapter(Context context, List<Person> items)
        {
            mItems = items;
            mContext = context;
        }

        public override int Count
        {
            get { return mItems.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override  Person this[int position]
        {
            get { return mItems[position]; }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.layout5, null,false);

            }

            TextView txtName = row.FindViewById<TextView>(Resource.Id.txtName);
            txtName.Text = mItems[position].Name;

            TextView txtMajor = row.FindViewById<TextView>(Resource.Id.txtMajor);
            txtMajor.Text = mItems[position].Major;

            TextView txtLocation = row.FindViewById<TextView>(Resource.Id.txtLocation);
            txtLocation.Text = mItems[position].Location;

            TextView txtGender = row.FindViewById<TextView>(Resource.Id.txtGender);
            txtGender.Text = mItems[position].Gender;

            return row;
        }
    }

}