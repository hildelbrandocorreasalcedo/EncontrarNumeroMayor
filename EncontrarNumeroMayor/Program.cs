using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncontrarNumeroMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno = 0;
            int numeroDos = 0;
            int suma = 0;
            Console.Write("Digite el primer valor: ");
            numeroUno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el seggundo valor: ");
            numeroDos = Convert.ToInt32(Console.ReadLine());
            suma = numeroDos + numeroUno;


            if (numeroUno > numeroDos)
            {
                Console.WriteLine($"El numero mayor es el {numeroUno}");
            }
            else if (numeroUno < numeroDos)
            {
                Console.WriteLine($"Los numero mayor es el {numeroDos}");
            }
            else
            {
                Console.WriteLine($"Los numeros son iguales");
            }

            Console.ReadKey();
        }
    }
}
