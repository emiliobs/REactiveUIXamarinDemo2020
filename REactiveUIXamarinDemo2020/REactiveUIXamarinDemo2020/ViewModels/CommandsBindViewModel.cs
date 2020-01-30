using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;

namespace REactiveUIXamarinDemo2020.ViewModels
{
    public class CommandsBindViewModel : ReactiveObject
    {
        public ICommand TestCommand { get;  }

        public CommandsBindViewModel()
        {
            TestCommand = ReactiveCommand.Create(() => 
            {
                    Debug.WriteLine("Command Executed");
            });
        }
    }
}
