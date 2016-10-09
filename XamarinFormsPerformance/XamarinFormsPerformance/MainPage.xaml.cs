using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFormsPerformance.Views;

namespace XamarinFormsPerformance
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void MarginPage_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MarginPage());
        }

        private async void PaddingPage_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaddingPage());
        }

        private async void SpacingPage_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SpacingPage());
        }
    }
}
