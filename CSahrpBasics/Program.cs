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

            #region Q1 Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] persons = new Person[3];
            //Console.WriteLine("Persons on the array: ");
            //persons[0] = new Person { Name = "Khaled Eid", Age = 24 };
            //persons[1] = new Person { Name = "Saif Eid", Age = 21 };
            //persons[2] = new Person { Name = "Hossam Eid", Age = 15 };
            //foreach (Person person in persons)
            //{
            //    Console.WriteLine($"Name: {person.Name} , Age: {person.Age}");
            //}
            #endregion


            #region Q2 Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Console.WriteLine("Enter the coordinates of the first point:");
            //Point point1 = new Point();
            //Console.Write("X: ");
            //point1.X = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Y: ");
            //point1.Y = Convert.ToDouble(Console.ReadLine());
            //// Input the second point from the user
            //Console.WriteLine("Enter the coordinates of the second point:");
            //Point point2 = new Point();
            //Console.Write("X: ");
            //point2.X = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Y: ");
            //point2.Y = Convert.ToDouble(Console.ReadLine());
            //// Calculate the distance between the two points
            //double distance = CalculateDistance(point1, point2);
            //// Display the distance
            //Console.WriteLine($"The distance between the two points is: {distance:F2}");

            //static double CalculateDistance(Point p1, Point p2)
            //{
            //    double DeltaX = p1.X - p2.X;
            //    double DeltaY = p1.Y - p2.Y;
            //    return Math.Sqrt(DeltaX * DeltaX + DeltaY * DeltaY);
            //}
            #endregion


            #region Q3 Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            Person[] persons = new Person[3];
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Enter details for person {i + 1}:");
                Console.Write("Name: ");
                persons[i].Name = Console.ReadLine();
                Console.Write("Age: ");
                persons[i].Age = Convert.ToInt32(Console.ReadLine());
            }
            Person oldestPerson = persons[0];
            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i].Age > oldestPerson.Age)
                {
                    oldestPerson = persons[i];
                }
            }
            Console.WriteLine($"The oldest person is {oldestPerson.Name} with an age of {oldestPerson.Age}."); 
            #endregion




        }
    }
}
