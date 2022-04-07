using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Language_Project
{
    class Account
    {

        public string Login { get; set; }
        public string Parol { get; set; }
        public string Name{ get; set; }
        public string Last_Name { get; set; }
      
        public int Age;
        public Account()
        {
            this.Login = "Login";
            this.Parol = "0000";
            this.Name = "Name";
            this.Last_Name = "Last_Name";
 
        }
       
        public Account(string login, string parol, string name, string last_name, int age)
        {
            this.Login = login;
            this.Parol = parol;
            this.Name = name;
            this.Last_Name = last_name;
            this. Age = age;


        }
        
        public override string ToString()
        {
           
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t", Login, Parol,Name,Last_Name,Age);
        }



    }
}
