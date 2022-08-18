using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android.Views;
using AndroidX.Core.View;

namespace AspitSchoolDay.Droid
{
    [Activity(Label = "AspitSchoolDay", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
            Window.SetStatusBarColor(Android.Graphics.Color.Rgb(25, 69, 73));

            if (Build.VERSION.SdkInt >= BuildVersionCodes.R && false)
            {
                Window.SetDecorFitsSystemWindows(false);
            }
            else
            {
                Window.DecorView.SystemUiVisibility = (StatusBarVisibility)(SystemUiFlags.HideNavigation |
                                                                          SystemUiFlags.LayoutHideNavigation |
                                                                          SystemUiFlags.LayoutFullscreen |
                                                                          SystemUiFlags.Fullscreen |
                                                                          SystemUiFlags.LayoutStable |
                                                                          SystemUiFlags.ImmersiveSticky);
            }

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}