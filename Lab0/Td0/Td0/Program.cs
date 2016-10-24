using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Td0
{
    class Program
    {
        static int task1()
        {
            Console.WriteLine("Please input your first float number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input your first float number b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input your first float number c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input your first float number d: ");
            int d = int.Parse(Console.ReadLine());
            int fraction1 = a / b;
            int fraction2 = c / d;
            if (fraction1 > fraction2)
                return fraction1;
            return fraction2;
        }
        static void task2()
        {

        }
        static float task3()
        {
            Console.WriteLine("Please input your float number x");
            float x = float.Parse(Console.ReadLine());
            if (x < -2)
                return ((x * x) + (4 * x) + 4);
            if (x > -2)
                return ((x * x) + 5 * x);
            return 0;
        }
        static void task4()
        {
            Console.WriteLine("Please input your word");
            string s = Console.ReadLine();
            //char [] tab = new char[s.Length];
            int b;
            int l;
            do
            {
                Console.WriteLine("Input the beginning position of the substring");
                b = int.Parse(Console.ReadLine());
            }
            while (b < 0 || b > s.Length);
            do
            {
                Console.WriteLine("Input the length of the substring");
                l = int.Parse(Console.ReadLine());
            }
            while (l > s.Length - b || l < 0);
            for (int i = 0; i < b; i++)
            {
                Console.Write(s[i]);
            }
            for(int i = b+l; i < s.Length; i++)
            {
                Console.Write(s[i]);
            }
        }
        static void task5()
        {
            int daysYear = 0;
            int daysPassed = 0;
            int daysLeft = 0;
            Console.WriteLine("Input a year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a month");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a day");
            int day = int.Parse(Console.ReadLine());
            int[] calendar = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for (int i = 0; i < calendar.Length; i++)
            {
                daysYear += calendar[i];
            }
            for (int i = 0; i < month; i++)
            {
                daysPassed += calendar[i];
            }
            daysPassed = daysPassed - (calendar[month-1] - day);
            daysLeft = daysYear - daysPassed;
            Console.WriteLine("Passed: " + daysPassed + " Left: " + daysLeft);
        }

        static void task6()
        {
            int[] tab = new int[5];

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Please input number "+(i+1));
                tab[i] = int.Parse(Console.ReadLine());
            }
            int imax = 0;
            int max = tab[imax];
            int imin = tab.Length - 1;
            int min = tab[imin];
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] > max)
                {
                    max = tab[i];
                    imax = i+1;
                }
            }
            Console.WriteLine("Max is " + max + " on position " + imax);
            for (int i = tab.Length - 2; i >= 0; i--)
            {
                if (tab[i] < min)
                {
                    min = tab[i];
                    imin = i + 1;
                }
            }
            Console.WriteLine("Min is " + min + " on position " + imin);
        }
        static void task7()////A FAIRE
        {
            Console.WriteLine("Input the number of equations");
            int equations = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the number of variables");
            int variables = int.Parse(Console.ReadLine());
            int [,] matrix=new int[equations,variables];
            for (int x = 0; x < equations ; x++)
            {
                for (int y = 0; y < variables; y++)
                {
                    Console.WriteLine("Input coefficient " + (y + 1) + " of your equation " + (x + 1));
                    matrix[x, y] = int.Parse(Console.ReadLine());
                }
            }
            int determinant=0;
            determinant = matrix[0, 0] * ((matrix[1,1] * matrix[2, 2]) - (matrix[2, 1] * matrix[1, 2]));
            determinant += matrix[1, 0] * ((matrix[0, 1] * matrix[2, 2]) - (matrix[2, 1] * matrix[0, 2]));
            determinant += matrix[2, 0] * ((matrix[0, 1] * matrix[1, 2]) - (matrix[1, 1] * matrix[0, 2]));

            /*int z = 0;
            for (int x = 0; x < equations; x++)
            {
                determinant += matrix[x, 0] * ((matrix[x + 1, z + 1] * matrix[x + 2, z + 2]) - (matrix[x + 2, z + 1] * matrix[x + 1, z + 2]));
                z++;
                
            }*/
            Console.WriteLine(determinant);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(task1());
            //task2();
            //Console.WriteLine(task3());
            //task4();
            //task5();
            //task6();
            task7();
            Console.ReadLine();
        }
    }
}
