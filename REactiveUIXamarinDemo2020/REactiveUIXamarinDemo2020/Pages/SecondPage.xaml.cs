using ReactiveUI;
using ReactiveUI.XamForms;
using REactiveUIXamarinDemo2020.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace REactiveUIXamarinDemo2020.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ReactiveContentPage<SecondViewModel>
    {
        public SecondPage()
        {
            InitializeComponent();

            BindingContext = ViewModel = new SecondViewModel(null);
        }
    }
}