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
        public void Exercise6()
        {
            Console.WriteLine("Please enter a word!");
            string wrd = Console.ReadLine();
            bool check = true;

            for (int i = 0; i < wrd.Length; ++i)
            {
                for (int j = i + 1; j < wrd.Length; ++j)
                {
                    if (wrd[i] == wrd[j])
                    {
                        check = false;
                        Console.WriteLine($"With word {wrd} not all letters are unique. {wrd[i]} is not unique");
                        break;
                    }
                }
            }
            if (check == true)
            {
                Console.WriteLine($"With word {wrd}, no letters repeat and all are unique!");
            }     
        }
        public void Exercise7()
        {
            Console.WriteLine("Enter a word: ");
            string wrd = Console.ReadLine();

            for (int j = wrd.Length - 1; j >= 0; j--)
            {
                Console.Write($"{wrd[j]}");
            }
            Console.WriteLine("");      
        }
        public void Exercise8()
        {
            Console.WriteLine("Enter word: ");
            string wrd = Console.ReadLine();

            for (int i = 0; i < wrd.Length; i++)
            {
                Console.Write($"{wrd[i]} ");
            }
        }
        private static bool Exercise9(string text)
        {
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    return Exercise9(text.Substring(1, text.Length - 2));
            }
        }
        public void GetExercise9()
        {
            Console.Write("\n\n Recursion : Check whether a string ia Palindrome or not :\n");
            Console.Write("---------------------------------------------------------------\n"); 
	        string str1;
            bool tf;

            Console.Write(" Input a string : ");
            str1 = Console.ReadLine();
            tf=Exercise9(str1);
            if (tf==true)
            {
            Console.WriteLine(" The string is Palindrome.\n");
            }
            else
            {
            Console.WriteLine(" The string is not a Palindrome.\n");
            }
        }
        public void Exercise10()
        {
            Console.WriteLine("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int y = int.Parse(Console.ReadLine());
            int xy = 0;

            Console.WriteLine($"Your first input was {x}");
            Console.WriteLine($"Your second input was {y}");
            Console.WriteLine("");
            xy = x;
            x = y;
            y = xy;
            Console.WriteLine($"Now that first input is {x}");
            Console.WriteLine($"And the second input is {y}");
        }
    }
}