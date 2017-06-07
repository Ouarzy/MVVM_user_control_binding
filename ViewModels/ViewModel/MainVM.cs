using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Data.Common;
using System.ComponentModel;

namespace ViewModels.ViewModel
{
    class MainVM : ObservableObject
    {
        private readonly string _title = "CUSTOMERS";
        private  CustomersVM _customerVM;
     

        public string Title { get { return _title; } }
        

        public MainVM()
        {
            Customer = new CustomersVM();
            SelectedMain = Customer;
        }

        public CustomersVM Customer
        {
            get { return _customerVM; }
            private set { _customerVM = value; }
        }

    

        public VmWithSelectedObject _selectedMain;
        public VmWithSelectedObject SelectedMain
        {
            get { return _selectedMain; }
            set
            {
                if (value != _selectedMain)
                {
                    _selectedMain = value;
                    RaisePropertyChangedEvent();
                }
            }
        }

        public ICommand NavigationCommand
        {
            get { return new DelegateCommand(Navigate); }
        }

        public void Navigate(object obj)
        {
            switch (obj.ToString())
            {
                case "0":
                    SelectedMain = Customer;
                    break;
                case "1":
                   
                    break;
            }
            
        }
    }
}
