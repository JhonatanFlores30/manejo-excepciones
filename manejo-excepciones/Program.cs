using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            try
            {
                Console.Write("Ingresa el número que quieres elevar: ");
                numero = int.Parse(Console.ReadLine());

                Console.WriteLine("El cuadrado del numero es: " + Math.Pow(numero, 2));
            }
            catch(FormatException x)
            {
                Console.WriteLine(x.Message);
            }
            catch(OverflowException x)
            {
                Console.WriteLine(x.Message);
            }
            Console.ReadKey();
        }
    }
}
