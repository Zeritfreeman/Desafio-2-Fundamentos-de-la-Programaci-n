using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la longitud del lado z ");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el angulo c ");
            double c = double.Parse(Console.ReadLine());

            double a = 90.0 - c;
            double t = z / Math.Sin(c * (Math.PI / 180.0));
            double y = Math.Sqrt((t * t) - (z * z));

            Console.WriteLine("El angulo a es " + a);
            Console.WriteLine("La hipotenusa es " + t);
            Console.WriteLine("El lado y es " + y);
        }
    }
}
