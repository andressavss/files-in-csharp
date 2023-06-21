using System;
using System.IO;

namespace Arquivos;
class Program
{
    static void Main(string[] args)
    {
        string path = @"d:\_temp";

        try
        {
            var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FOLDERS: ");
            foreach (string s in folders)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FILES: ");
            foreach (string s in files)
            {
                Console.WriteLine(s);
            }

            Directory.CreateDirectory(path + @"\newfolder");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(ex.Message);
        }
    }
}


