using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuView : ContentView
    {        
        public MenuView()
        {
            InitializeComponent();
            ButtonLabel.SetBinding(Label.TextProperty, new Binding("ButtonText", source: this));
            ButtonImage.SetBinding(Image.SourceProperty, new Binding("IconImageSource", source: this));

        }

        public static readonly BindableProperty ButtonTextProperty = BindableProperty.Create("ButtonText",
          typeof(string), typeof(MenuView), default(string));

        public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create("IconImageSource",
            typeof(ImageSource), typeof(MenuView), default(ImageSource));

            
        public string ButtonText
        {
            get => (string)GetValue(MenuView.ButtonTextProperty);
            set => SetValue(MenuView.ButtonTextProperty, value);
        }
        public ImageSource IconImageSource
        {
            get => (ImageSource)GetValue(MenuView.ImageSourceProperty);
            set => SetValue(MenuView.ImageSourceProperty, value);
        }



    }
}