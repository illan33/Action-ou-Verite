using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Application.Current.Properties["PageID"] = "MainPage";

        }

        private async void Btn_StartGame_OnClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JoueurPage());
        }
        private async void Btn_Info_OnClick(object sender, EventArgs e)
        {
            Button Button = (Button)sender;
            await Navigation.PushAsync(new InfoPage());
        }
    }
}
