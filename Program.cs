using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appsumaproducto
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, suma, producto;
            string linea;
            Console.WriteLine("programa suma y productos de dos numeros");
            Console.WriteLine("digite numero1");
            linea = Console.ReadLine();
            numero1 = int.Parse(linea);
            Console.WriteLine("digite numero2");
            linea = Console.ReadLine();
            numero2 = int.Parse(linea);
            suma = numero1 + numero2;
            Console.WriteLine("la suma es:" +suma);
            producto = numero1 * numero2;
            Console.WriteLine("el producto es :" + producto);
            Console.ReadKey();
 
        }
    }
}
