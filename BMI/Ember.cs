using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    public class Ember
    {
        public string Nev { get; set; }
        public int SzulEv { get; set; }
        public string Nem { get; set; }
        public int Magassag { get; set; }
        public int Suly { get; set; }

        public Ember(string nev, int szulEv, string nem, int magassag, int suly)
        {
            Nev = nev;
            SzulEv = szulEv;
            Nem = nem;
            Magassag = magassag;
            Suly = suly;
        }
        public int Eletkor()
        {
            return DateTime.Now.Year - SzulEv;
        }
        public double AtalakitMagassag()
        {
            return 1.0*Magassag / 100;
        }
        public double TestTomegIndex()
        {
            return 1.3*Suly / Math.Pow(AtalakitMagassag(),2.5);
        }
        public void BMITabla()
        {
            double bmi = TestTomegIndex();
            switch (bmi)
            {
                case double i when i>0 && i<16:
                    Console.WriteLine("Súlyos soványság!\n");
                    break;
                case double i when i >= 16 && i < 16.99:
                    Console.WriteLine("Mérsékelt soványság!\n");
                    break;
                case double i when i >= 17 && i < 18.49:
                    Console.WriteLine("Enyhe soványság!\n");
                    break;
                case double i when i >= 18.5 && i < 24.99:
                    Console.WriteLine("Normális testsúly!\n");
                    break;
                case double i when i >= 25 && i < 29.99:
                    Console.WriteLine("Túlsúlyos!\n");
                    break;
                case double i when i >= 30 && i < 34.99:
                    Console.WriteLine("I. fokú elhízás!");
                    break;
                case double i when i >= 35 && i < 39.99:
                    Console.WriteLine("II. fokú elhízás!\n");
                    break;
                case double i when i >= 40:
                    Console.WriteLine("III. fokú(súlyos) elhízás!\n");
                    break;
            }
        }

        
        
        public void Kiir()
        {
            Console.WriteLine($"{Nev}, {SzulEv}, {Nem}, {Magassag}, {Suly}");
            Console.WriteLine($"Életkor: {Eletkor()}");
            Console.WriteLine($"Magasság(m): {AtalakitMagassag()}");
            Console.WriteLine($"Testtömeg-index: {TestTomegIndex()}");
            Console.Write($"Kiértékelés(BMI): ");
            BMITabla();
        }
    }
}
