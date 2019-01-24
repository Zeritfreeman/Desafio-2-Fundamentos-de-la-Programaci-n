using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la longitud de la hipotenusa ");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el angulo a ");
            double a = double.Parse(Console.ReadLine());

            double c = 90.0 - a;  
            double y = Math.Cos(a * (Math.PI / 180.0)) * t;
            double z = Math.Sin(a * (Math.PI / 180.0)) * t;

            Console.WriteLine("El angulo c es " + c);
            Console.WriteLine("El lado y es " + y);
            Console.WriteLine("El lado z es " + z);
        }
    }
}
