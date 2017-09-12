using Demo.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Core
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomersMaster : ContentPage
    {
        public ListView ListView;

        public CustomersMaster()
        {
            InitializeComponent();

            BindingContext = new CustomersMasterViewModel();
            ListView = MenuItemsListView;
        }

        class CustomersMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<CustomersMenuItem> MenuItems { get; set; }

            public CustomersMasterViewModel()
            {
                var cs = DemoContainer.Resolve<CustomerService>();
                var customers = cs.GetAll();

                MenuItems = new ObservableCollection<CustomersMenuItem>();

                foreach (var customer in customers)
                {
                    MenuItems.Add(new CustomersMenuItem() { Id = customer.Id, Title = customer.Name });
                }
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion

        }
    }
}