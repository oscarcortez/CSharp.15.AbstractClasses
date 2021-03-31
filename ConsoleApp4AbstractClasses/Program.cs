using Models;
using System;

namespace ConsoleApp4AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {            
            Cuadrado cuadrado = new Cuadrado(3);
            Console.WriteLine($"Desde clase cuadrado => Area: {cuadrado.Area()}");
            
            Pieza cuadrado2 = new Cuadrado(12);
            Console.WriteLine($"Desde clase pieza => Area: {cuadrado2.Area()}");
        }
    }
}
