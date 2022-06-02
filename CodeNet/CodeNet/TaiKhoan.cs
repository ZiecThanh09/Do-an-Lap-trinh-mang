using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangNhap
{
    class Account
    {
        private string userName;
        private string password;

        public Account() { }

        public Account(string user, string pass)
        {
            this.userName = user;
            this.password = pass; 
        }
    }
}
