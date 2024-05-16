using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerWatcher
{
    class User
    {
        public string Name { get; private set; }
        public string Password { get; private set; }
        public Boolean Admin { get; private set; }
        public User(string N, string P, Boolean A)
        {
            Name = N;
            Password = P;
            Admin = A;
        }
    }
    
}
