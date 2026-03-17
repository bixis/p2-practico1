using System.Runtime.CompilerServices;

namespace Practico_1_P2;


class Program
{
    static void Main(string[] args)
    {
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("Hola! Bienvenido a mi práctico 1 de Programación 2");
            Console.WriteLine("Estamos aprendiendo C#, por el momento trabajamos con console apps.");
            Console.WriteLine("Julián Linares - código disponible en https://www.github.com/bixis/p2-practico1");
            Console.WriteLine("");
            Console.WriteLine("Qué ejercicio desea ver?");
            Console.WriteLine("");
            Console.WriteLine("1- Ejercicio 1 - 'Adivine el número random'");
            Console.WriteLine("0- Salir");

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    EjercicioUno();
                    break;
                case "0":
                    salir = true;
                    break;
            }
        }
    }
    
    
    // Ejercicio 1.
    // Solicitar números hasta que ingrese el 0 (fin del ingreso).
    // Se debe comparar con un número random e indicar cuando son iguales.
    static void EjercicioUno()
    {
        Random randomObjeto = new Random();
        int randomEntero = randomObjeto.Next(1,11); // Excluyo 0 porque lo utilizamos para salir del programa, del 1 al 10 para simplificar.
        string random = randomEntero.ToString();
        bool salirDelEjericio = false;
        
        Console.WriteLine("Ingrese un número hasta que coincida con el número random.");
        Console.WriteLine("Ingrese 0 para salir del ejercicio");
        
        while (!salirDelEjericio)
        {
            string numeroIngresado = Console.ReadLine();

            if (numeroIngresado == random)
            {
                Console.WriteLine($"Usted adivinó el número {random} correctamente!");   
            }
            else if (numeroIngresado == "0")
            {
                salirDelEjericio = true;
            }
            else
            {
                Console.WriteLine("Número incorrecto, siga intentando o ingrese 0 para salir.");
            }
        }

    }
}