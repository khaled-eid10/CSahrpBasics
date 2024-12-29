using CSahrpBasics.Enums;
using System.Diagnostics.Metrics;
using System.Net.Security;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace CSahrpBasics
{
    internal class Program
    {

        #region Q2 Function
        static void DisplayMonthsInSeason(Season season)
        {
            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("march to may");
                    break;
                case Season.Summer:
                    Console.WriteLine("june to august");
                    break;
                case Season.Autumn:
                    Console.WriteLine("September to November");
                    break;
                case Season.Winter:
                    Console.WriteLine("December to February");
                    break;

                default:
                    Console.WriteLine("Invalid Season!!");
                    break;

            }
        } 
        #endregion
        static void Main(string[] args)
        {





            #region Part01
            //Person person = new Person();
            //person.Id = 1;
            //person.Name = "Khaled";
            //person.Gender = Gender.Male;
            //Console.WriteLine($"Id: {person.Id} , Name: {person.Name} ,Gender: {person.Gender}");

            #endregion

            #region Part02
            #region Q1 Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //string[] PrintWeekDays = Enum.GetNames(typeof(WeekDays));
            //foreach (string WeekDay in PrintWeekDays)
            //    Console.WriteLine(WeekDay);

            #endregion

            #region Q2 Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as  its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.Write("Enter The Season To Get Months in it: ");
            //string input = Console.ReadLine();

            //Season season = new Season();
            //if(Enum.TryParse(input, true, out season))
            //{
            //    DisplayMonthsInSeason(season);
            //}
            //else
            //{
            //    Console.WriteLine("Inavlid Season!!");
            //}




            #endregion


            #region Q3  Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum. Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

            //Permission UserPermission = Permission.Write| Permission.Read| Permission.Execute;
            //Console.WriteLine(UserPermission);
            //if ((UserPermission & Permission.Read) == Permission.Read)
            //{
            //    Console.WriteLine("Read Permission Is Existing");
            //}
            //else
            //{
            //    Console.WriteLine("Read Permission Is Not Existing");
            //}
            #endregion


            #region Q4 Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Enter a color to check: ");
            //string CheckColor = Console.ReadLine();

            //Colors colors = new Colors();
            //if (Enum.TryParse(CheckColor, true, out colors))
            //{
            //    Console.WriteLine($"{CheckColor} is primary color");
            //}
            //else
            //{
            //    Console.WriteLine($"{CheckColor} is not primary color");
            //} 
            #endregion

            #endregion








        }
    }
}
