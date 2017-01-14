using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace YoutubeApp
{
    public partial class MasterDetailExample : MasterDetailPage
    {
        public MasterDetailExample()
        {
            InitializeComponent();
        }

        public void OnPressedMainPage (Object sender, EventArgs e)
        {
            Detail = new MasterDetailMainPage();
        }

        public void OnPressedSecondPage(Object sender, EventArgs e)
        {
            Detail = new MDPSecondPage();
        }

        public void OnPressedSecretPage(Object sender, EventArgs e)
        {
            Detail = new MDPSecretPage();
        }
    }
}
