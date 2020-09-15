using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Model;

namespace VendingMachine.ViewModel
{
    public class OrderSendViewModel
    {
        public OrderSendViewModel()
        {
        }

        private Beverage _selectedBeverage;

        public Beverage SelectedBeverage
        {
            get => _selectedBeverage;
            set => _selectedBeverage = value;
        }

    }
}

