using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Ingrese número 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese número 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2) {
                Console.WriteLine("Es mayor el número 1");
            } else if (n1 < n2) {
                Console.WriteLine("Es mayor el número 2");
            } else {
                Console.WriteLine("Ambos números son iguales");
            }

            Console.ReadLine();
        }
    }
}
