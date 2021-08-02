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
    class LocationFinder
    {
        public string _Drive() //displays and makes you select available drivers in your computer
        {
            Console.WriteLine($"Drivers List{Environment.NewLine}");
            var Drivers = DriveInfo.GetDrives();
            for (int pointer = 0; pointer < Drivers.Length; pointer++) //display each element of the array
            {
                var folders = Convert.ToString(Drivers[pointer]);
                Console.WriteLine($"{pointer + 1}. {folders}");
            }
            Console.WriteLine($"{Environment.NewLine}Choose a Driver: {Environment.NewLine}");
            try
            {
                var choice = int.Parse(Console.ReadLine());
                Console.Beep();
                var pointer = Drivers[choice - 1];
                Console.WriteLine($"Your Folder: {Drivers[choice - 1]}");
                Console.Clear();
                return Convert.ToString(Drivers[choice - 1]); //selects drivers and returns it as a path selected from the array.. catches out of range and format exceptions
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Enter a valid character");
                return _Drive();
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid character");
                return _Drive();
            }
        }
        public string _FolderPath(string i)
        {
            try
            {
                var trying = Directory.GetDirectories(i);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid character");
                return _FolderPath(i);
            }
            var directory = Directory.GetDirectories(i); //searches for directories in the selected path
            for (int pointer = 0; pointer < directory.Length; pointer++) //displays each element of the array in a list
            {
                var folders = directory[pointer];
                Console.WriteLine($"{pointer + 1}. {folders}");
            }
            Console.WriteLine("Choose a folder: ");
            try
            {
                var choice = int.Parse(Console.ReadLine()); //lets you select the folder and return the path string from the selected array element.. catches format and out of range exceptions
                var path = $"{directory[choice - 1]}\\";
                Console.Clear();
                return $"{directory[choice - 1]}\\";
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid character:");
                return _FolderPath(i);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("There is no more folders available");
                return _FolderPath(i);
            }
        }
        public string _FilePath(string i) //same but for files instead of directories
        {
            try
            {
                var trying = Directory.GetFiles(i, "*.*", SearchOption.TopDirectoryOnly);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid character");
                return _FilePath(i);
            }
            var files = Directory.GetFiles(i, "*.*", SearchOption.TopDirectoryOnly);
            for (int pointer = 0; pointer < files.Length; pointer++)
            {
                var folders = files[pointer];
                Console.WriteLine($"{pointer + 1}. {folders}");
            }
            Console.WriteLine("Choose a file: ");
            try
            {
                var choice = int.Parse(Console.ReadLine());
                var path = $"{files[choice - 1]}";
                Console.Clear();
                return $"{files[choice - 1]}";
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid character:");
                return _FilePath(i);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("There is no more folders available");
                return _FilePath(i);
            }
        }
        public Array _FilePeek(string i) //same format but only peeks at the next folder so you can decide to select folder or file.. shows files in that folder
        {
            try
            {
                var trying = Directory.GetFiles(i, "*.*", SearchOption.TopDirectoryOnly);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid character");
                return _FilePeek(i);
            }
            var files = Directory.GetFiles(i, "*.*", SearchOption.TopDirectoryOnly);
            for (int pointer = 0; pointer < files.Length; pointer++)
            {
                var folders = files[pointer];
                Console.WriteLine($"{pointer + 1}. {folders}");
            }
            return files;
        }
        public Array _FolderPeek(string i) ////same format but only peeks at the next folder so you can decide to select folder or file.. shows directories in that folder
        {
            try
            {
                var trying = Directory.GetDirectories(i, "*.*", SearchOption.TopDirectoryOnly);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid character");
                return _FolderPeek(i);
            }
            var files = Directory.GetDirectories(i, "*.*", SearchOption.TopDirectoryOnly);
            for (int pointer = 0; pointer < files.Length; pointer++)
            {
                var folders = files[pointer];
                Console.WriteLine($"{pointer + 1}. {folders}");
            }
            return files;
        }
    }
}
