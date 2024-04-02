using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13
{
    internal class User
    {
        public static List<User> Users = new List<User>();
        public string Login { get; set; }
        public int Password { get; set; }
     
        public User(string _Login, int _Password)
        {
            Login = _Login;
            Password = _Password;
            Users.Add(this);
        }
    }
}
