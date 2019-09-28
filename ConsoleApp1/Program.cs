using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("0. Exit");
                if (option == 0) break;
                Console.WriteLine("2. DIFF");
                Console.WriteLine("1. ADD");
            }
        }
    }
}
