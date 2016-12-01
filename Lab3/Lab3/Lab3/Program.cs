using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        /*Pseudocode
         * reverseString(sentence)
         *      tabReversed <- [sentence.Length]
         *      reversed <- ""
         *      j <- 0
         *      for(i <-0 To sentence.Length)
         *          if(sentence[i]!=' ')
         *              tabReversed[j] <- tabReversed[j] + sentence[i]
         *          else j <- j + 1
         *      for(i <- j Downto 0)
         *          reversed <- reversed + tabReversed[i] + " "
         *      return reversed
         */
        static string reverseString(string sentence)
        {
            string[] tabReversed = new string[sentence.Length];
            string reversed = "";
            int j = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                    tabReversed[j] += sentence[i];
                else j++;
            }
            for (int i = j; i >=0; i--)
            {
                reversed+=tabReversed[i] + " ";
            }
            return reversed;
        }

        /*Pseudocode
         *      prime(n,i)
         *          if(n = i)
         *              return true
         *          if(n % i = 0)
         *              return false
         *          return prime(n, i+1)
         */
        static bool prime(int n, int i)
        {
            if (n == i)
                return true;
            else if (n % i == 0)
                return false;
            return prime(n, i+1);
        }
        
        /*Pseudocode
         *      removeVocals(s,i)
         *         if(i>s.Length)
         *              return s
         *         if(s[i]='a'||'e'||'i'||'o'||'u'||'y')
         *              s=s.Remove(i,1)
         *              return removeVocals(s,i)
         *         else
         *              return removeVocals(s,i+1)
         */
        static string removeVocals(string s,int i)
        {
            if (i >= s.Length)
                return s;
            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'y')
            {
                s = s.Remove(i, 1);
                return removeVocals(s,i);
            }
            else
            {
                return removeVocals(s,i+1);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine(reverseString("This is awesome"));
            //Console.WriteLine(prime(11,2));
            //Console.WriteLine(removeVocals("beautiful   ", 0));
            Console.ReadLine();
        }
    }
}
