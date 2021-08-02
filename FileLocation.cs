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
    class FileLocation
    {
        public void _CopyFile() //select a file and its new location then copies it
        {
            var file = new FileFunction();
            var filePath = file._ChooseFile();
            var fileName = Path.GetFileName(filePath);
            Console.WriteLine("Give new location: ");
            var newLocation = _Where(fileName);
            try
            {
                File.Copy(filePath, newLocation);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void _MoveFile() //selects a file and its new location an moves it
        {
            var file = new FileFunction();
            var filePath = file._ChooseFile();
            Console.WriteLine("Give new location: ");
            var newLocation = _Where("");
            try
            {
                File.Move(filePath, newLocation);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void _ReplaceFile() //selects a two files and replaces them then creates a backup
        {
            var file = new FileFunction();
            var filePath = file._ChooseFile();
            Console.WriteLine("Give new location: ");
            var newLocation = _Where("");
            Console.WriteLine("Give backup location: ");
            var BULocation = _Where("");
            try
            {
                File.Replace(filePath, newLocation, BULocation);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public string _Where(string i) //same as the create a file but lets you choose a file and a location instead of just one location to create a file
        {
            var drive = new LocationFinder();
            var path = drive._Drive();
            string Location = null;
            bool chooseHere = false;
            while (!chooseHere)
            {
                Console.WriteLine($@"
1.Choose Here 
2.View sub Folders?");
                switch (Console.ReadLine())
                {
                    case "1":
                        Location = path + i;
                        chooseHere = true;
                        break;
                    case "2":
                        string holder;
                        holder = drive._FolderPath(path);
                        path = holder;
                        chooseHere = false;
                        break;
                    default:
                        chooseHere = false;
                        break;
                }
            }
        return Location;
        }
    }
}
