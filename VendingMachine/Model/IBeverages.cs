using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    public interface IBeverages
    {
        string Name { get; set; }
        double Price { get; set; }
        string ImagePath { get; set; }
        List<BeverageItems> Items { get; set; }
    }
}
