using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;
using Astrid.Android;

namespace HelloWorld.Android
{
    [Activity(Label = "HelloWorld.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private AndroidApplication _application;
        private Game _game;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            RequestWindowFeature(WindowFeatures.NoTitle);
            Window.SetFlags(WindowManagerFlags.Fullscreen, WindowManagerFlags.Fullscreen);

            var config = new AndroidApplicationConfig(this);
            _application = new AndroidApplication(config);
            _game = new Game(_application);
            _application.Run(_game);
            SetContentView(_application.View);
        }

        protected override void OnDestroy()
        {
            _application.Dispose();
            base.OnDestroy();
        }

        protected override void OnPause()
        {
            base.OnPause();
            _application.Pause();
        }

        protected override void OnResume()
        {
            base.OnResume();
            _application.Resume();
        }
    }
}

