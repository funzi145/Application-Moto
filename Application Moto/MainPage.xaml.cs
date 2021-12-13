using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Application_Moto
{
    public partial class MainPage : ContentPage
    {
        bool isCar = true;

        public MainPage()
        {
            InitializeComponent();
        }
        int count = 0;
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You Clicked {count} times.";
        }
        void Type_Select(object sender, System.EventArgs e)
        {
            if (((Button)sender).Text == "Voitures")
            {
                isCar = true;
                CarButton.IsEnabled = false;
                MotoButton.IsEnabled = true;
            }
            if (((Button)sender).Text == "Motos")
            {
                isCar = false;
                CarButton.IsEnabled = true;
                MotoButton.IsEnabled = false;
                
            }
        }

    }
}
