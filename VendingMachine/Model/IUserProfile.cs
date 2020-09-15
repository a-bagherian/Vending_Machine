using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    public interface IUserProfile
    {
        string Name { get; set; }
        string Password { get; set; }
    }
}
