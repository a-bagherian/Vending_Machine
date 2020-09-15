using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Model;

namespace VendingMachine.ViewModel
{
    public class BeveragesViewModel
    {
        public BeveragesViewModel()
        {
            LoadData();
        }

        public ObservableCollection<Beverage> Beverages
        {
            get;
            set;
        }
        private Beverage _selectedBeverage;

        public void LoadData()
        {
            ObservableCollection<Beverage> beverages = new ObservableCollection<Beverage>();

            beverages.Add(new Beverage
            {
                Name = "Hot Chocolate",
                Price = 10,
                ImagePath = "/VendingMachine;component/assets/hot_chocolate.jpg",
                Items = new List<BeverageItems>
                {
                    new BeverageItems { Name= "Boil water" },
                    new BeverageItems { Name= "Add drinking chocolate to cup" },
                    new BeverageItems { Name= "Add water" }
                }
            });
            beverages.Add(new Beverage
            {
                Name = "Coffee",
                Price = 15,
                ImagePath = "/VendingMachine;component/assets/white_coffee.jpg",
                Items = new List<BeverageItems>
                {
                    new BeverageItems { Name= "Boil water" },
                    new BeverageItems { Name= "Add sugarp" },
                    new BeverageItems { Name= "Add coffee granules to cup" },
                    new BeverageItems { Name= "Add water" },
                    new BeverageItems { Name= "Add milk" }
                }
            });
            beverages.Add(new Beverage
            {
                Name = "Lemon Tea",
                Price = 18,
                ImagePath = "/VendingMachine;component/assets/lemon_tea.jpg",
                Items = new List<BeverageItems>
                {
                    new BeverageItems { Name= "Boil water" },
                    new BeverageItems { Name= "Add water" },
                    new BeverageItems { Name= "Steep tea bag in hot water" },
                    new BeverageItems { Name= "Add lemon" }
                }
            });
            beverages.Add(new Beverage
            {
                Name = "Iced Coffee",
                Price = 20,
                ImagePath = "/VendingMachine;component/assets/iced_coffee.jpg",
                Items = new List<BeverageItems>
                {
                    new BeverageItems { Name= "Crush Ice" },
                    new BeverageItems { Name= "Add ice to blender" },
                    new BeverageItems { Name= "Add coffee syrup to blender" },
                    new BeverageItems { Name= "Blend ingredients" },
                    new BeverageItems { Name= "Add ingredients" }
                }
            });

            Beverages = beverages;
        }

        public Beverage SelectedBeverage
        {
            get => _selectedBeverage;
            set => _selectedBeverage = value;
        }
    }
}

