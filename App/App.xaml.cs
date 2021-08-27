using System;
using System.IO;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;
using Action_ou_vérité.Repositories;

namespace App
{
    public partial class App : Application
    {
        private readonly string dbpath = Path.Combine(FileSystem.AppDataDirectory,"database.db3");

        public static JoueursRepository JoueursRepository { get; private set; }

        public App()
        {
            InitializeComponent();

            JoueursRepository = new JoueursRepository(dbpath);

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
