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
            Department department = new Department { DeptID = 1, DeptName = "Sales" };
            Club club = new Club { ClubID = 1, ClubName = "City Club" };
            SalesPerson salesPerson = new SalesPerson
            {
                EmployeeID = 101,
                BirthDate = new DateTime(1985, 5, 15),
                AchievedTarget = 80
            };
            BoardMember boardMember = new BoardMember
            {
                EmployeeID = 201,
                BirthDate = new DateTime(1950, 7, 20)
            };

            department.AddStaff(salesPerson);
            department.AddStaff(boardMember);
            club.AddMember(salesPerson);
            club.AddMember(boardMember);

            salesPerson.EndOfYearOperation(100);
            boardMember.Resign();
            Console.WriteLine("Department Staff:");
            foreach (var staff in department.Staff)
            {
                Console.WriteLine($"Employee ID: {staff.EmployeeID}");
            }

           
            Console.WriteLine("\nClub Members:");
            foreach (var member in club.Members)
            {
                Console.WriteLine($"Employee ID: {member.EmployeeID}");
            }


        }
    }
}
