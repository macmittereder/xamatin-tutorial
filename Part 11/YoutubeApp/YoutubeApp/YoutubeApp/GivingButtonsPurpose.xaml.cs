using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace YoutubeApp
{
    public partial class GivingButtonsPurpose : ContentPage
    {
        public GivingButtonsPurpose()
        {
            InitializeComponent();
        }

        public void OnHelloButtonPressed(object sender, EventArgs e)
        {
            OutputName.Text = "Hello " + NameEntered.Text;
        }

        public void OnGoodByeButtonPressed(object sender, EventArgs e)
        {
            OutputName.Text = "Good-bye " + NameEntered.Text;
        }
    }
}
