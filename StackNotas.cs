using System;
using System.Collections.Generic;

namespace TC6_Stack
{
    class StackNotas
    {

        public List<string> notas = new List<string>();

        public int Count 
        {
            get => this.notas.Count;
        }

        // Push 

        public void Push(string nota)
        {
            this.notas.Add(nota);
        }

        public string Peek()
        {
        if (this.notas.Count == 0)
        {
            Console.WriteLine("No hay elementos por mostrar");
            return null;            
        }
        
        else
        {
            return this.notas[this.notas.Count - 1];
        }

        }

        public void PrintStack()
        {
            for (int i = notas.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(notas[i]);
            }
            
        }

        public string Pop()
        {            
            // Respaldar valor
            string value = this.notas[this.notas.Count - 1];
            // Borrar de la lista
            this.notas.RemoveAt(this.notas.Count - 1);
            // Devolver el valor respaldado
            return value;
        }

    }
}