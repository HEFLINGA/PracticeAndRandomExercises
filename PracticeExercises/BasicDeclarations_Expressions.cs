using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    public class BasicDeclarations_Expressions
    {
        public void Exercise1(string name, string DOB, string Mobile)
        {
            var myName   = $"Name   : {name}";
            var myDOB    = $"DOB    : {DOB}";
            var myMobile = $"Mobile : {Mobile}";

            Console.WriteLine(myName);
            Console.WriteLine(myDOB);
            Console.WriteLine(myMobile);
        }
        public string Exercise2()
        {
            var reverse = "";

            char char1 = 'X';
            char char2 = 'M';
            char char3 = 'L';
            
            reverse = $"The inverse of : {char1}{char2}{char3}";
            reverse += $"\nis             : {char3}{char2}{char1}";
            
            return reverse;
        }
        public void Exercise3()
        {
            double answer = 0;
            Console.WriteLine("Multiplication!");
            Console.WriteLine("Enter your first number: ");
            double input1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            double input2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your third number: ");
            double input3 = Convert.ToDouble(Console.ReadLine());

            answer = input1 * input2 * input3;

            Console.WriteLine($"{input1} x {input2} x {input3} = {answer}");
        }
        public void Exercise4()
        {
            

            Console.WriteLine("Please input first number: ");
            int input = int.Parse(Console.ReadLine());
            int x = input;

            Console.WriteLine("Please input second number: ");
            input = int.Parse(Console.ReadLine());

            if (x == input)
            {
                Console.WriteLine($"First input: {x}, Second input: {input}. They are equal");
            }
            else
            {
                Console.WriteLine($"Input {x} and {input} are not equal.");
            }
        }
        public void Exercise5()
        {
            Console.WriteLine("Input a number!:");
            int input = int.Parse(Console.ReadLine());

            int rem = input % 2;

            if (rem == 0)
            {
                Console.WriteLine("Number is even!");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}
