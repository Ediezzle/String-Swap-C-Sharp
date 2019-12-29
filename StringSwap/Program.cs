using System;

namespace StringSwap
{
    
    class Program
    {
        static string swapStrings(string s1, string s2)
        {
            s1 = s1 + s2;
            s2 = s1.Substring(0, s1.Length - s2.Length);
            s1 = s1.Substring(s2.Length);
            return "s1 is now " + s1 + " " + "s2 is now " + s2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(swapStrings("eddie", "mandx"));
            
            
        }
    }
}
