using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangNhap
{
    internal class Room
    {
        private int ID;
        private string host;
        private string type;
        private string password;
        private int quantity;

        public Room() { }

        public Room (int id, string cp, string lp, string password, int sn)
        {
            this.ID = id;
            this.host = cp;
            this.type = lp;
            this.password = password;
            this.quantity = sn;
        }
    }
}
