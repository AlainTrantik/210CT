using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Td1
{
    class Program
    {
         /*Basic tasks
        *An algorithm is a list of rules to follow in order to solve a problem. 
          *It is important to study them because they are widely used throughout all areas of IT*/

        /*Intermediate tasks
         */
        static void displayArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "|");
            }
        }
        static int [] shuffle(int[] array)
        {
            //The algorithm below randomly shuffles an array of integers by permutation of each elements with a random element of the array.
            displayArray(array);
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int r = rand.Next(0, array.Length);
                int tmp = array[i];
                array[i] = array[r];
                array[r] = tmp;
            }
            Console.WriteLine("\n");
            displayArray(array);
            return array;
        }
        static int Factorielle(int n)
        {
            if (n == 0)
                return 1;
            else 
                return n * Factorielle(n - 1);
        }
        static int zeros(int n)
        {
            //On compte le nombre de fois qu'un nombre est divisible par 5, si 2 fois alors il se termine par 2 zéros.
            Console.WriteLine(n);
            int primerFactorOfFive = 0;
            while (n % 5 == 0)
            {
                n = n / 5;
                primerFactorOfFive++;
            }
            return primerFactorOfFive;
        }
        /*Questions
         * My 2 algorithms provide inputs and outputs
         * we can guarantee that it terminates
         * it's correct, clear, concise and efficient*/

        /*Advanced tasks 
         */
        static void Aliens(int num_eggs, int daysToHatch, int MAX_DAYS)
        {
            int[] day = new int[MAX_DAYS];
            //Durant les Y jours nécessaires à l'éclosion le premier alien est seul.
            for (int i = 0; i < daysToHatch; i++)
            {
                day[i] = 1;
            }
            //Une fois ce jour atteint l'alien est rejoins par les 3 oeufs pondus Y jour avant.
            for (int i = daysToHatch; i < MAX_DAYS; i++)
            {
                day[i] = day[i - 1] + (num_eggs * day[i - daysToHatch]);
            }
            for (int i = 0; i < MAX_DAYS; i++)
            {
                Console.WriteLine("Day " + i + ": " + day[i]+" aliens");
            }
        }

        static void sparseMatrix(int length)
        {
            int[,] mat1 = new int[length, length];
            int[,] mat2 = new int[length, length];
            int elements= length*length;
            int max_elements=(elements/2)-1;
            Random rand = new Random();
            //Une matrice est par défaut initialisée à 0. Il suffit de remplir moins de la moitié de ces éléments pour qu'elle soit ''creuse''.
            for (int i = 0; i <max_elements ; i++)
            {
                //on choisit aléatoirement les éléments à remplir
                int x = rand.Next(0, length);
                int y = rand.Next(0, length);
                //Si l'élément a déja été rempli on ne demande pas de le re remplir
                if (mat1[x, y] == 0)
                {
                    Console.WriteLine("Input element [" + (x + 1) + "," + (y + 1) + "] of the first matrix");
                    mat1[x, y] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(" " + mat1[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < max_elements; i++)
            {
                int x = rand.Next(0, length);
                int y = rand.Next(0, length);
                if (mat2[x, y] == 0)
                {
                    Console.WriteLine("Input element [" + (x + 1) + "," + (y + 1) + "] of the second matrix");
                    mat2[x, y] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(" " + mat2[i, j]);
                }
                Console.WriteLine();
            }
            int[,] mat3 = new int[length, length];
            Console.WriteLine("Which operations would you like to perform ?");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Substraction");
            Console.WriteLine("3: Multiplication");
            int operation = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    Console.WriteLine(": Addition: ");
                    for (int i = 0; i < length; i++)
                    {
                        for (int j = 0; j < length; j++)
                        {
                            mat3[i,j]=mat1[i,j]+mat2[i,j];
                        }
                    }
                    for (int i = 0; i < length; i++)
                    {
                        for (int j = 0; j < length; j++)
                        {
                            Console.Write(mat3[i,j]+" ");
                        }
                        Console.WriteLine();
                    }
                        break;
                case 2:
                    Console.WriteLine(": Substraction: ");
                    for (int i = 0; i < length; i++)
                    {
                        for (int j = 0; j < length; j++)
                        {
                            mat3[i,j]=mat1[i,j]-mat2[i,j];
                        }
                    }
                    for (int i = 0; i < length; i++)
                    {
                        for (int j = 0; j < length; j++)
                        {
                            Console.Write(mat3[i,j]+" ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    Console.WriteLine(": Substraction: ");
                    for (int i = 0; i < length;i++)//Produit matriciel
                    {
                        for (int j = 0; j < length; j++)
                        {
                            for (int k = 0; k < length; k++)
                            {
                                mat3[i, j] = mat3[i, j] + (mat1[i, k] * mat2[k, j]);
                            }
                        }
                    }
                    for (int i = 0; i < length; i++)
                    {
                        for (int j = 0; j < length; j++)
                        {
                            Console.Write(mat3[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                        break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            //int[] array = {1,2,3,4,5,6,7,8,9};
            //shuffle(array);
            //Console.WriteLine(zeros(Factorielle(10)));
            Aliens(3, 5, 30); //30 days after a single alien invades
            //sparseMatrix(3);
            Console.ReadLine();
        }
    }
}
