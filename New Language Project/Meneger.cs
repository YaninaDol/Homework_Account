using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace New_Language_Project
{
    class Meneger:Admin
    {
        public int MySalary { get; set; }

        public Meneger(int mySalary,  string login, string parol, string name, string last_name, int age) : base(login, parol, name, last_name, age)
        {
            MySalary = mySalary;
        }
      
        public Meneger(int mySalary):base()
        {
            MySalary = mySalary;
        }

        public Meneger() : this(0)
        {
        }
        public override string ToString()
        {
            return $"{base.ToString()} {MySalary}\n";
        }

        public void Sale(Client client,Product product)
        {
            client.Buy(product);
            StringBuilder str = new StringBuilder();
            str.Append(DateTime.Now.ToString()+"\t");
            str.Append(client.Login+"\t");
            str.Append(product.ToString());
            File.AppendAllText($"{Login}", str.ToString());
        }

        public void Read_File()
        {
            Console.WriteLine(File.ReadAllText($"{Login}"));
        }


    }
}
