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
            string[] lines = File.ReadAllLines(sourcePath);

            using (StreamWriter sw = File.AppendText(targetPath))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(ex.Message);
        }
    }
}