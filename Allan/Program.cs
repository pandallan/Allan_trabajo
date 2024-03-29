﻿using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int opcion = 0;
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.WriteLine("Bienvenido al menú de operaciones:");
            Console.WriteLine("1. Pares e Impares");
            Console.WriteLine("2. Tabla de multiplicar");
            Console.WriteLine("3. Factorial de un número");
            Console.WriteLine("4. Números Primos");
            Console.WriteLine("5. Sucesión de Fibonacci");
            Console.WriteLine("6. Salir");
            Console.Write("Ingrese una opción del 1 al 6: ");

            string? input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        ParesImpares();
                        break;
                    case 2:
                       TablaDeMultiplicar();
                        break;
                    case 3:
                        Factorial();
                        break;
                    case 4:
                        NumerosPrimos();
                        break;
                    case 5:
                        Fibonacci();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número del 1 al 6.");
            }

        } while (opcion != 6); // Continuar hasta que se seleccione la opción 6 (Salir)
    }
// Implementación de las funciones:
        static void ParesImpares()
    {
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.Write("Ingrese un número entero positivo para realizar las operaciones de pares e impares: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int numero))
            {
                Console.WriteLine("Pares: ");
                for (int i = 0; i <= numero; i++)
                {
                    if (i % 2 == 0)
                        Console.Write(i + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Impares: ");
                for (int i = 0; i <= numero; i++)
                {
                    if (i % 2 != 0)
                        Console.Write(i + " ");
                }
                Console.WriteLine();

                int sumaPares = Enumerable.Range(0, numero + 1).Where(x => x % 2 == 0).Sum();
                int sumaImpares = Enumerable.Range(0, numero + 1).Where(x => x % 2 != 0).Sum();
                Console.WriteLine($"Suma de pares: {sumaPares}");
                Console.WriteLine($"Suma de impares: {sumaImpares}");
                Console.WriteLine(sumaPares > sumaImpares ? "La suma de pares es mayor que la suma de impares." : "La suma de impares es mayor que la suma de pares.");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo.");
            }

            Console.Write("¿Desea realizar otra operación en Pares e Impares? (s/n): ");
        } while (Console.ReadLine()?.Trim().ToLower() == "s");

        Console.Clear(); // Limpiar la pantalla antes de salir de la función
    }
static void TablaDeMultiplicar()
    {
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.Write("Ingrese un número entero positivo para mostrar su tabla de multiplicar: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int numero))
            {
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{numero}x{i} = {numero * i}");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo.");
            }

            Console.Write("¿Desea realizar otra operación en Tabla de Multiplicar? (s/n): ");
        } while (Console.ReadLine()?.Trim().ToLower() == "s");

        Console.Clear(); // Limpiar la pantalla antes de salir de la función
    }
static void Factorial()
    {
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.Write("Ingrese un número entero positivo para calcular y mostrar el factorial de ese numero: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int numero))
            {
                int factorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"El factorial de {numero} es {factorial}");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo.");
            }

            Console.Write("¿Desea calcular otro factorial? (s/n): ");
        } while (Console.ReadLine()?.Trim().ToLower() == "s");

        Console.Clear(); // Limpiar la pantalla antes de salir de la función
    }
static void NumerosPrimos()
    {
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.Write("Ingrese la cantidad de iteraciones para las operaciones de numeros primos: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int numero))
            {
                Console.WriteLine("Números primos en orden inverso: ");
                for (int i = numero; i >= 2; i--)
                {
                   //if (EsPrimo(i))
                        Console.Write(i + " ");
                }
                Console.WriteLine();

                var numerosPrimos = Enumerable.Range(2, numero - 1).Where(EsPrimo);
                double media = numerosPrimos.Average();
                double factorialMedia = FactorialDe(media);
                Console.WriteLine($"Media de los números primos: {media}");
                Console.WriteLine($"Factorial de la media {media} es: {factorialMedia}");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo.");
            }

            Console.Write("¿Desea realizar otra operación en Números Primos? (s/n): ");
        } while (Console.ReadLine()?.Trim().ToLower() == "s");

        Console.Clear(); // Limpiar la pantalla antes de salir de la función..
    }

     static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;
        if (numero <= 3)
            return true;
        if (numero % 2 == 0 || numero % 3 == 0)
            return false;
        for (int i = 5; i * i <= numero; i += 6)
        {
            if (numero % i == 0 || numero % (i + 2) == 0)
                return false;
        }
        return true;
    }

    static double FactorialDe(double numero)
    {
        if (numero == 0)
            return 1;
        double factorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
static void Fibonacci()
    {
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.Write("Ingrese la cantidad de iteraciones para la sucesión de Fibonacci: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int iteraciones) && iteraciones > 0)
            {
                int a = 0, b = 1;
                Console.Write("Sucesión de Fibonacci: ");
                for (int i = 0; i < iteraciones; i++)
                {
                    Console.Write(a + " ");
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo mayor que 0.");
            }

            Console.Write("¿Desea generar otra sucesión de Fibonacci? (s/n): ");
        } while (Console.ReadLine()?.Trim().ToLower() == "s");

        Console.Clear(); // Limpiar la pantalla antes de salir de la función
    }
}
