using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssessment_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter word to test: "); //prompts user to enter test word
            string input = Console.ReadLine();         //saves input as string
            input.ToArray();   
            string word2 = input.Reverse().ToString(); 
          
            if(word2 == input)
            {
               Console.WriteLine("This word is not a Palindrome");

            }
            else
            {
                Console.WriteLine("This word is a Palindrome");
            }
           //incomplete
            
        Console.ReadKey();
        }
        
       
    }    
}
