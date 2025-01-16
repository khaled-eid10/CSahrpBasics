using CSahrpBasics.Enums;
using CSahrpBasics.Inhiretance;
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

            //Parent parent = new Parent(15, 10);
            //int result = parent.ProductOfNumbers();
            //Console.WriteLine(result);

            //Child child = new Child(15, 10 , 10);
            //int result = child.ProductOfNumbers();
            //Console.WriteLine(result);

            Employee employee = new Employee
            {
                Id = 1,
                Name = "Kha Eid",
                SecurityLevel = SecurityPrivileges.Developer,
                Salary = 22500,
                HireDate = "January 31, 2023",
                Gender = Gender.M
            };
            Console.WriteLine(employee);
            Console.WriteLine("-------------------------------------------------");
            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee { Name = "Khaled Eid", Role = Role.DBA , HireDate = "January 31, 2023" };
            EmpArr[1] = new Employee {Name = "Saif Eid", Role=Role.Guest , HireDate = "January 1, 2023" };
            EmpArr[2] = new Employee {Name = "Hossam Eid" , Role = Role.securityOfficer , Permission = true, HireDate = "January 11, 2023" };

            Array.Sort(EmpArr, (x,y) => x.HireDate.CompareTo(y.HireDate));

            foreach (Employee emp in EmpArr)
            {
                emp.EmpData();

            }

        }
    }
}
