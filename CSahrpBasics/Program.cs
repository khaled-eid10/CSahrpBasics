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

            #region Second Project

            double Sum = Maths.Add(10, 20);
            double Difference = Maths.Subtract(10, 20);
            double Multiplication = Maths.Multiply(10, 20);
            double Division = Maths.Divide(10, 20);

            Console.WriteLine($"Addition: {Sum}\nSubtraction: {Difference}\nMultiplication: {Multiplication}\nDivision: {Division}");

            #endregion


            #region Third Project
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString()); // Output: Hours: 1, Minutes: 10, Seconds: 15

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString()); // Output: Hours: 1, Minutes: 0, Seconds: 0

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString()); // Output: Hours: 2, Minutes: 10, Seconds: 0

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());

            Duration D5 = new Duration(1, 10, 15);
            Console.WriteLine(D1.Equals(D5)); // Output: True

            // Test GetHashCode method
            Console.WriteLine(D3.GetHashCode()); 
            #endregion






        }
    }
}
