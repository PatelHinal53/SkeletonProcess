using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using System.Collections.Generic;
using System.Threading;
using Supercharge;
using Android.Widget;
using Java.Lang;
using System;
using System.Threading.Tasks;

namespace SkeletonDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView tv;
        ShimmerLayout shimmerLayout;
        List<string> employeenames;
        LinearLayout linearLayout;


        RecyclerView.LayoutManager mLayoutManager;
        RecyclerView recycler;
        adepter mAdapter;
        int c = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            shimmerLayout = FindViewById<ShimmerLayout>(Resource.Id.shimeerlayout);
            linearLayout = FindViewById<LinearLayout>(Resource.Id.linearLayout1);
            tv = FindViewById<TextView>(Resource.Id.textView);
            recycler = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            recycler.Visibility = Android.Views.ViewStates.Invisible;
            employeenames = new List<string> {  };

            employeenames = new List<string> {

            "Akk",
            "Rosk",
            "Rock",
            "Pinky",
            "Redy",
            "Whit",
            "Yello",
            "Black",
            "Akk",
            "Rosk",
            "Rock",
            "Pinky",
            "Redy",
            "Whit",
            "Yello",
            "Black",
            "Akk",
            "Rosk",
            "Rock",
            "Pinky",
            "Redy",
            "Whit",
            "Yello",
            "Black",
            "Akk",
            "Rosk",
            "Rock",
            "Pinky",
            "Redy",
            "Whit",
            "Yello",
            "Black",
            };


            mLayoutManager = new LinearLayoutManager(this);
            recycler.SetLayoutManager(mLayoutManager);
            mAdapter = new adepter(employeenames, ApplicationContext);
            recycler.SetAdapter(mAdapter);
            shimmerLayout.StartShimmerAnimation();



        }
        protected override async void OnResume()
        {
            base.OnResume();
            await Task.Delay(3000);
            recycler.Visibility = Android.Views.ViewStates.Visible;
            shimmerLayout.StopShimmerAnimation();
            linearLayout.Visibility = Android.Views.ViewStates.Invisible;

        }



    }
}