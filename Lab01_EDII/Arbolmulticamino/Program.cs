using System;
using System.Security.Cryptography.X509Certificates;
using Arbol_Multicamino;

namespace Arbolmulticamino
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolMulticamino<int> arbolito;
            arbolito = new ArbolMulticamino<int>(3);
            for (int i = 0; i <= 2; i++)
            {
                arbolito.AgregarNodo(i);
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
