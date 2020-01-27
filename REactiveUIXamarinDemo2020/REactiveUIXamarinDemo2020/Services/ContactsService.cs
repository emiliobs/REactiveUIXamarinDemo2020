using REactiveUIXamarinDemo2020.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace REactiveUIXamarinDemo2020.Services 
{
    public class  ContactsService : IContactsServices
    {

        private static List<Contact> _samples = new List<Contact>()
        {
           new Contact{ FullaName = "Emilio Barrera", Email = "emilio@gmail.com", Phone= "555555" },
           new Contact{ FullaName = "Emilia Barrera", Email = "emilio@gmail.com", Phone= "555555" },
           new Contact{ FullaName = "Carla Suarez", Email = "carla@gmail.com", Phone= "8951231.20" },
           new Contact{ FullaName = "Nelson Madela", Email = "nelso@gmail.com", Phone= "53248" },
           new Contact{ FullaName = "Lina Hermosa", Email = "lina@gmail.com", Phone= "545478531" },
           new Contact{ FullaName = "Charlene Body", Email = "charlene@gmail.com", Phone= "4543132" },
        };

        public IEnumerable<Contact> GetAllContacts() => _samples;
    }
}
