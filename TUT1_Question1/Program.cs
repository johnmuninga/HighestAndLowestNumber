using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TUT1_Question1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] stock = new int[10]; // Declaring stock variable
            int counter = 0; // Declaring Counter  Variable
            
            // Ask the user to enter 10 random numbers
            while (counter < 10)
            {
                Console.Write($"Please Enter Number {counter + 1}: " );
                int value = Convert.ToInt32(Console.ReadLine());
                stock[counter] = value;
                counter++;
            }

            // Find the Lowest and Highest number in the array
            int min = stock[0];
            int max = stock[0];
            for (int i = 1; i < 10; i++)
            {
                if (stock[i] > max)
                {
                    max = stock[i];
                }

                if (stock[i] < min)
                {
                    min = stock[i];
                }
            }
            Console.WriteLine("The Highest value is: " + max);
            Console.WriteLine("The Lowest value is: " + min);

        }
    }
}