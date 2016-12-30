using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace YoutubeApp
{
    public partial class SecondNavigationPage : ContentPage
    {
        private string v;

        public SecondNavigationPage(string TextPassed)
        {
            InitializeComponent();

            SecondPageLabel.Text = TextPassed;
        }
    }
}
