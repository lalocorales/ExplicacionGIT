using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicacionGIT
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Console.WriteLine("numero1");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("numero2");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //if (num1 > num2)
            //{
            //    Console.WriteLine($"Mayor {num1}");

            //}
            //else if (num1 < num2)
            //{
            //    Console.WriteLine($"mayor {num2}");
            //}
            //else
            //{
            //    Console.WriteLine("Son iguales");
            //}


            //Console.WriteLine("Dame la tabla de multiplicar");
            //int tabla = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{tabla} x {i}={tabla*i}");
            //}
            int num = 1;
            int suma = 0;
            while (num <= 20)
            {
                if (num % 2 == 0)
                {
                    //ESTO ES PAR
                    Console.WriteLine(num);
                    //sumar numeros pares
                    suma = suma + num;
                }
                num++;
            }
            Console.WriteLine($"la suma es:{suma}");

            Console.ReadKey();
        }
    }
}

