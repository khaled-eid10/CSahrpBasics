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








        }
    }
}
