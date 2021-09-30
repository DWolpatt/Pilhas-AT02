using System;
using System.Collections.Generic;

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> Chapas = new Stack<string>(); //Empilhamento de chapas metálicas em rede fabril.

            Chapas.Push("Chapa 1"); //Metodo que insere elementos na pilha.
            Chapas.Push("Chapa 2");
            Chapas.Push("Chapa 3");
            Chapas.Push("Chapa 4");
            Chapas.Push("Chapa 5");


            foreach(string Chapa in Chapas) //percorrendo lista
            {
                Console.WriteLine(Chapa);

            }


            Console.WriteLine(Chapas.Pop()); //removendo item da pilha


            foreach (string Chapa in Chapas) //percorrendo lista novamente
            {
                Console.WriteLine(Chapa);

            }

        }
    }
}
