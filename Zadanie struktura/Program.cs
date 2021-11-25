using System;

namespace Zadanie_struktura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу решения уравнения вида 0=kx+b");
            Console.WriteLine("Введите коэфициент k, затем нажмите Enter");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите коэфициент b, затем нажмите Enter");
            decimal c = Convert.ToDecimal(Console.ReadLine());
            Uravnenie v;
            v.k = a;
            v.b = c;
            v.Root();
            Console.WriteLine("Спасибо, что использовали нашу программу, для выхода нажмите Enter");
            Console.ReadKey();

        }
    }


    struct Uravnenie
    {
        public decimal k;
        public decimal b;
        public void Root()
        {
            decimal х = -b / k;
            Console.WriteLine("Значение x равно {0:f2}", Math.Round(х,2));
        }
        
    }
}
