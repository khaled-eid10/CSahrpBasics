using System.Diagnostics.Metrics;
using System.Net.Security;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace CSahrpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment C# 03
            /*
            #region Q 1 Write a program that allows the user to enter a number then print it.

            Console.Write("Enter a number: ");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine(Number);
            #endregion

            #region Q 2 Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 

            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            int number = Convert.ToInt32(str);
            Console.WriteLine(number);
            //System.FormatException: 'The input string 'ahmed' was not in a correct format.'
            #endregion

            #region Q 3 Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            float floatNumber = 12.4F;
            double doubleNumber = 10.7;
            //Perform arithmetic operations
            double sum = floatNumber + doubleNumber;
            double difference = floatNumber - doubleNumber;
            double multiply = floatNumber * doubleNumber;
            double divide = floatNumber / doubleNumber;
            //Display the results
            Console.WriteLine($"Addition: {floatNumber} + {doubleNumber} = {sum}");
            Console.WriteLine($"Subtraction: {floatNumber} - {doubleNumber} = {difference}");
            Console.WriteLine($"Multiplication: {floatNumber} * {doubleNumber} = {multiply}");
            Console.WriteLine($"Division: {floatNumber} / {doubleNumber} = {divide}");
            #endregion

            #region Q 4 Write C# program that Extract a substring from a given string.

            Console.Write("Enter the string: ");
            string strr = Console.ReadLine();
            Console.Write("Enter the Start Position: ");
            int StartPosition = int.Parse(Console.ReadLine());
            Console.Write("Enter the SubString Length: ");
            int Length = int.Parse(Console.ReadLine());

            string SubString = strr.Substring(StartPosition, Length);
            Console.WriteLine($"SubString:{SubString}");
            #endregion

            #region Q 5 Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int a = 25;
            int b = a;

            Console.WriteLine("Before Modification: ");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            b = 30;
            Console.WriteLine("After Modification: ");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            //Before modification: Both a and b have the value 10.
            //After modification: b changes to 20, but a remains 10.
            //with value types, when you assign one variable to another, you are copying the value, not referencing it.
            //This means changes to one variable will not affect the other.
            #endregion


            #region Q 6 Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            string str1 = "Hello";
            string str2 = str1;

            Console.WriteLine("Before Modification: ");
            Console.WriteLine($"Str 1 = {str1}");
            Console.WriteLine($"Str 2 =  {str2}");

            str2 = "World!";
            Console.WriteLine("After Modification: ");
            Console.WriteLine($"Str 1 =  {str1}");
            Console.WriteLine($"Str 2 =  {str2}");
            //         Before modification:
            //Both str1 and str2 refer to the same string object "Hello".
            //         After modification:
            //str2 is assigned a new string "World", but str1 still refere to the original string "Hello".
            // and str1 equal "Hello" and str2 becomes "World".
            #endregion

            #region Q 7 Write C# program that take two string variables and print them as one variable 

            Console.Write("Enter the first string: ");
            string FirstString = Console.ReadLine();
            Console.Write("Enter the second string: ");
            string SecondString = Console.ReadLine();

            //string CombineStrings = FirstString + SecondString;
            //Console.WriteLine($"Combination: {CombineStrings}");
            //Console.WriteLine($"Combination: {FirstString + SecondString}");
            #endregion

            #region Q 8 Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.

            double Principal, rate, time, interest;
            Console.Write("Enter the Principal Amount: ");
            Principal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the rate: ");
            rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the time: ");
            time = Convert.ToDouble(Console.ReadLine());

            interest = (Principal * rate * time) / 100;
            Console.WriteLine($"Interest: {interest}");
            #endregion

            #region Q 9 Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height)

            double Weight, Height, BMI;
            Console.Write("Enter the Body Weight: ");
            Weight = double.Parse(Console.ReadLine());
            Console.Write("Enter the Body Height: ");
            Height = double.Parse(Console.ReadLine());

            BMI = (Weight) / (Height * Height);

            Console.WriteLine($"The Body Mass is = {BMI}");
            #endregion

            #region Q 10 Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".

            string good = "Just Good";
            string cold = "Just Cold";
            string hot = "Just Hot";
            Console.Write("Enter the temperature: ");
            int Temperature = int.Parse(Console.ReadLine());

            string TemperatureStatus = Temperature < 10 ? cold : Temperature > 30 ? hot : good;

            Console.WriteLine($"Temperature is {TemperatureStatus}");
            #endregion

            #region Q 11 Write a program that takes the date from the user and displays it in various formats using string interpolation. Ex: Today’s date : 20 , 11 , 2001 || Today's date : 20 / 11 / 2001|| Today's date : 20 – 11 – 2001

            Console.Write("Enter the day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Today's date: {day} , {month} , {year}");
            Console.WriteLine($"Today's date: {day} / {month} / {year}");
            Console.WriteLine($"Today's date: {day} – {month} – {year}");
            #endregion


            // Q 12
            // c

            //-----------------------------------------------------------//

            // Q 13
            // f

            //-----------------------------------------------------------//

            // Q 14
            // d


            //-----------------------------------------------------------//

            // Q 15
            // d
            
            */
            #endregion


            #region Assignment C# 04
            #region Q1 Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.Write("Please enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 3 == 0 && number % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");

            #endregion

            #region Q2  Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.Write("Please enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num < 0)
            //    Console.WriteLine("Negative");
            //else
            //    Console.WriteLine("Positive");
            #endregion

            #region Q3  Write a program that takes 3 integers from the user then prints the max element and the min element.
            //int FirstNumber, SecondNumber, ThirdNumber, max, min;
            //Console.Write("Please enter the first number: ");
            //FirstNumber = int.Parse(Console.ReadLine());
            //Console.Write("Please enter the second number: ");
            //SecondNumber = int.Parse(Console.ReadLine());
            //Console.Write("Please enter the third number: ");
            //ThirdNumber = int.Parse(Console.ReadLine());

            //if (FirstNumber > SecondNumber && SecondNumber > ThirdNumber)
            //{
            //    max = FirstNumber;
            //    min = ThirdNumber;
            //    Console.WriteLine($"Max = {FirstNumber} , Min = {ThirdNumber}");
            //}
            //else if(FirstNumber > ThirdNumber && ThirdNumber > SecondNumber)
            //{
            //    max = FirstNumber;
            //    min = SecondNumber;
            //    Console.WriteLine($"Max = {FirstNumber} , Min = {SecondNumber}");
            //}
            //else if (SecondNumber > FirstNumber && FirstNumber > ThirdNumber)
            //{
            //    max = SecondNumber;
            //    min = ThirdNumber;
            //    Console.WriteLine($"Max = {SecondNumber} , Min = {ThirdNumber}");
            //}
            //else if (SecondNumber > ThirdNumber && ThirdNumber > FirstNumber)
            //{
            //    max = SecondNumber;
            //    min = FirstNumber;
            //    Console.WriteLine($"Max = {SecondNumber} , Min = {FirstNumber}");
            //}
            //else if (ThirdNumber > SecondNumber && SecondNumber > FirstNumber)
            //{
            //    max = ThirdNumber;
            //    min = FirstNumber;
            //    Console.WriteLine($"Max = {ThirdNumber} , Min = {FirstNumber}");
            //}
            //else if (ThirdNumber > FirstNumber && FirstNumber > SecondNumber)
            //{
            //    max = ThirdNumber;
            //    min = SecondNumber;
            //    Console.WriteLine($"Max = {ThirdNumber} , Min = {SecondNumber}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Format");
            //}



            #endregion

            #region Q4 Write a program that allows the user to insert an integer number then check If a number is even or odd
            //Console.Write("Please enter any number to Check (Even / Odd)! : ");
            //int CheckEvenOrOdd = int.Parse(Console.ReadLine());
            //if (CheckEvenOrOdd % 2 == 0)
            //{
            //    Console.WriteLine($"{CheckEvenOrOdd} is Even");
            //}
            //else 
            //{
            //    Console.WriteLine($"{CheckEvenOrOdd} is Odd");
            //}
            #endregion

            #region Q5  Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.Write("Enter any Character: ");
            //char character = char.Parse(Console.ReadLine());
            //char ToLower = char.ToLower(character);
            //switch (ToLower)
            //{
            //    case 'a':
            //    case 'i':
            //    case 'e':
            //    case 'o':
            //    case 'u':
            //        Console.WriteLine($"{ToLower} is Vowel");
            //        break;

            //    default:
            //        Console.WriteLine($"{ToLower} is consonant");
            //        break;
            //}

            #endregion

            #region Q6 Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.Write("Enter a number: ");
            //int print = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= print; i++)
            //{
            //    Console.Write(i + " , ");
            //}
            #endregion

            #region Q7 Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.Write("Enter a number: ");
            //int print = int.Parse(Console.ReadLine());
            //for (int i =1; i <= 12; i++)
            //{
            //    Console.WriteLine(print * i);
            //}
            #endregion

            #region Q8 Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.Write("Enter a number: ");
            //int print = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= print; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}
            #endregion

            #region Q9 Write a program that takes two integers then prints the power.
            //Console.Write("Enter the number: ");
            //int Number1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the Power: ");
            //int Number2 = int.Parse(Console.ReadLine());
            //int result = 1;
            //for (int i = 0; i < Number2; i++)
            //{
            //    result *= Number1;
            //}

            //Console.WriteLine($"The Power = {result}");

            #endregion

            #region Q10 Write a program to enter marks of five subjects and calculate total, average and percentage
            //Console.Write("Enter the mark of First Subject:");
            //double subject1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the mark of First Subject:");
            //double subject2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the mark of First Subject:");
            //double subject3 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the mark of First Subject:");
            //double subject4 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the mark of First Subject:");
            //double subject5 = int.Parse(Console.ReadLine());

            //double TotalMarks = subject1 + subject2 + subject3 + subject4 + subject5;
            //double AverageMarks = TotalMarks / 5;
            //double Percentage = (TotalMarks / 500) * 100;
            //Console.WriteLine($"Total Marks = {TotalMarks} , Average = {AverageMarks} , Percintage = {Percentage}%");
            #endregion

            #region Q11 Write a program to input the month number and print the number of days in that month.
            //Console.Write("Enter the month number: ");
            //int MonthNumber = int.Parse(Console.ReadLine());
            //switch(MonthNumber)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine($"Month: {MonthNumber} , Days in month: 31 ");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine($"Month: {MonthNumber} , Days in month: 30 ");
            //        break;
            //    default:
            //        Console.WriteLine($"Month: {MonthNumber} , Days in month: 29 ");
            //        break ;

            //}
            #endregion

            #region Q12 Write a program to create a Simple Calculator.
            //Console.Write("Enter First Number: ");
            //int FstNumber = int.Parse(Console.ReadLine());
            //Console.Write("Enter The Operator: ");
            //char  Operator = Char.Parse(Console.ReadLine());
            //Console.Write("Enter Second Number: ");
            //int ScdNumber = int.Parse(Console.ReadLine());
            //int result = 0;
            //switch (Operator)
            //{
            //    case '+':
            //        result = FstNumber + ScdNumber;
            //        Console.WriteLine($"Result = {result}");
            //        break;

            //    case '-':
            //        result = FstNumber - ScdNumber;
            //        Console.WriteLine($"Result = {result}");
            //        break;

            //    case '*':
            //        result = FstNumber * ScdNumber;
            //        Console.WriteLine($"Result = {result}");
            //        break;

            //    case '/':
            //        if (ScdNumber != 0)
            //        {
            //            result = FstNumber / ScdNumber;
            //            Console.WriteLine($"Result = {result}");
            //        }  
            //        else
            //            Console.WriteLine("Cannot divide on zero");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid Operator");
            //        break;

            //}


            #endregion

            #region Q13 Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write("Please enter the string to be reversed: ");
            //string text = Console.ReadLine();
            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(text[i]);
            //}
            //Console.WriteLine();
            #endregion


            #region Q14 Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.Write("Please enter integer to be reversed: ");
            //int ReversedInt = int.Parse(Console.ReadLine());
            //for (int i = ReversedInt-1; i >= 0; i--)
            //{
            //    Console.Write(ReversedInt);
            //}
            //Console.WriteLine();
            #endregion

            #region Q15 Write a program in C# Sharp to find prime numbers within a range of numbers
            //Console.Write("Enter the starting number of the range: "); 
            //int start = Convert.ToInt32(Console.ReadLine()); 
            //Console.Write("Enter the ending number of the range: "); 
            //int end = Convert.ToInt32(Console.ReadLine()); 
            //Console.WriteLine($"Prime numbers between {start} and {end} are:"); 
            //for (int i = start;i <= end; i++) 
            //{ 
            //    bool isPrime = true; 
            //    if (i <= 1) 
            //    { 
            //        isPrime = false; 
            //    } 
            //    else 
            //    { 
            //        for (int j = 2; j <= Math.Sqrt(i); j++) 
            //        { 
            //            if (i % j == 0) 
            //            { 
            //                isPrime = false; 
            //                break; 
            //            } 
            //        } 
            //    } 
            //    if (isPrime) 
            //    {
            //        Console.WriteLine(i); 
            //    } 
            //}


            #endregion

            #region Q16 Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.Write("Enter the Decimal Number : ");
            //int DecimalNumber = int.Parse(Console.ReadLine());

            //string Result = string.Empty;
            //for (int i = 0; DecimalNumber > 0; i++)
            //{
            //    Result = DecimalNumber % 2 + Result;
            //    DecimalNumber = DecimalNumber / 2;
            //}
            //Console.WriteLine($"Binary Represenation of the given Number : {Result}");

            #endregion

            #region Q17 Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.Write("Enter First Place in Point 1 : ");
            //int x1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Second Place in Point 1 : ");
            //int x2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter First Place in Point 2 : ");
            //int y1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Second Place in Point 2 : ");
            //int y2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter First Place in Point 3 : ");
            //int x3 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Second Place in Point 3 : ");
            //int y3 = int.Parse(Console.ReadLine());
            //if((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("The Points lie on a single straight line.!");
            //}
            //else
            //{
            //    Console.WriteLine("The Points don't lie on a single straight line.!");
            //}


            #endregion

            #region Q18
            //Console.Write("Enter the time taken to complete the task (in hours): ");
            //int TimeTaken = int.Parse(Console.ReadLine());

            //if (TimeTaken >= 2 &&  TimeTaken <= 3)
            //{
            //    Console.WriteLine("The worker highly efficient.");
            //}
            //else if (TimeTaken >= 4 &&  TimeTaken <= 5)
            //{
            //    Console.WriteLine("The worker should training to enhance their speed.");
            //}
            //else if (TimeTaken > 5)
            //{
            //    Console.WriteLine("The worker must leave the company.");
            //}
            //else
            //{
            //    Console.WriteLine("Nothing To Say!!");
            //}

            #endregion

            #region Q19 

            #endregion

            #region Q20  Write a program in C# Sharp to find the sum of all elements of the array.

            //Console.Write("Enter the size of the array:" );
            //int size = int.Parse( Console.ReadLine() );

            //int[] arr = new int[size];
            //Console.WriteLine("Enter the elements of the array: ");
            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = int.Parse( Console.ReadLine() );
            //}
            //int sum = 0;
            //for (int i = 0;i < size; i++)
            //{
            //    sum += arr[i];
            //}
            //Console.WriteLine($"Sum of all elements is = {sum}");

            //#endregion








            #endregion


            #region Q21  Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //Console.WriteLine("Enter size of array 1 : ");
            //int size1 = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[size1];
            //Console.WriteLine("Enter elements of the array 1 :");
            //for (int i = 0; i < size1; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter size of array 2 : ");
            //int size2 = int.Parse(Console.ReadLine());
            //int[] arr2 = new int[size1];
            //Console.WriteLine("Enter elements of the array 1 :");
            //for (int i = 0; i < size2; i++)
            //{
            //    arr2[i] = int.Parse(Console.ReadLine());
            //}

            //int[] mergedArray = new int[arr1.Length + arr2.Length];
            //Array.Copy(arr1, mergedArray, arr1.Length);
            //Array.Copy(arr2, 0, mergedArray, arr1.Length, arr2.Length);
            //Array.Sort(mergedArray);
            //Console.WriteLine("Merged sorted array:");
            //for (int i = 0; i < mergedArray.Length; i++)
            //{
            //    Console.Write(mergedArray[i] + " ");
            //}
            #endregion

            #region Q22

            #endregion

            #region Q23 Write a program in C# Sharp to find maximum and minimum element in an array

            //Console.Write("Enter the Size of the array: ");
            //int ArrSize = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[ArrSize];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < ArrSize; i++)
            //{
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int max = array[0];
            //int min = array[0];

            //for (int i = 1; i < ArrSize; i++)
            //{
            //    if (array[i] > max) 
            //    { 
            //        max = array[i]; 
            //    } 
            //    else if (array[i] < min) 
            //    { 
            //        min = array[i];
            //    }

            //}
            //Console.WriteLine($"Maximum element in the array is: {max}");
            //Console.WriteLine($"Minimum element in the array is: {min}"); 

            #endregion

            #region Q24  Write a program in C# Sharp to find the second largest element in an array.
            //Console.WriteLine("Enter size of the array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] PrintArr = new int[size];
            //Console.WriteLine("Enter elements of an array: ");
            //for (int i = 0; i < size; i++)
            //{
            //    PrintArr[i] = int.Parse(Console.ReadLine());
            //}
            //int temp;
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if (PrintArr[i] > PrintArr[j])
            //        {
            //            temp = PrintArr[i];
            //            PrintArr[i] = PrintArr[j];
            //            PrintArr[j] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine($"Second Largest element in the array is {PrintArr[size - 2]} ");

            #endregion


            #region Q25
            //Console.Write("Enter the size of the array: ");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[size];
            //// Input elements of the array
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int longestDistance = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            int distance = j - i;
            //            if (distance > longestDistance)
            //            {
            //                longestDistance = distance;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine($"The longest distance between two equal cells is: {longestDistance}");
            #endregion

            #region Q26 
            //Console.Write("Enter a list of space-separated words: "); 
            //string input = Console.ReadLine(); 
            //string[] words = input.Split(' '); 
            //Array.Reverse(words); 
            //string reversedWords = string.Join(" ", words); 
            //Console.WriteLine(reversedWords);
            #endregion

            #region Q27  Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //Console.WriteLine("Enter first array size: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second array size: ");
            //int y = int.Parse(Console.ReadLine());
            //int[,] FirstArray = new int[x, y];
            //Console.WriteLine("Enter the elements of the first array: ");
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write($"Element [{i},{j}]: ");
            //        FirstArray[i, j] = int.Parse(Console.ReadLine());

            //    }
            //}

            //int[,] SecondArray = new int[x, y];

            //Array.Copy(FirstArray, SecondArray, FirstArray.Length);

            //Console.WriteLine("Elements of the second array:");
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write(SecondArray[i, j] + " ");
            //    }

            //}
            #endregion

            #region Q28 Write a Program to Print One Dimensional Array in Reverse Order
            //Console.WriteLine("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] PrintArr = new int[size];
            //Console.WriteLine("Enter the elements of the array: ");
            //for (int i = 0; i < size; i++)
            //{
            //    PrintArr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Reversed Array : ");
            //for (int i = size - 1; i >= 0; i--)
            //{
            //    Console.Write(PrintArr[i] + " ");
            //}
            #endregion


        }


        #endregion







    }
}
