using System;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;


namespace lab3_z3
{

    public class Program
    {

        public static void TextWriter(string result)
        {
            using (StreamWriter fileWriter = new StreamWriter("E:\\repository\\lab3_z3\\output.txt"))
            {
                fileWriter.Write(result);
            }
        }

        static void Main(string[] args)
        {
            StreamReader FileRead = new StreamReader("E:\\repository\\lab3_z3\\input.txt");
            Console.WriteLine("|File opened *|");
            string TextOut = FileRead.ReadToEnd();
            Console.WriteLine(TextOut);
            Console.WriteLine("\n");

            Console.WriteLine("|Removing additional text in brackets|");
            Console.WriteLine("\n");
            string pattern = @"\s*\([^()]*\)";
            string result = Regex.Replace(TextOut, pattern, "");
            Console.WriteLine(result);
            Console.WriteLine("\n");

            Console.WriteLine("|Writing text in output.txt|");
            TextWriter(result);

            Console.WriteLine("|Program Finished|");

        }
    }
}