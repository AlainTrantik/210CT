using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        /*Pseudocode task 1
            *PERFECT_SQUARE(n)
            *  for i <- n Downto 0
            *      if(sqrt(i)%1=0)
            *          return i
            *      return -1       */
        static int perfectSquare(int n)
        {
            for (int i = n; i > 0; i--)
            {
                if (Math.Sqrt(i) % 1 == 0)
                    return i;
            }
            return -1;
        }

        static int [,] matAddition(int[,] mat1, int[,] mat2)
        {
            int length = mat1.GetLength(0);//Because mat1 and mat2 are two quadratic matrices of the same order so(mat1.GetLength(0)=mat1.GetLength(1)=mat2.GetLength(0)=mat2.GetLength(1))
            int[,] mat3 = new int[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {         
                    mat3[i, j] = mat1[i, j] + mat2[i, j];
                }
            }
            return mat3;
        }
        /*Pseudocode
            *matAddition(mat1,mat2)
                *length <- mat1.GetLength(0)
                *mat3 <- [length,length]
                *for i <- 0 To length
                    *for j <- 0 To length
                        *mat3[i,j] <- mat1[i,j] + mat2[i,j]
                *return mat3
         */
        static int [,] matSubtraction(int[,] mat1, int[,] mat2){
            int length = mat1.GetLength(0);
            int[,] mat3 = new int[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    mat3[i, j] = mat1[i, j] - mat2[i, j];
                }
            }
            return mat3;
        }
        /*Pseudocode
            *matSubtraction(mat1,mat2)
                *length <- mat1.GetLength(0)
                *mat3 <- [length,length]
                *for i <- 0 To length
                    *for j <- 0 To length
                        *mat3[i,j] <- mat1[i,j] - mat2[i,j]
                *return mat3
 */
        static int [,] matMultiplication(int[,] mat1, int[,] mat2){
            int length = mat1.GetLength(0);
            int[,] mat3 = new int[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    for (int k = 0; k < length; k++)
                    {
                        mat3[i, j] = mat3[i, j] + (mat1[i, k] * mat2[k, j]);
                    }
                }
            }
            return mat3;
        }
        /*Pseudocode
            *matMultiplication(mat1,mat2)
                *length <- mat1.GetLength(0)
                *mat3 <- [length,length]
                *for i <- 0 To length
                    *for j <- 0 To length
                        *for k <- 0 To length
                            *mat3[i,j] <- mat3[i,j] + (mat1[i,k] * mat2[k,j])
                *return mat3
*/
        static int[,] matTimesInt(int a, int[,] mat1)
        {
            int length = mat1.GetLength(0);
            int[,] mat3 = new int[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    mat3[i, j] = a * mat1[i, j];
                }
            }
            return mat3;
        }
        /*Pseudocode
            *matTimesInt(a,mat1)
                *length <- mat1.GetLength(0)
                *mat3 <- [length,length]
                *for i <- 0 To length
                    *for j <- 0 To length
                        *mat3[i,j] <- a * mat1[i,j]
                *return mat3
 */
        static void displayMat(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void reverse(string s)
        {
            string [] tab=new string [s.Length];
            int i=0;
            string w = "";
            while (i < s.Length && s[i] != ' ')
            {
                w = w + s[i];
                i++;
            }
            for (int i = 0; i < tab.Length;i++ ) {
                Console.Write(tab[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(perfectSquare(20));
            //int[,] mat1 = { { 1, 2 }, { 3, 4 } }; //B
            //int[,] mat2 = { { 4, 5 }, { 6, 7 } }; //C
            //int[,] mat3 = matAddition(mat1, mat2); //(B+C)
            //int[,] mat4 = matMultiplication(mat1, mat2); //(B*C)
            //mat3 = matTimesInt(2, mat3); //2*(B+C)
            //int[,] finalMat = matSubtraction(mat4, mat3);//(B*C)-2*(B+C)
            //displayMat(finalMat);
            reverse("Hello world");
            Console.ReadLine();
        }
    }
}
