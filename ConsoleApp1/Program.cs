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
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Diff");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 0) break;
            }
        }
    }
}
