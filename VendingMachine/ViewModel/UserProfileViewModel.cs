using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Model;

namespace VendingMachine.ViewModel
{
    public class UserProfileViewModel
    {
        public UserProfileViewModel()
        {
            UserProfile user = new UserProfile { Name = "Elloit A.", Password = "123456" };
            CurrentUser = user;
        }

        private UserProfile _currentuser;

        public UserProfile CurrentUser
        {
            get => _currentuser;
            set => _currentuser = value;
        }

    }
}

