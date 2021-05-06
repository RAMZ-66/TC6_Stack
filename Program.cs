using System;
using System.Collections.Generic;

namespace TC6_Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            StackNotas stackNotas = new StackNotas();
            stackNotas.Push("Primera Nota");
            stackNotas.Push("Segunda Nota");
            stackNotas.Push("Tercer Nota");

            string opcion = "";

            while (opcion != "9")
            {

                opcion = "";

                while(opcion != "1" && opcion != "2" && opcion != "4" && opcion != "9")
                {

                    Console.WriteLine("1) Imprimir stack (PrintStack");
                    Console.WriteLine("2) Agregar nota (Push)");                
                    Console.WriteLine("3) Quitar nota (Pop)");                                        
                    Console.WriteLine("4) Consultar un elemento (Peek)");                                        
                    Console.WriteLine("9) Salir");
                    Console.WriteLine("Porfavor selecciona una opción válida");

                    opcion = Console.ReadLine();                   

                    if (opcion == "1")
                    {
                        stackNotas.PrintStack();
                    }

                    else if (opcion == "2")
                    {
                        // Push
                        Console.WriteLine("Agregar nota:");
                        string nota = Console.ReadLine();
                        stackNotas.Push(nota);
                    }

                    else if (opcion == "3")
                    {
                        // Pop
                        string nota = stackNotas.Pop();
                        Console.WriteLine("Nota removida");
                        Console.WriteLine(nota);
                    }

                    else if (opcion == "4")
                    {
                        // Peek
                        string nota = stackNotas.Peek();
                        Console.WriteLine("Nota consultada:");
                        Console.WriteLine(nota);
                    }

                    else if (opcion == "9")
                    {

                        // Salir del programa
                        Console.WriteLine("Hasta luego");

                    }
                    

                }

            }
           
        }
           
    }
}
