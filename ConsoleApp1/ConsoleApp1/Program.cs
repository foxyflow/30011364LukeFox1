using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1//30011364 LukeFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1
            Console.WriteLine("(please type your name)");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello \n{name}");
            Console.ReadLine();

            //Q2
            Console.WriteLine("74 + 36");
            int sum = 74 + 36;
            Console.WriteLine(sum);
            Console.ReadLine();

            //Q3 
            Console.WriteLine("50 divided by 3");
            int answer = 50 / 3;
            Console.WriteLine(answer);
            Console.ReadLine();

            //Q4: 
            Console.WriteLine("25 times 5");
            int num1 = 25;
            int num2 = 5;
            int product = num1 * num2;
            Console.WriteLine(product);

            //Q5: times-tables
            Console.WriteLine("enter a number to make a times-table");
            double input = double.Parse(Console.ReadLine());
          for (double i=1; i <11; i++)
            {
                Console.WriteLine($" {input} x {i}  = {i*input} ");
            }
            Console.ReadLine();


            //Q6: Circumference and cicle-area
            double pi = 3.14;
            Console.WriteLine("Please enter a radius");
            double radius = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"circumference and circle area = {(radius*2) * pi} ");
            Console.WriteLine($"and {(radius*radius) * pi}");
            Console.ReadLine();


            //Q7: Value Swap:
            //Before swap: A = 10 B= 20
            //After swap: A = 20 B = 10
            int a = 10,b = 20,temp;
            

            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a = 10; b = 20 (swap them)");
            Console.WriteLine($" displaying new a: {a} displaying new b: {b}");
            Console.ReadLine();

           
            
            
            
            //Q8: (new: is instanciating (copying) the object)
            int[] numbers = new int[100];

            Random rand = new Random();
            rand.Next(1000, 9999);
            Console.ReadLine();




                //Q9 clue use if or switch statments maybe a while loop

            



            //Q10 Animal class with loop.



            

                    


            //End of mainMethod 
        }
        
        


        static string Q1()
        {
            Console.WriteLine("We are finished. Goodbye");
            string name = Console.ReadLine();
            return name;
        }

        //static string Q2()
        

        


    }
}
