using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using YoutubeApp.Classes;

namespace YoutubeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            MainListView.ItemsSource = new List<ListViewTemplate>
            {
                new ListViewTemplate
                {
                    Name = "Label Examples",
                    Description = "Some label examples",
                    OrderNumber = 1
                },
                new ListViewTemplate
                {
                    Name = "Button Examples",
                    Description = "Some Button Examples",
                    OrderNumber = 2
                },
                new ListViewTemplate
                {
                    Name = "Giving Buttons Purpose",
                    Description = "Using a grid view to give buttons some purpose",
                    OrderNumber = 3
                },
                new ListViewTemplate
                {
                    Name = "Navigation Example",
                    Description = "Short Navigation Example",
                    OrderNumber = 4
                }
            };
        }

        async void OnTapped(object sender, ItemTappedEventArgs e)
        {
            var Selected = e.Item as ListViewTemplate;

            switch (Selected.OrderNumber)
            {
                case 1:
                    await Navigation.PushAsync(new Labels());
                    break;
                case 2:
                    await Navigation.PushAsync(new Buttons());
                    break;
                case 3:
                    await Navigation.PushAsync(new GivingButtonsPurpose());
                    break;
                case 4:
                    await Navigation.PushAsync(new NavigationExample());
                    break;
            }

            ((ListView)sender).SelectedItem = null;
        }
    }
}
