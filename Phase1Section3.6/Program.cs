using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        static void doApp()
        {

            int number = 20;

            if (number >= 20)
            {
                Console.WriteLine("NUmber is Greater");
            }
            else
            {
                Console.WriteLine("Number is Smaller");
            }
            int num = 20;
            if (num >= 5)
            {
                Console.WriteLine("Coditional Statement :");
                switch (num)
                {
                    case 17:
                        Console.WriteLine("switch result in 17");

                        break;

                    case 18:
                        Console.WriteLine("Switch result in 18");
                        break;

                    case 19:
                        Console.WriteLine("switch result in 19");

                        break;

                    case 20:
                        Console.WriteLine("Switch result in 20");
                        break;                  

                }
                int count = 0;
                Console.WriteLine("Counting from 5 to 1 (while loop):");
                while (count < 5)
                {
                    count++;
                    Console.WriteLine(5 - count + 1);
                }
                Console.WriteLine(  "count from 1 to 10 :");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();



            }

        }
    }
}
