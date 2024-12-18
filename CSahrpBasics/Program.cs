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
            // 1
            //Console.Write("Enter a number: ");
            //int Number = int.Parse(Console.ReadLine());
            //Console.WriteLine(Number);
            //-----------------------------------------------------------//
            // 2
            //Console.Write("Enter a string: ");
            //string str = Console.ReadLine();
            //int number = Convert.ToInt32(str);
            //Console.WriteLine(number);
            // System.FormatException: 'The input string 'ahmed' was not in a correct format.'
            //-----------------------------------------------------------//
            // 3
            //float floatNumber = 12.4F; 
            //double doubleNumber = 10.7;
            ////Perform arithmetic operations
            // double sum = floatNumber + doubleNumber;
            //double difference = floatNumber - doubleNumber;
            //double multiply = floatNumber * doubleNumber;
            //double divide = floatNumber / doubleNumber;
            ////Display the results
            // Console.WriteLine($"Addition: {floatNumber} + {doubleNumber} = {sum}");
            //Console.WriteLine($"Subtraction: {floatNumber} - {doubleNumber} = {difference}");
            //Console.WriteLine($"Multiplication: {floatNumber} * {doubleNumber} = {multiply}");
            //Console.WriteLine($"Division: {floatNumber} / {doubleNumber} = {divide}");
            //-----------------------------------------------------------//
            // 4
            //Console.Write("Enter the string: ");
            //string str = Console.ReadLine();
            //Console.Write("Enter the Start Position: ");
            //int StartPosition = int.Parse(Console.ReadLine());
            //Console.Write("Enter the SubString Length: ");
            //int Length = int.Parse(Console.ReadLine());

            //string SubString = str.Substring(StartPosition, Length);
            //Console.WriteLine($"SubString:{SubString}");
            //-----------------------------------------------------------//
            // 5
            //int a = 25;
            //int b = a;

            //Console.WriteLine("Before Modification: ");
            //Console.WriteLine($"a = {a}");
            //Console.WriteLine($"b = {b}");

            //b = 30;
            //Console.WriteLine("After Modification: ");
            //Console.WriteLine($"a = {a}");
            //Console.WriteLine($"b = {b}");
            //Before modification: Both a and b have the value 10.
            //After modification: b changes to 20, but a remains 10.
            //with value types, when you assign one variable to another, you are copying the value, not referencing it.
            //This means changes to one variable will not affect the other.
            //-----------------------------------------------------------//
            // 6
            //string str1 = "Hello";
            //string str2 = str1;

            //Console.WriteLine("Before Modification: ");
            //Console.WriteLine($"Str 1 = {str1}");
            //Console.WriteLine($"Str 2 =  {str2}");

            //str2 = "World!";
            //Console.WriteLine("After Modification: ");
            //Console.WriteLine($"Str 1 =  {str1}");
            //Console.WriteLine($"Str 2 =  {str2}");
            //         Before modification:
            //Both str1 and str2 refer to the same string object "Hello".
            //         After modification:
            //str2 is assigned a new string "World", but str1 still refere to the original string "Hello".
            // and str1 equal "Hello" and str2 becomes "World".

            //----------------------------------------------------------------------------------//


            // 7
            //Console.Write("Enter the first string: ");
            //string FirstString = Console.ReadLine();
            //Console.Write("Enter the second string: ");
            //string SecondString = Console.ReadLine();

            ////string CombineStrings = FirstString + SecondString;
            ////Console.WriteLine($"Combination: {CombineStrings}");
            ////Console.WriteLine($"Combination: {FirstString + SecondString}");
            ///


            //-----------------------------------------------------------//


            // 8
            //double Principal, rate, time, interest;
            //Console.Write("Enter the Principal Amount: ");
            //Principal =Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter the rate: ");
            //rate = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter the time: ");
            //time = Convert.ToDouble(Console.ReadLine());

            //interest = (Principal * rate * time) / 100;
            //Console.WriteLine($"Interest: {interest}");

            //-----------------------------------------------------------//


            // 9
            //double Weight, Height, BMI;
            //Console.Write("Enter the Body Weight: ");
            //Weight= double.Parse(Console.ReadLine());
            //Console.Write("Enter the Body Height: ");
            //Height = double.Parse(Console.ReadLine());

            //BMI = (Weight) / (Height * Height);

            //Console.WriteLine($"The Body Mass is = {BMI}");

            //-----------------------------------------------------------//

            //10
            //string good = "Just Good";
            //string cold = "Just Cold";
            //string hot = "Just Hot";
            //Console.Write("Enter the temperature: ");
            //int Temperature = int.Parse(Console.ReadLine());

            //string TemperatureStatus = Temperature < 10 ? cold : Temperature > 30 ? hot : good;

            //Console.WriteLine($"Temperature is {TemperatureStatus}");

            //-----------------------------------------------------------//

            // 11
            ////Console.Write("Enter the day: ");
            //int day = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the month: ");
            //int month = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the year: ");
            //int year = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Today's date: {day} , {month} , {year}");
            //Console.WriteLine($"Today's date: {day} / {month} / {year}");
            //Console.WriteLine($"Today's date: {day} – {month} – {year}");

            //-----------------------------------------------------------//

            // 12
            // c

            //-----------------------------------------------------------//

            // 13
            // f

            //-----------------------------------------------------------//

            // 14
            // d


            //-----------------------------------------------------------//

            // 15
            // d








        }
    }
}
