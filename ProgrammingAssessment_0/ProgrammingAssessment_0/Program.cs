using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssessment_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 0, 1, 1, 0, 1, 0, 0, 1 }; //create an array of integers
            
            Array.Sort(firstArray); //sorts array in ascending order
            PrintArray(firstArray); //call print function to output the array to the console

            Console.ReadKey();
            

        }
        static void PrintArray(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i]);
            }
            
        }

    }
}
