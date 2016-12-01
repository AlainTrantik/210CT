using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static int[] max_sub_sequence(int[] sequence)
        {
            int curr_length = 0;   //current length of the sub-sequence
            int max_length = 0;  //maximum length of the sub-sequence
            int end = 0;        //end index of the longer sub-sequence
            int curr_end = 0;   //end index of the current sub-sequence
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] < sequence[i + 1])     //Couting the length of the current sub-sequence of ascending numbers and saving the index of the last number
                {
                    curr_end = i + 1;
                    curr_length++;
                }
                if (!(sequence[i] < sequence[i + 1]) || i == sequence.Length - 2)  //I put (if i=sequence.Length-2) in order to save the variables if the last number of the sub-sequence is also the last number of the sequence.
                {
                    if (curr_length > max_length) //when the sub-sequence is broken (sequence[i]>sequence[i+1]), I save its length and the index of its last number if the length is higher than the maximum length stored.
                    {
                        max_length = curr_length;
                        end = curr_end;
                    }
                    curr_length = 0;           //I reinitialize the length at 0 so it cans count the length of the second sub-sequence...
                }
            }
            int[] sub_sequence = new int[max_length + 1]; //I create an array to store the longer sub-sequence found
            for (int i = 0; i <sub_sequence.Length; i++)
            {
                sub_sequence[i] = sequence[end - max_length + i]; //the first index of the sub-sequence is lastIndex - length.
            }
            for (int i = 0; i < sub_sequence.Length;i++ )
            {
                Console.Write(sub_sequence[i] + "|"); //I display the sub-sequence before return it back.
            }
                return sub_sequence;
        }


        static void Main(string[] args)
        {
            int[] sequence = {1,2,3,1,2,3,4,5,1,2,3,4};
            max_sub_sequence(sequence);
            Console.ReadLine();
        }
    }
}
