using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            slidey.Value = 0.5;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e) => jebany.Text = String.Format("Value is {0:F2}", e.NewValue);
    }
}
