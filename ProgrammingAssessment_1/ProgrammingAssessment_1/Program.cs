using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgrammingAssessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("C:\\Users\\CCA025\\Desktop\\Program.cs"); //reads file (file only has one comment)

            string line = file.ReadToEnd(); //saves file as a string and reads to end
            string[] lines = line.Split(); //breaks the string in to an array of strings
            foreach (string let in lines) //loops thru
            {
                if(lines.Contains("//"))
                {
                    Console.Write(lines);

                }
            }
           
            
             file.Close();

            Console.ReadKey();
            //incomplete
           
        }//end main



    }
}





