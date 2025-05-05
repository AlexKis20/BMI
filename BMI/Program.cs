using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            var istvan = new Ember("Balázs István",1995,"Férfi",183,78);
            istvan.Kiir();

            var ildiko = new Ember("Tóth Ildikó",1990,"Nő",160,56);
            ildiko.Kiir();

            Console.ReadKey();
        }
    }
}
