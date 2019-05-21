using System;
using System.IO;
using System.Threading;

namespace Uplvlr
{
    class Program
    {
        private static int count = 0;
        private static string topPath;
        static void Main(string[] args)
        {
            foreach (string path in args)
            {
                topPath = path;
                if (File.Exists(path))
                {
                    // This path is a file
                    Console.WriteLine(path + ": is not a folder path");
                }
                else if (Directory.Exists(path))
                {
                    // This path is a directory
                    ProcessDirectory(path);
                }
                else
                {
                    Console.WriteLine("{0} is not a valid file or directory.", path);
                }
            }
        }


        // Process all files in the directory passed in, recurse on any directories 
        // that are found, and process the files they contain.
        public static void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        public static void ProcessFile(string path)
        { 
            string fileName = Tools.GetFileName(path);
            string destFileName = topPath + "\\" + fileName;
            if (!File.Exists(destFileName))
            {
                File.Copy(path, destFileName, false);
            }

            count++;
            Console.Clear();
            Console.Write(count);
        }
    }
}
