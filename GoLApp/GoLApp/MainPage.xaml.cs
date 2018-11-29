using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GoLApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            UpdateCell uc = new UpdateCell();
            InitializeComponent();
        }

        int count = 0;
        private void Tapped_Event(object sender, EventArgs e)
        {
            count++;
            Label.Text = "Tapped: " + count;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            count++;
            ((Button)sender).Text = "You clicked " + count + " times!";
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double prcnt;
            Label.Text = String.Format("{0}%", prcnt = e.NewValue*100);
        }
    }
}
