using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            Debug.WriteLine("OnStart");
            if (Current.Properties.ContainsKey("PageID"))
            {
                var id = Current.Properties["PageID"];
                Debug.WriteLine("OnStart - " + id);
            }
        }

        protected override void OnSleep()
        {
            Debug.WriteLine("OnSleep");
        }

        protected override void OnResume()
        {
            Debug.WriteLine("OnResume");
            if (Current.Properties.ContainsKey("PageID"))
            {
                var id = Current.Properties["PageID"];
                Debug.WriteLine("OnResume - " + id);
            }
        }
    }
}
