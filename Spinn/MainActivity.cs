using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System;

namespace Spinn
{
    [Activity(Label = "Spinn", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            Spinner spinner1 = FindViewById<Spinner>(Resource.Id.spinner1);
            // Data
            List<string> DataList = new List<string>();


            DataList.Add("Layth");
            DataList.Add("Developper");
            DataList.Add("Designer");
            DataList.Add("Ceo");
            DataList.Add("Expert");
            var ArrayAdapter1 = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem,DataList);
            ArrayAdapter1.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner1.Adapter = ArrayAdapter1;
            spinner1.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);



        }
        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner sp = (Spinner)sender;
            Toast.MakeText(this, sp.GetItemAtPosition(e.Position).ToString(), ToastLength.Long).Show(); 
        }
    }
}

