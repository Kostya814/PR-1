using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_1
{
    class User
    {
        private string name;
        private string login;
        private string password;
        public User(string Name,string Login, string Passwrod) 
        {
            name = Name;
            login = Login;
            password= Passwrod;
        }
        public bool enter(string login, string password)
        {
            if(this.login == login && this.password == password) return true;
            return false;

        }
        public string getName() 
        {
            return name;
        }

    }
}
