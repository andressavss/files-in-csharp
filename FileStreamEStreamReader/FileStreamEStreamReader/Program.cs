using System;
using System.IO;

namespace Arquivos;
class Program
{
    static void Main(string[] args)
    {
        string path = @"d:\_temp\file1.txt";

        StreamReader sr = null;
        
        try
        {
            sr = File.OpenText(path); // instanciando o FileStream e o StreamReader implicitamente
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (sr != null) sr.Close();
        }
    }
}
