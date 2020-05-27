using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDFExplorer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PDFViewPage : ContentPage
    {
        int pdfNum = 1;
        public PDFViewPage(int pnum)
        {
            pdfNum = pnum;
            
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            PdfViewModel model = new PdfViewModel(pdfNum);
            pdfViewerControl.InputFileStream = model.PdfDocumentStream;

        }
    }
}