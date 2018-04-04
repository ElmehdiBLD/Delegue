using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculatrice c = new Calculatrice();

            c.ChoixOperation(operation.addition);
            c.ChoixOperation(operation.soustraction);

            c.Add(5);
            c.Add(3);
            c.Add(2);

            Console.WriteLine(c.Calculer());
            Console.ReadLine();

        }
    }
}
