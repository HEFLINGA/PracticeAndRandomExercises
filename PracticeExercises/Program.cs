﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicDeclarationExpressions examples = new BasicDeclarationExpressions();
            // Prints name dob and mobile
            examples.Exercise1("Auston Hefling", "June 15, 1995", "(509) 675-5183");

            // Simple version of printing something in reverse
            Console.WriteLine(examples.Exercise2());

            // Simple multiplication method
            examples.Exercise3();

            // Simple loop for testing data to be equal
            examples.Exercise4();

            // Simple even or odd check
            examples.Exercise5();

            // Simple Word uniquness checker between letters of user entered word
            examples.Exercise6();

            // Simple string reversing program
            examples.Exercise7();

            // Simple string spacing program
            examples.Exercise8();

            // Checks if string is Palindrome
            examples.GetExercise9();

            // Swtich 2 integers values with each other
            examples.Exercise10();
        }
    }
}
