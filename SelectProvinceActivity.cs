
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
using AndroidX.AppCompat.App;

namespace MyContacts
{
    [Activity(Label = "เลือกจังหวัด")]
    public class SelectProvinceActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_select_province);

            var listView = FindViewById<ListView>(Resource.Id.listViewProvince);

            listView.Adapter = new ArrayAdapter<string>(this, Resource.Layout.list_item, Province.datas);

            listView.ItemClick += (object sender, AdapterView.ItemClickEventArgs args) =>
            {
                var toast = Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Short);
                toast.Show();
            };
        }
    }
}
