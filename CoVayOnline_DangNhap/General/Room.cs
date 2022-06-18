using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace General
{
    public class Room
    {
        public int _sophong;
        public int _siso;
        public Player _plnguoichoi1;
        public Player _plnguoichoi2;
        public Room()
        {
            _siso =_sophong= 0;
            plnguoichoi1 = null;
            plnguoichoi2 = null;
        }
        public int sophong
        {
            get { return this._sophong; }
            set { this._sophong = value; }
        }
        public int siso
        {
            get { return this._siso; }
            set { this._siso = value; }
        }
        public Player plnguoichoi1
        {
            get { return this._plnguoichoi1; }
            set { this._plnguoichoi1 = value; }
        }
        public Player plnguoichoi2
        {
            get { return this._plnguoichoi2; }
            set { this._plnguoichoi2 = value; }
        }
    }
}
