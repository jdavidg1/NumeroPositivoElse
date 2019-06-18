using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPositivoElse
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero = 0;

            Console.WriteLine("Escribe un número para definir si es positivo o negativo");

            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine("El numero {0} es mayor que cero", numero);
            }

            else
            {
                Console.WriteLine("El número {0} es menor que cero", numero);
            }

            Console.ReadKey();
        }
    }
}
