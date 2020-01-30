using REactiveUIXamarinDemo2020.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace REactiveUIXamarinDemo2020
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            new AppBootsTrapper();

            //MainPage = new MainPage();
           // MainPage = new NavigationPage(new ColorsDemoPage());
            MainPage = new NavigationPage(new ContactPage());
            MainPage = new NavigationPage(new  CommadBindPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
