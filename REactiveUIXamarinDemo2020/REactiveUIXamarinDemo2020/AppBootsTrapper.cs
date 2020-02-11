using ReactiveUI;
using ReactiveUI.XamForms;
using REactiveUIXamarinDemo2020.Pages;
using REactiveUIXamarinDemo2020.Services;
using REactiveUIXamarinDemo2020.ViewModels;
using Splat;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace REactiveUIXamarinDemo2020
{
    public class AppBootsTrapper : ReactiveObject, IScreen
    {
        public AppBootsTrapper()
        {
            Router = new RoutingState();
            Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));
            RegisterService();
            RegisterViews();
            Router.Navigate.Execute(new FirstViewModel());
        }

        public RoutingState Router { get; }

        public void RegisterService()
        {
            Splat.Locator.CurrentMutable.Register(() => new ContactsService(), typeof(IContactsServices));
        }

        private void RegisterViews()
        {
            Locator.CurrentMutable.Register(() => new FirstPage(), typeof(IViewFor<FirstViewModel>));
            Locator.CurrentMutable.Register(() => new SecondPage(), typeof(IViewFor<SecondViewModel>));
            Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetExecutingAssembly());
        }

        public Page CreateMainPage()
        {

            return new RoutedViewHost();

        }

    }
}
