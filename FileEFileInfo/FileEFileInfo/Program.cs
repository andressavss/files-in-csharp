using System;
using System.IO;

namespace Arquivos;
class Program
{
    static void Main(string[] args)
    {
        string sourcePath = @"d:\_temp\file1.txt";
        string targetPath = @"d:\_temp\file2.txt";

        try
        {
            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetPath);
            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(ex.Message);
        }
    }
}