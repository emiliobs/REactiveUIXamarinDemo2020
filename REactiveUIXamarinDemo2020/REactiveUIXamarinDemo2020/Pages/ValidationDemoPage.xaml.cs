using ReactiveUI;
using ReactiveUI.Validation.Extensions;
using ReactiveUI.XamForms;
using REactiveUIXamarinDemo2020.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace REactiveUIXamarinDemo2020.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ValidationDemoPage : ReactiveContentPage<ValidationDemoViewModel>
    {
        public ValidationDemoPage()
        {
            InitializeComponent();

            BindingContext = ViewModel = new ValidationDemoViewModel();

            this.WhenActivated(d => 
            {
            this.BindValidation(ViewModel, vm => vm.BirthDate, page => page.validationLabel.Text).DisposeWith(d);

            });
        }
    }
}