using ViewModels.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModels.Factory;

namespace ViewModels.ViewModel
{
    class CustomersVM : ObservableObject
    {
        private string _searchText;
        private CustomerVm _selectedCustomer;
        private readonly ObservableCollection<CustomerVm> _customers = new ObservableCollection<CustomerVm>(DatabaseMaster.GetCustomers().Select(c => new CustomerVm(c)));
        public string Title = "Customers";

        public CustomersVM()
        {

        }

        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                RaisePropertyChangedEvent();
            }
        }

        public CustomerVm SelectedCustomer
        {
            get { return _selectedCustomer; }
            set
            {
                _selectedCustomer = value;
                RaisePropertyChangedEvent("SelectedCustomer");
            }
        }

        public IEnumerable<CustomerVm> Customers
        {
            get { return _customers; }
        }



        public ICommand LoadCustomersCommand
        {
            get { return new DelegateCommand(LoadCustomers); }
        }

        public void LoadCustomers(object obj)
        {


        }
    }

    class CustomerVm : ObservableObject
    {
        private int _id;
        private string _name;
        private string _phone;
        private string _email;
        private string _address1;
        private string _address2;
        private string _town;
        private string _county;
        private string _postcode;

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                RaisePropertyChangedEvent();
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChangedEvent();
            }
        }

        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                RaisePropertyChangedEvent();
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                RaisePropertyChangedEvent();
            }
        }

        public string Address1
        {
            get { return _address1; }
            set
            {
                _address1 = value;
                RaisePropertyChangedEvent();
            }
        }

        public string Address2
        {
            get { return _address2; }
            set
            {
                _address2 = value;
                RaisePropertyChangedEvent();
            }
        }

        public string Town
        {
            get { return _town; }
            set
            {
                _town = value;
                RaisePropertyChangedEvent();
            }
        }

        public string County
        {
            get { return _county; }
            set
            {
                _county = value;
                RaisePropertyChangedEvent();
            }
        }

        public string Postcode
        {
            get { return _postcode; }
            set
            {
                _postcode = value;
                RaisePropertyChangedEvent();
            }
        }

        public CustomerVm(Customer customer)
        {
            Id = customer.id;
            Name = customer.name;
            Phone = customer.phone;
            Email = customer.email;
            Address1 = customer.address1;
            Address2 = customer.address2;
            Town = customer.town;
            County = customer.county;
            Postcode = customer.postcode;
        }
    }
}