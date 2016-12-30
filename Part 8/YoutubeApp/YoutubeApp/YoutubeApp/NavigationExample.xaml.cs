using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace YoutubeApp
{
    public partial class NavigationExample : ContentPage
    {
        public NavigationExample()
        {
            InitializeComponent();
        }

        async void GoToSecondPagePressed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondNavigationPage("Second Page"));
        }
    }
}
