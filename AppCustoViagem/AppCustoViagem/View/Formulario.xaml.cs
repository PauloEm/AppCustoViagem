using AppCustoViagem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCustoViagem.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Formulario : ContentPage
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            try
            {
                Pedagio p = new Pedagio
                {
                    Localização = txt_localizacao.Text,
                    Valor = Convert.ToDouble(txt_valor.Text)
                };
                App.ListaPedagios.Add(p);

                await DisplayAlert("Parabéns!", "Pedágio adicionado", "Ok");

                await Navigation.PopAsync();

            } catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "Ok");
            }

        }
    }
}