using MVVMSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : TabbedPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        MenuView LastElementSelected = new MenuView();

        public void Button_Clicked(object sender, EventArgs e)
        {
            LastElementSelected.BackgroundColor = Color.White;

            var elementSelected = (MenuView)sender;
            elementSelected.BackgroundColor = Color.Yellow;

            LastElementSelected = elementSelected;

        }
    }
}