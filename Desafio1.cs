using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la longitud del lado y");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la longitud del lado z");
            double z = double.Parse(Console.ReadLine());

            double t = Math.Sqrt((y * y) + (z * z));
            double c = Math.Acos(y / t) * (180.0 / Math.PI);
            double a = Math.Acos(z / t) * (180.0 / Math.PI);

            Console.WriteLine("La hipotenusa es " + t);
            Console.WriteLine("El angulo c es " + c);
            Console.WriteLine("El angulo a es " + a);
        }
    }
}
