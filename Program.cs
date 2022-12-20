using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project__1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this program print Prime numbers from <n1> to <n2>");
        
            Console.Write("Enter the number to start counting from: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the number to stop counting to: ");

            int num2 = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = num1; i <= num2; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(i);
                    count = 0;
                }
                else
                {
                    count = 0;
                    continue;
                }
            }
            Console.ReadKey();


        }


    }

}   


