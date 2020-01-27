using REactiveUIXamarinDemo2020.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace REactiveUIXamarinDemo2020
{
    public class AppBootsTrapper
    {
        public AppBootsTrapper()
        {
            RegisterService();
        }

        public void RegisterService()
        {
            Splat.Locator.CurrentMutable.Register(() => new ContactsService(), typeof(IContactsServices));
        }

    }
}
