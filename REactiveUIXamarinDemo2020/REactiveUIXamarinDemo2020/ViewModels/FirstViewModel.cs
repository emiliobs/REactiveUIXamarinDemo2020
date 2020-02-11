﻿using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace REactiveUIXamarinDemo2020.ViewModels
{
   public class FirstViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => "First Page";

        public IScreen HostScreen { get; }

        public FirstViewModel(IScreen screen = null)
        {
            HostScreen = screen ?? Locator.Current.GetService<IScreen>();

            NavigateCommand = ReactiveCommand.CreateFromObservable(() => 
            {
                return HostScreen.Router.Navigate.Execute(new SecondViewModel(Message));
            });
        }

        private string _message = string.Empty;

        public string Message                
        {
            get => _message; 
            set { this.RaiseAndSetIfChanged(ref _message , value); }
        }

        public ICommand NavigateCommand { get; } 

    }
}
