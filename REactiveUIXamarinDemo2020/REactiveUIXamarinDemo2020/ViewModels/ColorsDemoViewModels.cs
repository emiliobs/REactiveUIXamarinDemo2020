using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace REactiveUIXamarinDemo2020.ViewModels
{
    public class ColorsDemoViewModels : ReactiveObject
    {
        #region Properties
        private int _red;

        public int Red
        {
            get { return _red; }
            set { this.RaiseAndSetIfChanged(ref _red, value); this.RaisePropertyChanged(nameof(BackgroundColor)); }
        }

        private int _gree;

        public int Green
        {
            get { return _gree; }
            set { this.RaiseAndSetIfChanged(ref _gree, value); this.RaisePropertyChanged(nameof(BackgroundColor)); }
        }

        private int _blue;

        public int Blue
        {
            get { return _blue; }
            set { this.RaiseAndSetIfChanged(ref _blue, value); this.RaisePropertyChanged(nameof(BackgroundColor)); }
        }


        public Color BackgroundColor => Color.FromArgb(Red, Green, Blue);


        #endregion

        #region Methods



        #endregion
    }
}
