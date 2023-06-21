using System;
using System.IO;

namespace Arquivos;
class Program
{
    static void Main(string[] args)
    {
        string path = @"d:\_temp\file1.txt";
        
        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
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
