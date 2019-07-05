using SignaturePad.Forms;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EstudoSignaturePad.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignaturePage : ContentPage
    {
        public SignaturePage()
        {
            InitializeComponent();
        }

        public async void Save(object sender, EventArgs eventArgs)
        {
            Stream stream = await Pad.GetImageStreamAsync(SignatureImageFormat.Jpeg);
        }
    }
}