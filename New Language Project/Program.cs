using System;
using System.Text;
namespace New_Language_Project
{
    class Program
    {
     
         static void Main(string[] args)
        {
           
            Meneger one = new Meneger(100, "Meneger1", "parolMeneger01", "Meneger01", "Last_Name Meneger 01",33 );
            Meneger two = new Meneger(200, "Meneger2", "parolMeneger02", "Meneger02", "Last_Name Meneger 02", 50);

           
            Admin admin=new Admin("Admin_Yana","ParolYana","Yana","LName Yana",28);
            admin.Write_file(one);
            admin.Write_file(two);

            // Meneger[] array = admin.Read();

            Client Valera = new Client("Valera_Super", "Valerchik", "Valera", "Super", 40, 100);
            Shuger Hutorok = new Shuger("Hutorok2", 40);
  
            Client Tamara = new Client("Toma-zvezda", "Toma1900", "Toma", "Lubimka", 42, 50000);
           
            Notebook Apple = new Notebook("Apple", 1000);
            Bayraktar Turkiye = new Bayraktar("Фирменный Турецкий", 20000);
            Bed twobed = new Bed("Sweetdream", 4000);

            one.Sale(Valera, Hutorok);
            one.Sale(Tamara, Turkiye);

            one.Read_File();
        }
    }
}
