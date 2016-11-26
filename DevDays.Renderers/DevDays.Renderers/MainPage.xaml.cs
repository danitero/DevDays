using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DevDays.Renderers
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            var button = (Button)sender;

            var color = button.BackgroundColor;
        }
    }
}
