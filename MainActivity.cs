using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;

namespace MyContacts
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


            //var listView = FindViewById<ListView>(Resource.Id.listViewProvince);

            //listView.Adapter = new ArrayAdapter<string>(this, Resource.Layout.list_item, Province.datas);

            //listView.ItemClick += (object sender, AdapterView.ItemClickEventArgs args) =>
            //{
            //    var toast = Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Short);
            //    toast.Show();
            //};

            var buttonSelectProvince = FindViewById<Button>(Resource.Id.buttonSelectProvince);

            buttonSelectProvince.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(SelectProvinceActivity));
                StartActivityForResult(intent, 0);
            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}