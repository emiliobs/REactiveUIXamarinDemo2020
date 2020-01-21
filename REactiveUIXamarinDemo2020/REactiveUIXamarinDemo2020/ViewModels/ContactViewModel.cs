using ReactiveUI;
using REactiveUIXamarinDemo2020.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;

namespace REactiveUIXamarinDemo2020.ViewModels
{
    public class ContactViewModel : ReactiveObject
    {



        private List<Contact> _samples = new List<Contact>()
        {
           new Contact{ FullaName = "Emilio Barrera", Email = "emilio@gmail.com", Phone= "555555" },
           new Contact{ FullaName = "Carla Suarez", Email = "carla@gmail.com", Phone= "8951231.20" },
           new Contact{ FullaName = "Nelson Madela", Email = "nelso@gmail.com", Phone= "53248" },
           new Contact{ FullaName = "Lina Hermosa", Email = "lina@gmail.com", Phone= "545478531" },
           new Contact{ FullaName = "Charlene Body", Email = "charlene@gmail.com", Phone= "4543132" },
        };

        public ContactViewModel()
        {
            Contacts = new ObservableCollection<Contact>(_samples);

            this.WhenAnyValue(vm => vm.SearchQuery)
                .Throttle(TimeSpan.FromSeconds(1))
                .Subscribe(query =>
                {
                    var filteredContacts = _samples.Where(c => c.FullaName.ToLower().Contains(query) || 
                                            c.Phone.Contains(query) || 
                                            c.Email.Contains(query)).ToList();

                    Contacts = new ObservableCollection<Contact>(filteredContacts);
                });
        }


        #region Properties

        private string _searchQuery = string.Empty;

        public string SearchQuery
        {
            get { return _searchQuery; }
            set { this.RaiseAndSetIfChanged(ref _searchQuery, value); }
        }

        private ObservableCollection<Contact> _contacts;

        public ObservableCollection<Contact> Contacts
        {
            get { return _contacts; }
            set { this.RaiseAndSetIfChanged(ref _contacts, value); }
        }



        #endregion


    }

}
