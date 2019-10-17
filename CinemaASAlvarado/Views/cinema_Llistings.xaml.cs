using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemaASAlvarado.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class cinema_Llistings : ContentPage
    {
        public cinema_Llistings()
        {
            InitializeComponent();
        }

        private void LsCinema_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}