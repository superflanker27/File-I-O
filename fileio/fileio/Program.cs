using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // use  file io


namespace fileio
{
    class Program
    {
        static void Main(string[] args)
        {

            //we use this to create, move, ennumerate though directories or subdirectories. "dir" is the variable name, you can replace with anything u want
           DirectoryInfo dir = new DirectoryInfo(".");      
           DirectoryInfo testfolder = new DirectoryInfo(@"C:\Users\ISLI\Desktop\fortesting");

            // prints info about 'testfolder'
           Console.WriteLine("- Info about testfolder -");
           Console.WriteLine("location: " + testfolder.FullName);   
           Console.WriteLine("attributes: " + testfolder.Attributes);
           Console.WriteLine("creation time: " + testfolder.CreationTime);
           Console.WriteLine("existence: " + testfolder.Exists);
           Console.WriteLine("folder name: " + testfolder.Name);
           Console.WriteLine("parent dir: " + testfolder.Parent);

            // deletes the 'sub' directory.
            //  Directory.Delete(@"C:\Users\ISLI\Desktop\fortesting\sub");


            // writing text to a file

            //first we assing a variable to the path of where we want to write (u can write new file or write in existing file)
            string Path = @"C:\Users\ISLI\Desktop\fortesting\idk.txt";

          // decode what we wamma write, in this case its a list but it can be anything
            string[] platformslist =
            {
                "Telegram",
                "WhatsApp",
                "ToxChat",
                "Kontakt" //we don't have to put , here cuz its the last one

            };

            //write to the file, if its a simple string you MUST use "File.WriteAllText"
            try
            {

            
            File.WriteAllLines(Path, platformslist);
                //print some blank space so console doesn't look ugly
                Console.WriteLine();  
                //print that it was done
                Console.WriteLine("Text File " + Path + " has been written");
            }
            catch
            {
                //if it fails, print error
                Console.WriteLine("Error!");
            }

            
            // now we read all the lines in the file we wrote
            foreach (string datatext in File.ReadAllLines(Path))
            //print text in the file
            Console.WriteLine(datatext);
           


            Console.ReadKey(); // waits for you to press a key, this is so console will stay open until we press a key

        }
    }
}
