using System;

namespace DaiNi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  1.Write a program to delete the duplqicates from an array.
            List<int> list1 = new List<int> { 2, 2, 5, 2, 0 , 8, 5 , -9 , 0 , 0 , 3 , 8};
            list1 = DeleteDuplicate(list1);
            Console.WriteLine(string.Join(", ", list1));

            //  2.Write a program to find the largest and the second largest number in an array.
            FindThe2Largest(list1);

            //  3.Write a program that places all the zeros in an array at the end of the list.
            list1 = ZeroToEnd(list1);
            Console.WriteLine(string.Join(", ", list1));

            //  4.Write a program to find the first non - repeating character in a string.   
            string test = "Axelotal";
            char Hansolo = FirstSolo(test);
            Console.WriteLine($"Ze One, Ze Only le han solo: {Hansolo}");

            //  5.Write a program to merge two sorted arrays into a single sorted array.
            List<int> list2 = new List<int> { 3 , 0 , 4 , 2 , 1 , 6 };
            List<int> list3 = MergeSorted(list1 , list2);
            Console.WriteLine(string.Join(", ", list3));

            //  6.Write a program to find the missing number in an array containing n distinct numbers taken from 0, 1, 2, ..., n.
            int num2 = MissingNo(list2);
            Console.WriteLine($"{num2} is the missing no inn the list");

            //  7.Write a program to check whether a number is Armstrong number or not.
            //  Hint: Armstrong number is a number that is equal to the sum of cubes of its digits.
            int num = 534;
            Armstrong(num);

            //  8.Write a program to find the longest common prefix in an array of strings.
            List<string> words = new List<string> { "international", "intermitten", "intertellar" };
            string prefix = LargestCommonPrefix(words);
            Console.WriteLine(prefix + " is the Longest Common prefix among the given strings");

            //  9.Write a program that prints the Fibonacci sequence up to n terms(where n is user input).
            int terms = 15;
            Fibonacci(terms);

            //  10.Write a program that reads N integers, determines how many positive and negative values have been read and computes the total and average of input values.
            Console.Write("Write the Size of the Dynamic Array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            List<int> list4 = new List<int>(size);
            for (int i = 0; i < size; i++)
            {
                Console.Write($"\nEnter integer {i}: ");
                list4.Add(Convert.ToInt32(Console.ReadLine()));
            }
            DynamicArrayDetails(list4);

            Console.ReadLine();
        }

        static List<int> DeleteDuplicate(List<int> original)
        {
            //PROGRAM <DeleteDuplicate>

            //Outer Loop to Traverse Array 
            for (int i = 0; i < original.Count; i++)
            {
                //Inner Loop to check for Duplicates
                for (int j = i + 1; j < original.Count; j++)
                {
                    if (original[i] == original[j])
                        original.RemoveAt(j);
                }
            }
            return original;
        }

        static void FindThe2Largest(List<int> original)
        {
            //PROGRAM <FindThe2Largest>

            int Largest = original[0];
            int Larger = Largest - 1;

            //Outer Loop to Traverse Array 
            for (int i = 1; i < original.Count; i++)
            {
                if (original[i] > Largest)
                {
                    Larger = Largest;
                    Largest = original[i];
                }
            }
            Console.WriteLine($"The Largest of the Array is = {Largest} and the 2nd Largest is {Larger}");
        }

        static List<int> ZeroToEnd(List<int> original)
        {
            //PROGRAM <ZeroToEnd>
            if (original.Contains(0))
            {
                //Outer Loop to Traverse Array 
                for (int i = 0; i < original.Count; i++)
                {
                    if (original[i] == 0)
                    {
                        //Inner Loop to move zeros
                        for (int j = i; j < original.Count - 1; j++)
                        {
                            original[j] = original[j + 1];
                            original[original.Count - 1] = 0;
                        }
                    }
                }
            }
            return original;
        }

        static char FirstSolo(string original)
        {
            //PROGRAM <FirstSolo>

            char HanSolo = ' ';

            //Outer Loop to Traverse Array 
            for (int i = 0; i < original.Length; i++)
            {
                //Inner Loop to check for Duplicates
                for (int j = i + 1; j < original.Length; j++)
                {
                    if (original[i] == original[j])
                        break;
                    if (j == original.Length - 1)
                        HanSolo = original[i];
                }
                if (HanSolo != ' ')
                    break;
            }
            return HanSolo;
        }

        static List<int> MergeSorted(List<int> list1, List<int> list2)
        {
            //PROGRAM <MergeSorted>
            list1.AddRange(list2);
            List<int> result = list1;
            int Temp = 0;

            //Sort the new array using Bubble Sort 
            for (int i = 0; i < result.Count; i++)
            {
                for (int j = i + 1; j < result.Count - 1; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        Temp = result[j + 1];
                        result[j + 1] = result[j];
                        result[j] = Temp;
                    }
                }
            }
            return result;
        }

        static int MissingNo(List<int> original)
        {
            //PROGRAM <MissingNo>

            int Lost = -1;
            for (int i = 0; i < original.Count; i++)
            {
                //Inner Loop to check for missing no
                for (int j = 0 + 1; j < original.Count; j++)
                {
                    if (j == original.Count - 1 && original[j] != i)
                    {
                        Lost = i;
                        break;
                    }

                }
                if (Lost != -1)
                    break;
            }
            return Lost;
        }

        static void Armstrong(int original)
        {
            //PROGRAM <Armstrong>
            int Temp = original;
            int Sum = 0;
            bool IsArm = false;
            //Calculate the Sum of the Cubes of the integers
            while (Temp != 0)
            {
                Sum += (Temp % 10) ^ 3;
                Temp = Temp / 10;
            }
            if (Sum == original)
                IsArm = true;
            if (IsArm)
                Console.WriteLine($"{original} is an armstrong number!");
            else
                Console.WriteLine($"{original} is not an armstrong number!");
        }

        static string LargestCommonPrefix(List<string> original)
        {
            //PROGRAM <LargestCommonPrefix>

            string prefix = "";
            for (int i = 0; i < original[0].Length; i++)
            {
                prefix += original[0][i];
                for (int j = 1;j<original.Count ;j++)
                {
                    //Match New char for each word
                    if (original[0][i] != original[j][i] )
                    {
                        prefix = prefix.Remove(prefix.Length - 1,1);
                        break;
                    }
                }
                //Check if new char remained or was removed
                if (prefix.Length == i)
                    break;
            }
            return prefix;

        }

        static void Fibonacci(int N)
        {
            //PROGRAM <Fibonacci>
            int T1 = 0, T2 = 1, temp = 0;
            Console.WriteLine(T1 + " " + T2 + " ");
            for (int i = 3; i <= N; i++)
            {
                temp = T2;
                T2 += T1;
                T1 = temp;
                Console.WriteLine(T2 + " ");
            }

        }

        static void DynamicArrayDetails(List<int> original)
        {
            //PROGRAM <DynamicArrayDetails>

            double Sum = 0;
            int CountPositive = 0, CountNegative = 0;
            //Loop to Traverse Array 
            for (int i = 0; i < original.Count; i++)
            {
                Sum += original[i];
                if (original[i] >= 0)
                    CountPositive++;
                else
                    CountNegative++;
            }
            Console.WriteLine($"\nThe number of Positive Integers: {CountPositive}\nThe number of Negative Integers: {CountNegative}\nSum of Integers: {Sum}\nAverage: {Sum / original.Count}");
        }
    }
}