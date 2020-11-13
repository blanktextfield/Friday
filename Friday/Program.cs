using System;
using System.IO;
namespace Friday
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\mammu\samples";
            string[] allDirectories = Directory.GetDirectories(rootPath);
            string[] includeNestedDirectories = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            ReadArray(files);
        }
        public static void ReadArray(string[]array)
        {
            foreach (string line in array)
            {
                Console.WriteLine(line);
            }
            {
                WriteFilePaths();
            }
        }
        private static void WriteFilePaths()
        {
            string filepath = @"C:\Users\mammu\Friday\samplefiles.txt";
            string filepath1 = @"C:\Users\mammu\Friday\sampleDirectories.txt";
            string directoryPath = @"C:\Users\mammu\samples";
            string[] files = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);
            string[] includeNestedDirectories = Directory.GetDirectories(directoryPath, "*", SearchOption.AllDirectories);

            File.WriteAllLines(filepath1, includeNestedDirectories);
            File.WriteAllLines(filepath, files);
        }

    }
}
