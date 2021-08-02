using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day3Ex2 //Create a console application to handle file related operations like create, write into file,
                  //append into file, delete file, copy file.
                  //Create a menu for user.
                  //Use as many concepts we have learnt in past 2 weeks like program flow, functions,
                  //even classes if needed.
                  //There is no limit for your creativity!
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = $"File Handler {DateTime.Now}";     //Setting Console title 
            Console.ForegroundColor = ConsoleColor.Gray;        //Setting Console color 
            Console.Clear();
            var begin = new Menu();                             //begin as a function of menu
            begin._Menu();                                      //begin menu

        }
    }
}
