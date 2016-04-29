using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunkOS.System
{
    class User
    {
        private string _username;
        private string _password;
        private int _rank;
        public User(string username,string password, int rank)
        {
            _password = password;
            _username = username;
            _rank = rank;
            
        }

        public string Username() { return _username; }
        public string Password() { return _password; }
        public int rank() { return _rank; }

    }
}
