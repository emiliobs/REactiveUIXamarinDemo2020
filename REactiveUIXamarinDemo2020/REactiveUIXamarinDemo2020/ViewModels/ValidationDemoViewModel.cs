using ReactiveUI;
using ReactiveUI.Validation.Abstractions;
using ReactiveUI.Validation.Contexts;
using ReactiveUI.Validation.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;

namespace REactiveUIXamarinDemo2020.ViewModels
{
	public class ValidationDemoViewModel : ReactiveObject, IValidatableViewModel
	{
		public ValidationContext ValidationContext { get; } = new ValidationContext();

		private DateTime _birthdate;

		public DateTime BirthDate
		{
			get { return _birthdate; }
			set { _birthdate = value; }
		}

		public ICommand SubmitCommnad { get; }

		public ValidationDemoViewModel()
		{
			this.ValidationRule(vm => vm.BirthDate, value => value > new DateTime(1970,1,1) && value < new DateTime(1999,12,31),
				"Birthday should be  between 1-1-1990 and 2131-1999");

			var isValid = this.IsValid();

			SubmitCommnad = ReactiveCommand.Create(() => 
			{
				Debug.WriteLine($"{BirthDate}  Submitted!");
			});
		}

	}
}
