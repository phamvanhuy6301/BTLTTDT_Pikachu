using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pikachu
{
    class NguoiChoi   
    {
        //properties
        //private string _id;
        //public string id
        //{
        //    get { return _id; }
        //    set { _id = value; }
        //}
        private string _user;
        public string user
        {
            get { return _user; }
            set { _user = value; }
        }
        private string _sex;
        public string sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        private int _age;
        public int age
        {
            get { return _age; }
            set { _age = value; }
        }
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _email;
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        private int _record;
        public int record
        {
            get { return _record; }
            set { _record = value; }
        }
        //constructor
        public NguoiChoi()
        {
        }
        public NguoiChoi(string sex, int age, string name, string email)
        {
            //dùng cho nút sửa
            _sex = sex;
            _age = age;
            _name = name;
            _email = email;
        }
        public NguoiChoi(string user, string sex, int age, string name, string email, int record)
        {
            //id sinh tự động
            _user = user;
            _sex = sex;
            _age = age;
            _name = name;
            _email = email;
            _record = record;
        }
    }
}
