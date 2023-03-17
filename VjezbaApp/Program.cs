using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace VjezbaApp
{
    public class CreateFolder
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Users\HPofDada\Documents\CeeSharpFriday\FileIO";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            //specify the path to and the name of the file
            string filePath = @"C:\Users\HPofDada\Documents\CeeSharpFriday\FileIO\1stFile.txt";

            try
            {
                //create file if it doesn't exist
                if (!File.Exists(filePath))
                {
                    using (StreamWriter writer = File.CreateText(filePath))
                    {
                        writer.WriteLine("Let's write something");
                        writer.WriteLine("Author: Me!");
                    }

                }

                using (StreamReader reader = File.OpenText(filePath))
                {
                    string text;
                    while ((text = reader.ReadLine()) != null)
                    { Console.WriteLine(text); }
                }
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }


        
             
        }       
    }
}
