using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day3Ex2//Create a console application to handle file related operations like create, write into file,
                 //append into file, delete file, copy file.
                 //Create a menu for user.
                 //Use as many concepts we have learnt in past 2 weeks like program flow, functions,
                 //even classes if needed.
                 //There is no limit for your creativity!
{
    class WriteInFile : FileLocation
    {
        public void _AddTextToEmpty() //adds text to an empty file
        {
            var fileName = new FileFunction();
            var file = fileName._ChooseFile();
            using (StreamWriter writer = File.CreateText(file))
            {
                try
                {
                    Console.WriteLine("Enter Name: ");
                    var name = Console.ReadLine();
                    Console.Beep();
                    Console.WriteLine("Enter Age: ");
                    var age = Console.ReadLine();
                    Console.Beep();
                    Console.WriteLine("Enter Address: ");
                    var address = Console.ReadLine();
                    Console.Beep();
                    Console.WriteLine("Enter Hobbies: ");
                    var hobbies = Console.ReadLine();
                    Console.Beep();
                    Console.Clear();
                    writer.WriteLine($@"Your name is {name}, you are {age} years old, you live in {address} and you like {hobbies}.");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void _ReplaceText() //replace all text in an existing file
        {
            var fileName = new FileFunction();
            var file = fileName._ChooseFile();
            Console.WriteLine("Enter Name: ");
            var name = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("Enter Age: ");
            var age = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("Enter Address: ");
            var address = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("Enter Hobbies: ");
            var hobbies = Console.ReadLine();
            Console.Beep();
            var newText = $@"Your name is {name}, you are {age} years old, you live in {address} and you like {hobbies}.";
            Console.Clear();
            Console.WriteLine($"{newText}");
            File.WriteAllText(file, newText);
            Console.ReadLine();

        }
        public void _AddTextToText() //appends text to an existing file
        {
            var fileName = new FileFunction();
            var file = fileName._ChooseFile();
            Console.WriteLine("Add Job Description: ");
            string newText = Console.ReadLine();
            Console.Beep();
            Console.WriteLine(File.ReadAllText(file) + newText);
            File.AppendAllText(file, newText);
            Console.ReadLine();

        }
    }
}
