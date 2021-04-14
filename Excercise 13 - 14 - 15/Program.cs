using System;

namespace Excercise_13___14___15
{
    class Program
    {

        static void Main(string[] args)
        {

            //For loop to output all numbers from i to 0
            
            {
                Console.WriteLine("Please enter a number ");
                int num = int.Parse(Console.ReadLine());
                for (int i = num; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }

                //start of looping program that I could never get to work properly
                //Console.WriteLine("Would you like to continue? y/n ");
                //Console.ReadLine();

            }
            
                   

            //For loop to output squares of numbers from 1 to x

            Console.WriteLine("Please enter a number ");
            int num2 = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= num2; i++)
            {
                
                Console.WriteLine(i * i);
            }



            //For loop to output cubes of numbers from 1 to x

            Console.WriteLine("Please enter a number ");
            int num3 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num3; i++)
            {
                Console.WriteLine(i * i * i);
            }
        }
             
    }   
}

