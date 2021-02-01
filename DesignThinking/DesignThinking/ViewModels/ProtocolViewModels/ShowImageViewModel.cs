using DesignThinking.Business.Service;
using DesignThinking.Interfaces;
using DesignThinking.Views.Protocol;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace DesignThinking.ViewModels.ProtocolViewModels
{
    public class ShowImageViewModel : BaseViewModel
    {
        private ShowImagePage showImagePage;
        private IProtocolMethodService protocolMethodService;
        private ITaskService taskService;
        private ImageSource image;
       
        public ShowImageViewModel(ShowImagePage showImagePage, BaseViewModel parent)
        {
            Title = "Foto anzeigen";
            this.showImagePage = showImagePage;
            this.Parent = parent;
            protocolMethodService = new ProtocolMethodService();
            taskService = new TaskService();
            if (Parent is ShowProtocolMethodViewModel viewModel)
            {
                protocolMethodService.LoadImage(viewModel.Model);
                if (viewModel.Model.Image != null)
                {
                var stream = new MemoryStream(viewModel.Model.Image);
                image = ImageSource.FromStream(() => stream);
                OnPropertyChanged(nameof(Image));
                }
            }
            if (Parent is ShowTaskViewModel taskviewModel)
            {
                taskService.LoadImage(taskviewModel.Model);
                if (taskviewModel.Model.Image != null)
                {
                    var stream = new MemoryStream(taskviewModel.Model.Image);
                    image = ImageSource.FromStream(() => stream);
                    OnPropertyChanged(nameof(Image));
                }
            }
        }
        public ImageSource Image { get => image; set => image = value; }
    }
}
