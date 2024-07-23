using System;

namespace DaiNi
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Arqam Saleem 5570

            // 1. Write a program that takes two numbers as innput and prints their sum.
            Sum();
            
            // 2. Write a program that prints all even numbers frotn 1 to 100.
            PrintEven1to100();
            
            // 3. Write a function that checks if a given year is a leap year or not.
            CheckLeapYear();
            
            // 4. Write a program that converts kilometers per hours to miles per hour. Hint: 1km = 0.621371.
            ConvertKMPHtoMPH();
            
            // 5. Write a pseudocode to check whether a number is a buzz number or not. Hint: A number is said to be buzz if it is divisible by 7 or if it ends with 7.
            CheckBuzzNumber();
            
            // 6. Write a program that asks a user for number and prints the multiplication table of that number up to 10.
            NumberTable();
            
            // 7. Write a program that computes the factorial of a number (n').
            Factorial();
            
            // 8. Write a function that checks whether a number is prime or not.
            CheckPrime();
            
            // 9. Write a program to check whether the triangle is equilateral, isosceles or scalene triangle.
            //  In a scalene triangle, all the sides of a triangle are of different length.
            //  In an isosceles triangle, two sides of a triangle are of the same measure.
            //  In an equilateral triangle, all the sides of a triangle are of equal length.
            IdentifyTriangle();
            
            // 10. Print this pattern: (using multiple prints and then by loop)
            //    *
            //    **
            //    ***
            //    ****
            //    *****
            PrintPattern();
            
            // Bonux. Write a program that takes two numbers as innput and prints their sum.
            CheckPalindrome();

            Console.ReadLine();
        }

        static void Sum()
        {
            Console.WriteLine("\nPROGRAM <Sum> \n\n");

            //Input First Number
            Console.Write("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            
            //Input Second Number
            Console.Write("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            //Print Result
            Console.WriteLine("Sum: " + (number1 + number2));
        }

        static void PrintEven1to100()
        {
            Console.WriteLine("\nPROGRAM <PrintEven1to100> \n\n");

            //For Loop from 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                //Check for Even Condition
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static void CheckLeapYear()
        {
            Console.WriteLine("\nPROGRAM <CheckLeapYear> \n\n");

            //Take Input Year as Input
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            
            //Check for Leap Condition
            if (year % 4 == 0)
            {
                Console.WriteLine(year + " is a Leap Year!");
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year!");
            }
        }

        static void ConvertKMPHtoMPH()
        {
            Console.WriteLine("\nPROGRAM <ConvertKMPHtoMPH> \n\n");

            //Take Input Speed in KMPH
            Console.Write("Enter speed in KMPH: ");
            double speed = Convert.ToDouble(Console.ReadLine());
            //Origianl Speed
            Console.WriteLine("Original Speed in KMPH: " + speed);
            //Speed in MPH
            Console.WriteLine("Converted Speed in MPH: " + speed * 0.621371);
        }

        static void CheckBuzzNumber()
        {
            Console.WriteLine("\nPROGRAM <CheckBuzzNumber> \n\n");

            //Take the Input Number
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            //Check for Buzz Condition
            if (number % 7 == 0 || number % 10 == 7)
            {
                Console.WriteLine(number + " is a Buzz Number!");
            }
            else
            {
                Console.WriteLine(number + " is not a Buzz Number!");
            }
        }

        static void NumberTable()
        {
            Console.WriteLine("\nPROGRAM <NumberTable> \n\n");

            //Take the Number Input
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            //For Loop to Display Table 
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(number + " X " + i + " = " + number * i);
            }
        }

        static void Factorial()
        {
            Console.WriteLine("\nPROGRAM <Factorial> \n\n");

            //Take the Input Number
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            //Intialize Default Result
            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine("Factorial of " + number + " is = " + result);
        }

        static void CheckPrime()
        {
            Console.WriteLine("\nPROGRAM <CheckPrime> \n\n");

            //Take the Input Number
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            //Intialize Prime Flag
            bool isPrime = true;
            //Loop to establish and verify Prime condition
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            //Check Flag Status
            if (isPrime)
            {
                Console.WriteLine(number + " is a Prime Number!");
            }
            else
            {
                Console.WriteLine(number + " is not a Prime Number!");
            }
        }

        static void IdentifyTriangle()
        {
            Console.WriteLine("\nPROGRAM <IdentifyTriangle> \n\n");

            //Take The Value of the 3 sides of the Triangle as Input
            Console.Write("Enter side 1: ");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter side 2: ");
            int side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter side 3: ");
            int side3 = Convert.ToInt32(Console.ReadLine());
            //Check for Equilatral Triangle
            if (side1 == side2 && side1 == side3)
            {
                Console.WriteLine("It is an Equilateral Triangle!");
            }
            //Check for Isosceles Triangle
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("It is an Isosceles Triangle!");
            }
            //Else Scalene Triangle
            else
            {
                Console.WriteLine("It is an Scalene Triangle!");
            }
        }

        static void PrintPattern()
        {
            Console.WriteLine("\nPROGRAM <PrintPattern> \n\n");

            //By Console Writeline
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("*****");
            
            //By Nested Loop 
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void CheckPalindrome()
        {
            Console.WriteLine("PROGRAM <CheckPalindrome> \n\n");

            //Take the Input Number
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            //Intializ the Reverse and Number Duplicate Instance
            int reverse = 0;
            int numberCopy = number;
            //Loop to evaluate and obtain the reverse of the number
            while (numberCopy != 0)
            {
                reverse = reverse * 10 + (numberCopy % 10);
                numberCopy /= 10;
            }
            //Compare the number and its reverse to check for Palindrome
            if (reverse == number)
            {
                Console.WriteLine(number + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(number + " is not a Palindrome!"); 
            }
        }
    }
}