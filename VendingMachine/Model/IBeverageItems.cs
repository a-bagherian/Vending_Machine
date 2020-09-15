using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    public interface IBeverageItems
    {
        string Name { get; set; }
        string ImagePath { get; set; }
    }
}
