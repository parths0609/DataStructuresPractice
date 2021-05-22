using PracticeCodes.Arrays;
using System;
using System.Collections.Generic;

namespace PracticeCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Objects
            ArrayOperations operationsObj = new ArrayOperations();
            #endregion

            #region DetectDuplicates
                Console.WriteLine("----Search for Duplicates----");
                operationsObj.DetectDuplicates("SAMANTHA");
            #endregion

            #region ReverseArray

                #region StandardWay
            int[] param = new int[] { 1, 3, 4, 6 };
            operationsObj.ReverseArray(param, 0, 3);
            #endregion

                #region WorseCase
           
            int[] inputArr = new int[] { 1, 3, 4, 6, 8 };
            operationsObj.WorseCaseReverseArray(inputArr);
            #endregion

                #region RecursiveWay
            operationsObj.RecursiveReverseArray(inputArr, 0, 4);
            #endregion

            #endregion

            Console.Read();
        }
    }
}
