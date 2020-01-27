using REactiveUIXamarinDemo2020.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace REactiveUIXamarinDemo2020.Services
{
    public interface IContactsServices
    {
        IEnumerable<Contact> GetAllContacts();
    }
}
