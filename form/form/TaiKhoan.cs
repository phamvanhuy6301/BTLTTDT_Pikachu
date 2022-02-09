using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pikachu
{
    class TaiKhoan
    {
        //properties
        private string _user;
        public string user
        {
            get { return _user; }
            set { _user = value; }
        }
        private string _password;
        public string password
        {   
            get { return _password; }
            set { _password = value; }
        }
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        //constructor
        public TaiKhoan()
        {
        }
        public TaiKhoan(string name)
        {
            _name = name;
        }
        public TaiKhoan(string user, string password, string name)
        {
            _user = user;
            _password = password;
            _name = name;
        }
    }
}
