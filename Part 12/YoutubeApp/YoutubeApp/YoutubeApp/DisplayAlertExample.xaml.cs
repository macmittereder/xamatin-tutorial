using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace YoutubeApp
{
    public partial class DisplayAlertExample : ContentPage
    {
        public DisplayAlertExample()
        {
            InitializeComponent();
        }

        public void OnPressedAlertButton (Object sender, EventArgs e)
        {
            DisplayAlert("Notification",
                "Do you want to save this item",
                "Yes, Save",
                "Don't Save");
        }
    }
}
