using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = 0, input2 = 0;

            Console.WriteLine("-----CALCULATOR-----");
            Console.WriteLine("--------------------\n");

            Console.WriteLine("Integer 1:");
            input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Integer 2:");
            input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nChoose an option what you want:\n");
            Console.WriteLine("1 --- for ADDITION");
            Console.WriteLine("2 --- for SUBSTRACT");
            Console.WriteLine("3 --- for MULTIPLY");
            Console.WriteLine("4 --- for DIVISION");

            int total = 0;

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine($"Addition : {input1} + {input2} = " + (total = input1 + input2));
                    break;
                case 2:
                    Console.WriteLine($"Substract : {input1} - {input2} = " + (total = input1 - input2));
                    break;
                case 3:
                    Console.WriteLine($"Multiply : {input1} * {input2} = " + (total = input1 * input2));
                    break;
                case 4:
                    Console.WriteLine($"Division : {input1} / {input2} = " + (total = input1 / input2));
                    break;
            }

            Console.WriteLine("TOTAL : " + total);
            Console.ReadKey();
        }
    }
}
