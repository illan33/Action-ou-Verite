using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JoueurPage : ContentPage
    {
        public JoueurPage()
        {
            InitializeComponent();
            Application.Current.Properties["PageID"] = "JoueurPage";

            Dictionary<string,string>
                Dico_Joueurs = new Dictionary<string,string>();
            Console.WriteLine(Dico_Joueurs);
        }

        private void Btn_Valider_Onclick(object sender, EventArgs e)
        {

        }

        private void Prénom_Completed(object sender, EventArgs e)
        {
            Editor prénom = (Editor)sender;
            Console.WriteLine(prénom);
        }
    }
}