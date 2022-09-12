using AppCustoViagem.Model;
using AppCustoViagem.View;
using Xamarin.Forms;

using System.Globalization;
using System.Threading;
using System.Collections.ObjectModel;

namespace AppCustoViagem
{
    public partial class App : Application
    {
        public static ObservableCollection<Pedagio> ListaPedagios = new ObservableCollection<Pedagio>();
        public App()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new cultureInfo("pt-Br");

            MainPage = new NavigationPage(new DadosViagem());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }

    internal class cultureInfo : CultureInfo
    {
        public cultureInfo(string name) : base(name)
        {
        }
    }

    internal class MainPage : Page
    {
    }
}
