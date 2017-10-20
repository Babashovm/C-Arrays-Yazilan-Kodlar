using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Muellim Adi: ");
            var ad = Console.ReadLine();
            Console.Write("Muellim Soyadi: ");
            var soyad = Console.ReadLine();
            Console.Write("Muellimin Yasi: ");
            var yas = Convert.ToInt32(Console.ReadLine());

            

            Teacher[] Muellimler = new Teacher[]{
            new Teacher("Mehemmed","Babashov",26),
            new Teacher("Kamran","Ferzeliyev",22),
            new Teacher("Ehmed","Babashov",24),
            new Teacher(ad,soyad,yas)

        };
            Students[] Telebeler = new Students[]
            {
                new Students("Telebe","Tembelov",0),
                new Students("Tenbel","Telebe",0),
                new Students("Gonbul","Zerbe",1),
                new Students("Redbul","Qanadlanmaq",1),
                new Students("Cumbul","Full",2),
                new Students("Cuppulu","Mull",2),
                new Students("Memmed","Wirvanov",3),
                new Students("Wirvan","Merdanov",3),


            };

            for (int i = 0; i < Telebeler.Length; i++)
            {
                
                
               
                    Console.WriteLine(Muellimler[Telebeler[i].muellim].name + " Muellimin - " + Telebeler[i].name + " Adli Telebesi");
                   
                    
                
                



            }
            System.String adimdir = "Intiqam";

            Console.WriteLine(adimdir);

            

        }
    }
    class Teacher
    {
        public string name;
        public string surname;
        public int age;

        public Teacher(string _name,string _surname,int _age)
        {
            name = _name;
            surname = _surname;
            age = _age;
        }
    }
    class Students
    {
        public string name;
        public string surname;
        public int muellim;
        public Students(string _name,string _surname,int _muellim)
        {
            name = _name;
            surname = _surname;
            muellim = _muellim;

        }
    }
}
