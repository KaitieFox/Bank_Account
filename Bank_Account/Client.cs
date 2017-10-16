using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Client
    {
        //fields
        private string name;
        private string username;
        private int usernumber;

        //properties
        public string Name
        {
            get { return this.name; }
        }

        public string Username
        {
            get { return this.username; }
        }

        public int Usernumber
        {
            get { return this.usernumber; }
        }

        //Constructors
        public Client()
        {

        }
        public Client(string name, string username, int usernumber)
        {
            this.name = name;
            this.username = username;
            this.usernumber = usernumber;
        }

        //methods

        public void GetInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(username);
            Console.WriteLine(usernumber);
        }
        
    }
}
