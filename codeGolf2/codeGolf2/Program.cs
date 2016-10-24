using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace codeGolf2
{
    class Program
    {
        static void Main(string[] args)
        {
            Plain plain1 = new Plain("lecture.txt");
            Console.WriteLine("Initial state of plain :");
            plain1.Display_Plain();
            Console.WriteLine();
            Console.WriteLine("Number of generations wanted ?");
            int nb1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < nb1; i++)
            {
                Plain plain1_2 = plain1.update();
                plain1.Clone(plain1_2);
                Console.Clear(); //Efface la console
                Console.Write((i + 1) + "\n");
                plain1.Display_Plain();
            }
        Console.ReadLine();
        }
    }
}
