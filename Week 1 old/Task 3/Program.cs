using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            int n = int.Parse(line1);
            string[] parts = line2.Split(new char[] { ' ', ',', '$' });
            for(int i=0; i<n;i++)
            {
                Console.Write(parts[i] + " ");
                Console.Write(parts[i]);
                Console.Write(" ");
            }
        }
    }
}
