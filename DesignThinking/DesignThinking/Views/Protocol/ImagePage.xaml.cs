using DesignThinking.ViewModels;
using DesignThinking.ViewModels.ProtocolViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.ImageEditor;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesignThinking.Views.Protocol
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage(BaseViewModel parent)
        {
            InitializeComponent();
            BindingContext = new ImageViewModel(this) { Parent = parent };
        }

        public void UNFUCKMYLIFEPLEASE(ImageSource source)
        {
            imageEditor.Source = source;
        }
        public RadImageEditor Editor { get => imageEditor; }


    }
}