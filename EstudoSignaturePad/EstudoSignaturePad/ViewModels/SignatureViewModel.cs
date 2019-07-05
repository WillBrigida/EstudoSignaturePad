using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using SignaturePad.Forms;

namespace EstudoSignaturePad.ViewModels
{
    public class SignatureViewModel : BaseViewModel
    {
        protected SignatureViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : 
            base(navigationService, pageDialogService)
        {

        }

        public DelegateCommand AssinaturaCommand = new DelegateCommand(async () => await OnAssinaturaCommand());

        private async static Task OnAssinaturaCommand()
        {
            var s = new SignaturePadCanvasView();
            Stream stream = await s.GetImageStreamAsync(SignatureImageFormat.Jpeg);
            
        }
    }
}
