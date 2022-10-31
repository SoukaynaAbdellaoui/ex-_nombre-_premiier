using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex__nombre__premiier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre, i, compt = 0;

            Console.Write(" vieullez entrer un nombre : ");
            nombre = int.Parse(Console.ReadLine());

            for (i = 1; i <= nombre; i++)
            {
                if (nombre % i == 0)
                {
                    compt++;
                }
            }
            if (compt == 2)

            {
                Console.Write("  est un nombre premier.", nombre);
            }
            else
            {
                Console.WriteLine(" n'est pas un nombre premier.", nombre);
            }
            Console.ReadKey();

        }


    }
}


        

































































    