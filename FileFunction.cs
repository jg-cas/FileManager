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
    class FileFunction : Create //inheritance hyerarchy = filefunction : create: writeinfile: filelocation
    {
        LocationFinder location = new LocationFinder(); //allocating memory for a variable
        public string _ChooseFile()
        {
            var path = location._Drive(); //callin the drive method from location
            Console.WriteLine($"Here is a list of folders in your drive: {Environment.NewLine}");
            path = location._FolderPath(path); //obtaining folder path
            bool chooseHere = false;
            while (!chooseHere) //while you haven't choosen, keep searching inside other folders
            {
                location._FolderPeek(path);
                location._FilePeek(path);
                Console.WriteLine($@"
1.Choose Folder 
2.Choose File");
                switch (Console.ReadLine())
                {
                    case "1":
                        string holder; //updates values of path - using a temporary holder
                        holder = location._FolderPath(path);
                        path = holder;
                        chooseHere = false;
                        break; //selects a folder to utilize
                    case "2":
                        holder = location._FilePath(path);
                        path = holder;
                        chooseHere = true;
                        break;
                    default:
                        chooseHere = false;
                        break;
                }

            }
            return path;
        }
        public void _DeleteFile() //deletes file selected
        {
            var file = _ChooseFile();
            File.Delete(file);
            Console.WriteLine($@"{Environment.NewLine}File Delete

Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        public void _ReadFile()
        {
            var file = _ChooseFile(); //reads file selected
            File.ReadAllText(file);
            Console.WriteLine($@"{Environment.NewLine}End of Text

Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        public void _FileInfo()
        {
            var file = _ChooseFile(); //gets date creates, last accesed and last modified of file selected
            Console.WriteLine($@"This file was
Created:    {File.GetCreationTime(file)}
Accesed:    {File.GetLastAccessTime(file)}
Modified:   {File.GetLastWriteTime(file)}

Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
