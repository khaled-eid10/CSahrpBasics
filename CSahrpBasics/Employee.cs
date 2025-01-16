using CSahrpBasics.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpBasics
{
    public class Employee
    {
        #region Design and implement a Class for the employees in a company
        public int Id { get; set; }
        public string? Name { get; set; }

        public SecurityPrivileges SecurityLevel { get; set; }
        public int Salary { get; set; }
        public string? HireDate { get; set; } 

        public Gender Gender { get; set; }
        public SecurityPrivileges SecurityPrivileges { get; set; }
        public Role Role { get; set; }
        public bool Permission {  get; set; } = false;

        public override string? ToString()
        {
            return $"Id: {Id}\nName: {Name}\nSecurity Level: {SecurityLevel}\nSalary: {string.Format("{0:C}", Salary)}\nHiring Date: {HireDate}\nGender: {Gender}";
        }

        #endregion
        public void EmpData()
        {
          Employee emp = new Employee();
            emp.Name = Name;
            emp.Role = Role;
            emp.Permission = Permission;
            HireDate = HireDate;
            Console.WriteLine($"Name: {emp.Name} , Role: {Role}, Permission: {Permission} , Hire Date: {HireDate}");
        }
    }
}
