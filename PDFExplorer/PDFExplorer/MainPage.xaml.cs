using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDFExplorer
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            image1.Source = (Device.RuntimePlatform == Device.Android) ? ImageSource.FromResource("PDFExplorer.Images.reader1.png") : ImageSource.FromResource("PDFExplorer.Images.reader1.png");
            image2.Source = (Device.RuntimePlatform == Device.Android) ? ImageSource.FromResource("PDFExplorer.Images.reader2.png") : ImageSource.FromResource("PDFExplorer.Images.reader2.png");
            image3.Source = (Device.RuntimePlatform == Device.Android) ? ImageSource.FromResource("PDFExplorer.Images.reader3.png") : ImageSource.FromResource("PDFExplorer.Images.reader3.png");

        }

        async void OnImage1Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PDFViewPage(1));
        }
        async void OnImage2Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PDFViewPage(2));
        }
        async void OnImage3Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PDFViewPage(3));
        }
    }
}
