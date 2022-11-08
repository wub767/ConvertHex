using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {

        //get string
        Console.WriteLine("Enter a string to get it in hex code:");
        string input = Console.ReadLine().ToLower();

        //convert to num/hex
        int inputNum = Int32.Parse(input, System.Globalization.NumberStyles.HexNumber);

        string output = string.Format("{0:X8}", inputNum);

        Console.WriteLine(input + " in hex is " + output);

    }
}