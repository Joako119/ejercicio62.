using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio62.numprimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, contador, primo;
            bool salida;

            salida = true;
            contador = 0;
            primo = 0;
            do
            {
                Console.WriteLine("ingresar numero o si desea salir ingresar 0");
                num = int.Parse(Console.ReadLine());



                if (num == 0)

                { salida = false; }
                
                else if (num % (2) == 1)
                {
                    Console.WriteLine("el numero es primo");
                    primo = primo + 1;
                }



                else
                    Console.WriteLine("el numero ingresado no es primo");
            }


            while (salida);
            Console.WriteLine($"se ingresaron {primo} numeros primo");
        }
    }
}
