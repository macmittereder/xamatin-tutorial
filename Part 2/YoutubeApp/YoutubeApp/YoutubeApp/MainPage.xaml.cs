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
                    Name = "One",
                    Description = "One",
                    OrderNumber = 1
                },
                new ListViewTemplate
                {
                    Name = "Two",
                    Description = "Two",
                    OrderNumber = 2
                },
                new ListViewTemplate
                {
                    Name = "Three",
                    Description = "Three",
                    OrderNumber = 3
                },
                new ListViewTemplate
                {
                    Name = "Four",
                    Description = "Four",
                    OrderNumber = 4
                }
            };
        }
    }
}
