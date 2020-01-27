﻿using ReactiveUI;
using REactiveUIXamarinDemo2020.Models;
using REactiveUIXamarinDemo2020.Services;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;

namespace REactiveUIXamarinDemo2020.ViewModels
{
    public class ContactViewModel : ReactiveObject
    {
        private IContactsServices _contactsService;

        public ContactViewModel(IContactsServices contactsService = null)
        {
            _contactsService = contactsService ?? (IContactsServices)Splat.Locator.Current.GetService(typeof(IContactsServices));

            var allContacts = _contactsService.GetAllContacts();
            _contacts = new ObservableCollection<Contact>(allContacts);

            this.WhenAnyValue(vm => vm.SearchQuery)
                .Throttle(TimeSpan.FromSeconds(1))
                .Subscribe(query =>
                {
                    var filteredContacts = allContacts.Where(c => c.FullaName.ToLower().Contains(query) || c.Phone.Contains(query) || c.Email.Contains(query)).ToList();

                    Contacts = new ObservableCollection<Contact>(filteredContacts);
                });

            this.WhenAnyValue(vm => vm.Contacts)
                .Select(conacts =>
                {
                    if (Contacts.Count == allContacts.Count())
                        return "No filters applied";

                    return $"{Contacts.Count} have been found in result for '{SearchQuery}'";
                })
                .ToProperty(this, vm => vm.SearchResult, out _searchResult);

            //ClearCommand = ReactiveCommand.Create(ClearSearch);
        }

        #region Properties

        private string _searchQuery = string.Empty;

        public string SearchQuery
        {
            get { return _searchQuery; }
            set { this.RaiseAndSetIfChanged(ref _searchQuery, value); }
        }

        private readonly ObservableAsPropertyHelper<string> _searchResult;

        public string SearchResult => _searchResult.Value;



        private ObservableCollection<Contact> _contacts;

        public ObservableCollection<Contact> Contacts
        {
            get { return _contacts; }
            set { this.RaiseAndSetIfChanged(ref _contacts, value); }
        }



        #endregion


    }

}
