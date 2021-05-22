using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodes.Arrays
{
    class ArrayOperations
    {

        #region ReverseArray

        //standard answer -- Easier way with less time complexity
        public void ReverseArray(int[] input, int start, int end)
        {
            int temp = 0;
            Console.WriteLine("----REVERSE ARRAY USING STANDARD APPROACH----");
            Console.WriteLine("---INPUT ARRAY----");
            PrintArray(input);
            while (start < end)
            {
                temp = input[start];
                input[start] = input[end];
                input[end] = temp;
                start++;
                end--;
            }
            Console.WriteLine("---OUTPUT ARRAY OF REVERSED INPUT----");
            PrintArray(input);


        }

        //Recursive Approach
        public void RecursiveReverseArray(int[] input, int start, int end)
        {
           
            int temp;
            if (start >= end)
                return;
            temp = input[start];
            input[start] = input[end];
            input[end] = temp;

            RecursiveReverseArray(input, start + 1, end - 1);
            //Console.WriteLine("----OUTPUT ARRAY OF REVERSED INPUT----");
            //PrintArray(input);

        }

        //What I tried during practice. - higher time complexity
        public void WorseCaseReverseArray(int[] input)
        {
            Console.WriteLine("----REVERSE ARRAY USING WORSE CASE APPROACH----");
            Console.WriteLine("----INPUT ARRAY----");
            PrintArray(input);
            int[] output = new int[input.Length];
            int j = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {

                output[j] = input[i];
                j++;
            }

            Console.WriteLine("----OUTPUT ARRAY OF REVERSED INPUT----");
            PrintArray(output);
        }

        #endregion

        #region DetectDuplicates
        public void DetectDuplicates(string input)
        {
            Console.WriteLine("----ATTEMPTING TO DETECT DUPLICATES----");
            HashSet<char> uniqueForm = new HashSet<char>();
            char[] splitForm = input.ToCharArray();
            foreach (var item in splitForm)
            {
                uniqueForm.Add(item);
            }
            Console.WriteLine("----STRING WITHOUT DUPICATES----");
            foreach (var item in uniqueForm)
            {
                Console.Write(item);
            }

            
        }

        #endregion

        #region Maximum&MinimumElement

        //public void MaximumAndMinimum(int[] input)
        //{
        //    int box1 = 0; int box2 = 0;
        //    Console.WriteLine("----EXECUTING MAXIMUM AND MINIMUM FUNCTION");
            

        //}

        #endregion

        #region Printing

        public void PrintArray(int[] arr)
        {
            Console.WriteLine("-----PRINTING-----");
            foreach (var item in arr)
            {
                Console.Write("[ "+item+" ]");
            }
            Console.Write("\n");
            Console.WriteLine("-----------------------");
        }
        #endregion
    }
}
