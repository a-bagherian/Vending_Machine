using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    public class Beverage :  IBeverages
    {
        private string _name;
        private double _price;
        private string _imagePath;
        private List<BeverageItems> _items;


        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public double Price
        {
            get => _price;
            set => _price = value;
        }

        public string ImagePath
        {
            get => _imagePath;
            set => _imagePath = value;
        }

        public List<BeverageItems> Items
        {
            get => _items;
            set => _items = value;
        }
    }
}
