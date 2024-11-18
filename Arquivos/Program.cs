using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main (string[] args)
        {
            string soucePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(soucePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(soucePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
        }
    }
}