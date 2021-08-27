using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Action_ou_vérité.Models;
using App;

namespace App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JoueurPage : ContentPage
    {

        public JoueurPage()
        {
            InitializeComponent();
            Application.Current.Properties["PageID"] = "JoueurPage";
        }
        private void Prénom_Completed(object sender, EventArgs e)
        {
            Entry prénom = (Entry)sender;
            Console.WriteLine(prénom);
        }
        private async void Btn_Valider_Onclick(object sender, EventArgs e)
        {

            await App.JoueursRepository.AddNewUserAsync(newJoueur.Text/*,sexe,orientation_sexuelle*/);

            string statusMessage = App.JoueursRepository.StatusMessage;

            Console.WriteLine(statusMessage);
        }


        private void CBHommeCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            string CB = "Homme";
            CB_Sexe(CB);
        }
        private void CBFemmeCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            string CB = "Homme";
            CB_Sexe(CB);
        }
        private void CB_Sexe(string CB)
        {
            if (CB == "Homme")
            {
                CheckBox p = (CheckBox)FindByName("CBFemme");
                if (p.IsChecked)
                {

                }
            }
            if (CB == "Femme")
            {
                CheckBox p = (CheckBox)FindByName("CBHomme");
                if (p.IsChecked)
                {
                    p = new CheckBox { IsChecked = false };
                }
            }
        }
    }
}  