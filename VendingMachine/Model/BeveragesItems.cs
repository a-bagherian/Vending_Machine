using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    public class BeverageItems :  IBeverageItems
    {
        private string _name;
        private string _imagePath = "Minus";


        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string ImagePath
        {
            get => _imagePath;
            set => _imagePath = value;
        }
    }
}
