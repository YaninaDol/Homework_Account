using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace New_Language_Project
{
    class Admin:Account
    {
        public string Path { get; set; }
        public int size = 0;

        public Admin( string login, string parol, string name, string last_name, int age) : base( login,  parol,  name, last_name, age)
        {

            this.Path = $"{ this.Login}  .txt";
        }

        public Admin()
        {        
            this.Path =$"{ this.Login}  .txt";
        }

        public Meneger[]   Read()
        {
            string info = File.ReadAllText(Path);

            string[] res = info.Split("\n");
           
            Meneger[] menegers = new Meneger[res.Length-1];
            int n = 0;
            for (int i = 0; i < res.Length-1; i++)
            {
                string[] cut = res[i].Split("\t");

                string Login = cut[n];
                string Parol = cut[n + 1];
                string Name = cut[n + 2];
                string L_Name = cut[n + 3];
                int salary = Convert.ToInt32(cut[n + 5]);
                int age= Convert.ToInt32(cut[n + 4]);

                
                
                Meneger one = new Meneger(salary, Login, Parol, Name, L_Name, age);
                menegers[size] = one;
                this.size++;
               
            }
            return menegers;
        }
        public void Change_parol(Meneger meneger1,string parol)
        {
            meneger1.Parol=parol;
        }
        public void Change_login(Meneger meneger1, string login)
        {
            meneger1.Login = login;
        }
        public override string ToString()
        {
            return $"{base.ToString()}";
        }
        public void Write_file(Meneger meneger1)
        {
            
                File.AppendAllText(Path, meneger1.ToString());
            
        }



    }
}
