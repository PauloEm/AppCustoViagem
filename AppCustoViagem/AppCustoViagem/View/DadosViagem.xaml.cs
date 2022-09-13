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
    public partial class DadosViagem : ContentPage
    {
        public DadosViagem()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked_Somar(object sender, EventArgs e)
        {
            frm_custo_viagem.IsVisible = true;

            double distancia = Convert.ToDouble(txt_distancia.Text);
            double preco_combustivel = Convert.ToDouble(txt_preco_combustivel.Text);
            double km_litro = Convert.ToDouble(txt_km_litro.Text);

            double custo_combustivel = (distancia / km_litro) * preco_combustivel;

           
            double custo_pedagio = App.ListaPedagios.Sum(i => i.Valor);

            
            double custo_viagem = custo_combustivel + custo_pedagio;

            
            spn_custo_combustivel.Text = custo_combustivel.ToString("C");
            spn_custo_pedagios.Text = custo_pedagio.ToString("C");
            lbl_custo_viagem.Text = custo_viagem.ToString("C");
        }

        private void ToolbarItem_Clicked_Pedagios(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Listagem());
        }
    }
}