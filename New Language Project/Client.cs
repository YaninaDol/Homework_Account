using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Language_Project
{
    class Client : Account
    {

        public double Cash { get; set; }

        public Client(string login, string parol, string name, string last_name, int age,double cash) : base(login, parol, name, last_name, age)
        {
            Cash = cash;
        }

        public void Buy(Product Name)
        {
            if (this.Cash >= Name.Price)
            {
                this.Cash -= Name.Price;
            }

        }
        public override string ToString()
        {
            return $"{base.Login}\t";
        }
    }
}
