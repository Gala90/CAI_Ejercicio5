using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
           int i;
           string numero;
           char[] array2 = new char[5];

            Console.WriteLine("Ingrese un numeros de 5 cifras: ");
            numero = Console.ReadLine();

            char[] array1 = numero.ToCharArray();

            if (array1.Length == 5)
            {
                 for (i = 0; i < 5; i++)
                 {
                     array2[i] = array1[array1.Length - i - 1];
                 }

                Console.WriteLine(array2);


            } else
            {
                Console.WriteLine("Valor ingresado incorrecto");
            }


            Console.ReadKey();
        }
    }
}
