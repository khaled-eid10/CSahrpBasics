using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Net.Security;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.Common;
using System.Buffers.Text;
using System.Security.Cryptography;

namespace CSahrpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //Passing Value Type Parameters by Value
            //When you pass a value type parameter by value,
            //a copy of the actual value is passed to the method.
            //This means that any changes made to the parameter inside the method do not affect the original value outside the method.

            // Passing Value Type Parameters by Reference
            // When you pass a value type parameter by reference,
            // you pass the reference to the actual value.
            // This means that any changes made to the parameter inside the method will affect the original value outside the method.

            //int value = 10;
            //Console.WriteLine("Original value: " + value);

            //PassByValue(value);
            //Console.WriteLine("After PassByValue: " + value);

            //PassByReference(ref value);
            //Console.WriteLine("After PassByReference: " + value);

            #endregion

            #region Q2  Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //int[] array1 = { 1, 2, 3 }; int[] array2 = { 4, 5, 6 };
            //Console.WriteLine("Before passing by value:"); 
            //PrintArray(array1); 
            //PassByValue(array1); 
            //Console.WriteLine("After passing by value:"); 
            //PrintArray(array1); 
            //Console.WriteLine("Before passing by reference:"); 
            //PrintArray(array2); 
            //PassByReference(ref array2); 
            //Console.WriteLine("After passing by reference:"); 
            //PrintArray(array2);
            #endregion 
            #region Q2 Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            #endregion
            #region Q3 Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //Console.Write("Enter the first number: "); 
            //int num1 = Convert.ToInt32(Console.ReadLine()); 
            //Console.Write("Enter the second number: "); 
            //int num2 = Convert.ToInt32(Console.ReadLine()); 
            //Console.Write("Enter the third number: "); 
            //int num3 = Convert.ToInt32(Console.ReadLine()); 
            //Console.Write("Enter the fourth number: "); 
            //int num4 = Convert.ToInt32(Console.ReadLine()); 
            //int sumResult, subResult; 
            //SumAndSubtractNumbers(num1, num2, num3, num4, out sumResult, out subResult);
            //Console.WriteLine($"Sum of {num1} and {num2} is: {sumResult}");
            //Console.WriteLine($"Subtraction of {num3} from {num4} is: {subResult}");
            #endregion


            #region Q4
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int sum = CalculateSumOfDigits(number);
            //Console.WriteLine($"The sum of the digits of the number {number} is: {sum}");
            #endregion
            #region Q5 Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.Write("Enter an integer: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool isPrime = IsPrime(number);
            //if (isPrime)
            //{
            //    Console.WriteLine($"{number} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a prime number.");
            //}
            #endregion


            #region Q6 Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //Console.Write("Enter the size in the array: "); 
            //int size = Convert.ToInt32(Console.ReadLine()); 
            //int[] array = new int[size]; 
            //Console.WriteLine("Enter the elements of the array:"); 
            //for (int i = 0; i < size; i++) 
            //{ 
            //    array[i] = Convert.ToInt32(Console.ReadLine()); 
            //}

            //  int minValue = array[0];
            //  int maxValue = array[0]; 

            //  MinMaxArray(array, ref minValue, ref maxValue);  
            // Console.WriteLine($"Minimum value in the array is: {minValue}"); 
            // Console.WriteLine($"Maximum value in the array is: {maxValue}");
            #endregion


            #region Q7 Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //long factorial = CalculateFactorial(number);
            //Console.WriteLine($"The factorial of {number} is: {factorial}"); 
            #endregion

            #region Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
            //Console.Write("Enter the original string: "); 
            //string originalString = Console.ReadLine(); 
            //Console.Write("Enter the position (0-based) to modify: "); 
            //int position = int.Parse(Console.ReadLine()); 
            //Console.Write("Enter the new character: "); 
            //char newChar = Console.ReadKey().KeyChar; 
            //Console.WriteLine(); 
            //string modifiedString = ChangeChar(originalString, position, newChar); 
            //Console.WriteLine($"Modified string: {modifiedString}");
            #endregion
        }
        #region Function of Q1
        //static void PassByValue(int number)
        //{
        //    number = 20;
        //    Console.WriteLine("Inside PassByValue: " + number);
        //}

        //static void PassByReference(ref int number)
        //{
        //    number = 30;
        //    Console.WriteLine("Inside PassByReference: " + number);
        //}
        #endregion
        #region Function of Q2
        //static void PassByValue(int[] arr)
        //{
        //    arr[0] = 100;
        //    arr = new int[] { 200, 300, 400 };
        //}
        //static void PassByReference(ref int[] arr)
        //{
        //    arr[0] = 500;
        //    arr = new int[] { 600, 700, 800 };
        //}

        //static void PrintArray(int[] arr)
        //{
        //    foreach (int item in arr)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //} 
        #endregion
        #region Function of Q3
        //static void SumAndSubtractNumbers(int a, int b, int c, int d, out int sum, out int sub)
        //{  
        //    sum = a + b; 
        //    sub = d - c; 
        //}
        #endregion
        #region Function of Q4
        static int CalculateSumOfDigits(int num)
        {
            int sum = 0;
            // Calculate the sum of the digits
            while (num != 0)
            {
                sum += num % 10; num /= 10;
            }
            return sum;
        }
        #endregion
        #region Function of Q5
        //static bool IsPrime(int num)
        //{
        //    if (num <= 1) { return false; }
        //    for (int i = 2; i <= Math.Sqrt(num); i++)
        //    {
        //        if (num % i == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        #endregion
        #region Function of Q6
        //static void MinMaxArray(int[] arr, ref int min, ref int max)
        //{
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //        }
        //        if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //    }
        //}
        #endregion
        #region Function of Q7
        //static long CalculateFactorial(int num)
        //{
        //    long result = 1;
        //    for (int i = 1; i <= num; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //} 
        #endregion
        #region Function of Q8
        static string ChangeChar(string str, int pos, char newChar)
        {
            char[] charArray = str.ToCharArray();
            charArray[pos] = newChar;
            return new string(charArray);
        } 
        #endregion



    }  



}
