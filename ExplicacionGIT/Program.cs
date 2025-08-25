using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;
        //Eduardo Corrales Iturbe
        do
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ DE OPCIONES ===");
            Console.WriteLine("1. Comparar dos números");
            Console.WriteLine("2. Tabla de multiplicar");
            Console.WriteLine("3. Suma de números pares del 1 al 20");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CompararNumeros();
                    break;
                case 2:
                    TablaMultiplicar();
                    break;
                case 3:
                    SumaNumerosPares();
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            if (opcion != 4)
            {
                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 4);
    }

    static void CompararNumeros()
    {
        Console.WriteLine("Introduce el primer número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine($"Mayor: {num1}");
        }
        else if (num1 < num2)
        {
            Console.WriteLine($"Mayor: {num2}");
        }
        else
        {
            Console.WriteLine("Son iguales");
        }
    }

    static void TablaMultiplicar()
    {
        Console.WriteLine("¿De qué número quieres la tabla de multiplicar?");
        int tabla = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{tabla} x {i} = {tabla * i}");
        }
    }

    static void SumaNumerosPares()
    {
        int num = 1;
        int suma = 0;

        Console.WriteLine("Números pares del 1 al 20:");

        while (num <= 20)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
                suma += num;
            }
            num++;
        }

        Console.WriteLine($"La suma de los números pares es: {suma}");
    }
}
