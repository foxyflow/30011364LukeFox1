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
            //Q6
            Console.WriteLine("Enter r ... for circumference");
            double radius = double.Parse(Console.ReadLine());
            //area 
            //and circomference 
            double pi = 3.14;

            Console.WriteLine($"circumference = {(radius * 2) * pi}");

            //Q6 part 2 area:
            Console.WriteLine("enter r ... for area");
            double radius4Area = double.Parse(Console.ReadLine());

           Console.WriteLine($"area = {radius* radius *pi}");


            

            



               
            Console.WriteLine("Hello");
            Console.ReadLine();
            Console.WriteLine("Luke Fox");

            Console.WriteLine("Please enter another name");
            string name = Console.ReadLine();

            //2
            int sum = 74 + 36;
            Console.WriteLine(sum);
            Console.ReadLine();
            //3
           int answer = 50 / 3;
            Console.WriteLine(answer);
            Console.ReadLine();

            //4
            int num1 = 25;
            int num2 = 5;
            int ints = num1 + num2;
            Console.WriteLine(ints);

            //5


            /*for (int i; i < 81; i*8+)
            {
                i = 8;
            }
                int ml=8;
    */
            Console.WriteLine("enter a number");





            double input = double.Parse(Console.ReadLine());
          for (double i=1; i <11; i++)
            {
                Console.WriteLine($" {input} x {i}  = {i*input} ");
                Console.WriteLine("Press enter");
                Console.ReadLine();
            }
           



            //re Q1 
        }
        static string Q1()
        {
            Console.Write("Please enter name");
            string name = Console.ReadLine();
            return name;
        }

     
           

            



       



    }
}
