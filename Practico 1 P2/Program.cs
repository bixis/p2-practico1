using System; // Tuve que agregar esta linea porque el código tenia muchos errores, no la vi en clase pero la busqué en google.
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
            Console.WriteLine("2- Ejercicio 2 - 'Ver tabla de multiplicación'");
            Console.WriteLine("2- Ejercicio 3 - 'Ver números pares en rango dado'");
            Console.WriteLine("0- Salir");

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    EjercicioUno();
                    break;
                case "2":
                    EjercicioDos();
                    break;
                case "3":
                    EjercicioTres();
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
        int randomEntero = randomObjeto.Next(1, 11); // Excluyo 0 porque lo utilizamos para salir del programa, del 1 al 10 para simplificar.
        string random = randomEntero.ToString();
        bool salirDelEjercicio = false;


        Console.WriteLine("");
        Console.WriteLine("Ingrese un número hasta que coincida con el número random.");
        Console.WriteLine("Ingrese 0 para salir del ejercicio");
        Console.WriteLine("");

        while (!salirDelEjercicio)
        {
            string numeroIngresado = Console.ReadLine();

            if (numeroIngresado == random)
            {
                Console.WriteLine($"Usted adivinó el número {random} correctamente!");
                Console.WriteLine("");
                break;
            }
            else if (numeroIngresado == "0")
            {
                salirDelEjercicio = true;
            }
            else
            {
                Console.WriteLine("Número incorrecto, siga intentando o ingrese 0 para salir.");
            }
        }

    }


    // Ejercicio 2.
    // Solicitar números hasta que ingrese el 0 (fin del ingreso).
    // Se debe mostrar la tabla del mismo.
    static void EjercicioDos()
    {
        bool salirDelEjercicio = false;


        Console.WriteLine(" ");
        Console.WriteLine("Ingrese un número para ver su tabla de multiplicación.");
        Console.WriteLine("Ingrese 0 para salir del ejercicio.");
        Console.WriteLine(" ");

        while (!salirDelEjercicio)
        {
            string numeroIngresado = Console.ReadLine();
            int numeroIngresadoEntero = 0;
            bool ok = int.TryParse(numeroIngresado, out numeroIngresadoEntero);

            if (!ok)
            {
                Console.WriteLine("Usted debe dar un string!");
                Console.WriteLine(" ");
                break;
            }
            else if (numeroIngresadoEntero == 0)
            {
                salirDelEjercicio = true;
                break;
            }
            else if (numeroIngresadoEntero != 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Tabla del {numeroIngresado}");
                Console.WriteLine(" ");
                for (int i = 1; i < 10; i++) // tampoco lo vimos en clase pero lo busqué para simplificar.
                {
                    Console.WriteLine($"{numeroIngresadoEntero} x {i} = {(numeroIngresadoEntero * i)}");
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                break;
            }
        }

    }


    // Ejercicio 3
    // Solicitar dos números (controlar que el primer número sea menor al segundo) y muestre todos los números entre los valores ingresados que sean pares. Para salir se debe ingresar 0.
    // CONTROLAR LOS STRING INPUTS CON TRYPARSE
    static void EjercicioTres()
    {
        bool salirDelEjercicio = false;
        
        Console.WriteLine("Ingrese el menor de los dos numeros a ingresar (0 para salir)");
        string numeroUnoStr = Console.ReadLine();
        Console.WriteLine("Ingrese el mayor de los dos numeros a ingresar (0 para salir)");
        string numeroDosStr = Console.ReadLine();
        bool okUno = int.TryParse(numeroUnoStr, out int numeroUno);
        bool okDos = int.TryParse(numeroDosStr, out int numeroDos);

        while (!salirDelEjercicio)
        {
            if (!okUno || !okDos)
            {
                Console.WriteLine("Usted debe ingresar números!");
            }
            else if (numeroUno == 0 || numeroDos == 0)
            {
                salirDelEjercicio = true;
                break;
            }
            else
            {
                if (numeroUno < numeroDos)
                {
                    Console.WriteLine("Los números pares son: ");
                    for (int i = numeroUno; i < numeroDos; i++) // tampoco lo vimos en clase pero lo busqué para simplificar.
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    Console.WriteLine("");
                    break;
                }
                else
                {
                    Console.WriteLine("El numero uno debe ser mayor al número dos!");
                }           
            }
        }

        

    }
    



}
