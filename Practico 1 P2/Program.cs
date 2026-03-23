using System;

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
            Console.WriteLine("1- Ejercicio 1 | 'Adivine el número random'");
            Console.WriteLine("2- Ejercicio 2 | 'Ver tabla de multiplicación'");
            Console.WriteLine("3- Ejercicio 3 | 'Ver números pares en rango dado'");
            Console.WriteLine("4- Ejercicio 4 | 'Revisar número comprendido en rango'");
            Console.WriteLine("5- Ejercicio 5 | 'Sumar números'");
            Console.WriteLine("6- Ejercicio 6 | 'Contador de vocales'");
            Console.WriteLine("7- Ejercicio 7 | 'Espejo de palabras'");
            Console.WriteLine("8- Ejercicio 8 | 'Revisar palíndromo'");
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
                case "4":
                    EjercicioCuatro();
                    break;
                case "5":
                    EjercicioCinco();
                    break;
                case "6":
                    EjercicioSeis();
                    break;
                case "7":
                    EjercicioSiete();
                    break;
                case "8":
                    EjercicioOcho();
                    break;
                case "0":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Opción no válida, ingrese un numero del 1 al 8 o 0 para salir.");
                    Console.WriteLine("");
                    break;
            }
        }
    }
    
    
    
    static void EjercicioUno()
    {
        
        // Ejercicio 1.
        // Solicitar números hasta que ingrese el 0 (fin del ingreso).
        // Se debe comparar con un número random e indicar cuando son iguales.
        
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
    
    
    
    static void EjercicioDos()
    {
        
        // Ejercicio 2.
        // Solicitar números hasta que ingrese el 0 (fin del ingreso).
        // Se debe mostrar la tabla del mismo.
        
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
                Console.WriteLine("Usted debe ingresar un numero entero!");
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
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine($"{numeroIngresadoEntero} x {i} = {(numeroIngresadoEntero * i)}");
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                break;
            }
        }

    }


    
    static void EjercicioTres()
    {
        
        // Ejercicio 3
        // Solicitar dos números (controlar que el primer número sea menor al segundo) y muestre todos los números entre los valores ingresados que sean pares. Para salir se debe ingresar 0.
        
        bool salirDelEjercicio = false;

        while (!salirDelEjercicio)
        {
            Console.WriteLine("Ingrese el menor de los dos numeros a ingresar (0 para salir)");
            string numeroUnoStr = Console.ReadLine();
            Console.WriteLine("Ingrese el mayor de los dos numeros a ingresar (0 para salir)");
            string numeroDosStr = Console.ReadLine();
            bool okUno = int.TryParse(numeroUnoStr, out int numeroUno);
            bool okDos = int.TryParse(numeroDosStr, out int numeroDos);
            
            if (!okUno || !okDos)
            {
                Console.WriteLine("Usted debe ingresar números!");
                continue;
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
                    for (int i = numeroUno; i < numeroDos; i++)
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
                    Console.WriteLine("El numero uno debe ser menor al número dos!");
                    Console.WriteLine("");
                    continue;
                }           
            }
        }
    }


    
    static void EjercicioCuatro()
    {
        
        // Ejercicio 4
        // Solicitar dos números y un valor, indicar si el valor está comprendido entre los números
        
        bool salirDelEjercicio = false;
        
        while (!salirDelEjercicio)
        {
            Console.WriteLine("Ingrese un número 'a'");
            string numeroUnoStr = Console.ReadLine();
            Console.WriteLine("Ingrese un número 'b'");
            string numeroDosStr = Console.ReadLine();
        
            Console.WriteLine("Ingrese un valor 'c' para saber si esta comprendido entre a y b");
            string valorStr = Console.ReadLine();
            bool okUno = int.TryParse(numeroUnoStr, out int numeroUno);
            bool okDos = int.TryParse(numeroDosStr, out int numeroDos);
            bool okTres = int.TryParse(valorStr, out int valor);
            
            if (!okUno || !okDos || !okTres)
            {
                Console.WriteLine("Usted ingresó valores no válidos, sólo se permiten números enteros.");
                break;
            }
            else if (numeroUno == 0 || numeroDos == 0 || valor == 0)
            {
                salirDelEjercicio = true;
                break;
            }
            else
            {
                if (numeroUno < valor && valor < numeroDos)
                {
                    Console.WriteLine($"El número {valor} está comprendido entre {numeroUno} y {numeroDos}");
                }
                else if (numeroUno > valor && valor > numeroDos)
                {
                    Console.WriteLine($"El número {valor} está comprendido entre {numeroUno} y {numeroDos}");
                }
                else
                {
                    Console.WriteLine($"El número {valor} NO está comprendido entre {numeroUno} y {numeroDos}");
                }

                Console.WriteLine(" ");
                break;
            }
        }
    }


    
    static void EjercicioCinco()
    {
        
        // Ejercicio 5
        // Solicitar números hasta que se ingrese el 0. Se debe mostrar la suma de todos ellos.
        
        bool  salirDelEjercicio = false;
        int suma = 0;
        
        while (!salirDelEjercicio)
        {
            Console.Write("Ingrese numeros para sumarlos, 0 para salir. ");
            string numero = Console.ReadLine();
            bool ok = int.TryParse(numero, out int numeroEntero);
            if (!ok)
            {
                Console.WriteLine("Debe ingresar solamente números!");
            }
            else if (numeroEntero == 0)
            {
                salirDelEjercicio = true;
                Console.WriteLine("");
                Console.WriteLine($"La suma total es de {suma}.");
                Console.WriteLine("");
            }
            else
            {
                suma += numeroEntero;
            }
        }
    }


    static void EjercicioSeis()
    {
        
        // Ejercicio 6
        // Ingresar una palabra y mostrar la cantidad de vocales que tiene.
        
        bool salirDelEjercicio = false;
        
        // A continuacion defino las vocales como variables tipo string para que puedan ser comparadas. 
        char a = 'a';
        char e = 'e';
        char i = 'i';
        char o = 'o';
        char u = 'u';
        
        while (!salirDelEjercicio)
        {
            // Pedir los datos
            Console.WriteLine("Ingrese una palabra, 0 para salir. ");
            string palabra = Console.ReadLine();
            palabra = palabra.ToLower();
            int contadorDeVocales = 0;
            if (palabra == "0")
            {
                salirDelEjercicio = true;
            }
            else
            {
                // Preferiría utilizar 'i' para el índice pero la declaré como variable de vocal anteriormente
                for (int x = 0; x < palabra.Length; x++) 
                {
                    if (palabra[x] == a || palabra[x] == e || palabra[x] == i || palabra[x] == o ||
                        palabra[x] == u)
                    {
                        contadorDeVocales++;
                    }
                }
                Console.WriteLine($"La palabra contiene {contadorDeVocales} vocales.");
                Console.WriteLine("");
                
            }
        }

    }


    static void EjercicioSiete()
    {
        
        // Ejercicio 7
        // Ingresar una palabra y mostrarla en el otro sentido(Hola -> aloH).

        bool salirDelEjercicio = false;
    
        while (!salirDelEjercicio)
        {
            Console.WriteLine("Ingrese una palabra para mostrarla al revés. Ingrese 0 Para salir");
            string palabra = Console.ReadLine();
            if (palabra == "0")
            {
                salirDelEjercicio = true;
            }
            else
            {
                string palabraEspejada = "";
                for (int i = (palabra.Length - 1); i >= 0; i--)
                {
                    palabraEspejada += palabra[i];
                }   
                Console.WriteLine(palabraEspejada);    
            }
        }   
    }
    
    
    static void EjercicioOcho()
    {
        
        // Ejercicio 8
        // Ingresar una palabra e indicar si es palíndromo(somos).

        bool salirDelEjercicio = false;
        
        while (!salirDelEjercicio)
        {
            Console.WriteLine("Ingrese una palabra para saber si es palíndromo. Ingrese 0 Para salir");
            string palabra = Console.ReadLine();
            if (palabra == "0")
            {
                salirDelEjercicio = true;
            }
            else
            {
                string palabraEspejada = "";
                for (int i = (palabra.Length - 1); i >= 0; i--)
                {
                    palabraEspejada += palabra[i];
                }

                if (palabraEspejada == palabra)
                {
                    Console.WriteLine($"La palabra '{palabra}' es palíndromo!");
                }
                else
                {
                    Console.WriteLine($"La palabra '{palabra}' NO es palíndromo!");
                }
            }
        }   
    }

}
