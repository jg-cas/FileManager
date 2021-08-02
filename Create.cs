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
    class Create:WriteInFile
    {
        public string _FileName()
        {
            Console.WriteLine($"Name your New File{Environment.NewLine}");
            string fileName = Console.ReadLine();
            Console.Beep();
            fileName = $"{fileName}.txt"; //already formats the selected name to .txt
            var drive = new LocationFinder();
            var path = drive._Drive(); //select what drive to create your folder into
            string newFile = null;
            bool createHere = false;
            while (!createHere)
            {
                Console.WriteLine($@"
1.Create Here 
2.View sub Folders?");
                switch (Console.ReadLine())
                {
                    case "1":
                        newFile = path + fileName; //if you choose a folder to create, creates folder and exits loop
                        if (!File.Exists(newFile))
                        {
                            try
                            {
                                File.Create(newFile);
                                Console.WriteLine($"You created {newFile}");

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("File already exists");
                        }
                        createHere = true;
                        break;
                    case "2": //otherwise keeps updating path with new folder until you find the folder in which you want to create
                        string holder; 
                        holder = drive._FolderPath(path);
                        path = holder;
                        createHere = false;
                        break;
                    default:
                        createHere = false;
                        break;
                }
            }
            return newFile; //return new file name that was created in string format
        }
    }
}
