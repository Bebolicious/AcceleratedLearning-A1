using System;
using System.IO;

namespace Systemevents
{
    class Program
    {
        public static void Main()
        {
            string path = @"c:\temp\Statistics.txt";
            Console.WriteLine("You are monitoring the filepath ''C:/Temp'' \n\n");
            File.CreateText(path);
            var fil = new FileSystemWatcher();


            fil.Path = @"C:\Temp";
                fil.EnableRaisingEvents = true;
                fil.Created += FileCreated;
            fil.Changed += FileChanged;
            fil.Deleted += FileDeleted;
            fil.Renamed += FileRenamed;

            Console.ReadKey();
          
        }

        private static void FileRenamed(object sender, RenamedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The file {e.Name} has been renamed");
        }

        static private void FileDeleted(object sender, FileSystemEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"The file {e.Name} has been deleted");
           
        }

       static private void FileChanged(object sender, FileSystemEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"The file {e.Name} has been changed");
            
        }

        static void FileCreated(object sender, FileSystemEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(e.Name + " Was created");
            
        }

    }
}
