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
    class Menu
    {
       public void _Menu()
        {
            bool displayMenu = true;    //while display menu is true, display the main menu
            while (displayMenu)
            {
                displayMenu = _MainMenu();
            }
        }
        private static bool _MainMenu() //main menu: create or modify a file
        {
            Console.WriteLine(@"Main Menu

    1. Create a File
    2. Modify a File
    Press Enter to Exit...");
            switch(Console.ReadLine())
            {
                case "1":               //case 1: create a new file
                    Console.Beep();
                    Console.Clear();
                    FileFunction createFile = new FileFunction();
                    createFile._FileName();
                    return true;
                case "2":               //case 2: go to modify menu with option to return back
                    Console.Beep();
                    Console.Clear();
                    bool displayModifyMenu = true;
                    while (displayModifyMenu)
                    {
                        displayModifyMenu = _ModifyMenu();
                    }
                    return true;
                default:
                    Console.Beep();
                    Console.Clear();
                    Console.WriteLine("Press Space to exit..");
                    return false;
            }
        }
        private static bool _ModifyMenu()
        {
            Console.WriteLine(@"Modify Menu
    
    1. Read a File
    2. Delete a File
    3. Get File Information
    4. Write on a File
    5. Change File Location
    Press Enter to go back...");
            var workingFile = new FileFunction();               //allocating memory for variable
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Beep();
                    Console.Clear();
                    Console.WriteLine("Delete File");
                    workingFile._ReadFile();                  //read file method calling
                    return true;
                    break;
                case "2":
                    Console.Beep();
                    Console.Clear();
                    Console.WriteLine("Delete File");
                    workingFile._DeleteFile();                  //delete file method calling
                    return true;
                case "3":
                    Console.Beep();
                    Console.Clear();
                    Console.WriteLine("Get File Information");
                    workingFile._FileInfo();                    //file info method calling
                    return true;
                case "4":                                       //go to writing menu with option to return
                    Console.Beep();
                    Console.Clear();
                    bool displayWritingMenu = true;
                    while (displayWritingMenu)
                    {
                        displayWritingMenu = _WritingMenu();
                    }
                    return true;    
                case "5":                                       //go to location menu with option to return
                    Console.Beep();
                    Console.Clear();
                    bool displayMoveMenu = true;
                    while (displayMoveMenu)
                    {
                        displayMoveMenu = _LocationMenu();
                    }
                    return true;
                default:
                    Console.Beep();
                    Console.Clear();
                    Console.WriteLine("Press Space to go back...");
                    return false;
            }
        }
        private static bool _WritingMenu()
        {
            Console.WriteLine(@"Write Menu

    1. Add text to a File
    2. Replace text on a File
    3. Append text to a File
    Press Enter to go back...");
            var workingFile = new FileFunction();
            switch (Console.ReadLine())
            {
                case "1":                               //add new text to an empty file
                    Console.Beep();
                    Console.Clear();
                    workingFile._AddTextToEmpty();
                    return true;
                case "2":                               //replace all texte in a file
                    Console.Beep();
                    Console.Clear();
                    workingFile._ReplaceText();
                    return true;                        //add text to a file that already has text
                case "3":
                    Console.Beep();
                    Console.Clear();
                    workingFile._AddTextToText();
                    return true;
                default:
                    Console.Beep();
                    Console.Clear();
                    Console.WriteLine("Press Space to go back...");
                    return false;
            }
        }
        private static bool _LocationMenu()
        {
            Console.WriteLine(@"Location Menu Menu

    1. Copy a File
    2. Move a File
    3. Replace a File
    Press Enter to go back...");
            var workingFile = new FileFunction();
            switch (Console.ReadLine())
            {   
                case "1":                                 //Copy a file
                    Console.Beep();
                    Console.Clear();
                    workingFile._CopyFile();
                    return true;
                case "2":                                   //move a file
                    Console.Beep();
                    Console.Clear();
                    workingFile._MoveFile();
                    return true;
                case "3":                                   //replace a file
                    Console.Beep();
                    Console.Clear();
                    workingFile._ReplaceFile();
                    return true;
                default:
                    Console.Beep();
                    Console.Clear();
                    Console.WriteLine("Press Space to go back...");
                    return false;
        }
    }
    }   
}
