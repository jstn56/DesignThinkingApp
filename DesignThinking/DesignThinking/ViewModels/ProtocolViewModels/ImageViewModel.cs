using DesignThinking.Dependecies;
using DesignThinking.Views.Protocol;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Input;
using Plugin.Media;
using System.Threading.Tasks;
using DesignThinking.Interfaces;
using DesignThinking.Business.Service;
using Telerik.XamarinForms.ImageEditor;
using Xamarin.Forms;

namespace DesignThinking.ViewModels.ProtocolViewModels
{
    public class ImageViewModel : BaseViewModel
    {
        private ImagePage imagePage;
        private ImageSource imageSource;
        private ICommand addImage;
        private ICommand safeImage;
        private IProtocolMethodService protocolMethodService;
        private ITaskService taskService;
        Stream source;
        MemoryStream source2;
        

        public ImageViewModel(ImagePage imagePage)
        {
            Title = "Fotoverwaltung";
            this.imagePage = imagePage;
            addImage = new Command(o => AddImageFromGallery());
            safeImage = new Command(o => SafeImage());
            protocolMethodService = new ProtocolMethodService();
            taskService = new TaskService();
        }

        private async void SafeImage()
        {
            if (Parent is ShowProtocolMethodViewModel viewModel)
            {
                await imagePage.Navigation.PopAsync();
                Application.Current.Dispatcher.BeginInvokeOnMainThread(new Action(
                        async () =>
                        {

                            var editor = imagePage.Editor;
                            source2.Position = 0;
                            var streamy = new MemoryStream();
                            await editor.SaveAsync(streamy, ImageFormat.Jpeg, 1);
                            protocolMethodService.SaveImage(viewModel.Model, streamy.ToArray());
                        }));
            }
            if (Parent is ShowTaskViewModel taskviewModel)
            {
                await imagePage.Navigation.PopAsync();
                Application.Current.Dispatcher.BeginInvokeOnMainThread(new Action(
                        async () =>
                        {

                            var editor = imagePage.Editor;
                            source2.Position = 0;
                            var streamy = new MemoryStream();
                            await editor.SaveAsync(streamy, ImageFormat.Jpeg, 1);
                            taskService.SaveImage(taskviewModel.Model, streamy.ToArray());
                        }));
            }
        }

        private async void AddImageFromGallery()
        {
            source = await DependencyService.Get<IPhotoPicker>().GetImageStreamAsync();
            if (source != null)
            {
                
                source2 = new MemoryStream();
                source.CopyTo(source2);
                source.Position = 0;
                imagePage.UNFUCKMYLIFEPLEASE(ImageSource.FromStream(() => source));
            }
            OnPropertyChanged(nameof(ImageSosse));
            
        }


        public ICommand AddImageCommand { get => addImage; set => addImage = value; }
        public ICommand SafeImageCommand { get => safeImage; set => safeImage = value; }

        public ImageSource ImageSosse { get => imageSource; set => imageSource = value; }
    }
}
