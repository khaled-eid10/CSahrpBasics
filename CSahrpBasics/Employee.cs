using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpBasics
{
    public enum LayOffCause
    {
        VacationStockLow,
        AgeOverSixty,
        TargetNotAchieved,
        Resigned
    }
    #region Employee 


    public class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause Cause { get; set; }
    }

    public class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs>? EmployeeLayOff;

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }

        public int EmployeeID { get; set; }

        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        private int _vacationStock;
        public int VacationStock
        {
            get { return _vacationStock; }
            set { _vacationStock = value; }
        }

        public bool RequestVacation(DateTime from, DateTime to)
        {
            // Add vacation request logic here
            throw new NotImplementedException();
        }

        public void EndOfYearOperation()
        {
            // Check for employees to lay off based on the criteria
            if (VacationStock < 8)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.VacationStockLow });
            }

            if (DateTime.Now.Year - BirthDate.Year > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.AgeOverSixty });
            }
        }
    }
    #endregion

    #region Department
    public class Department
    {
        public int DeptID { get; set; }
        public string? DeptName { get; set; }
        public List<Employee> Staff { get; set; } = new List<Employee>();

        public void AddStaff(Employee e)
        {
            Staff.Add(e);
            
            e.EmployeeLayOff += RemoveStaff;
        }

        
        public void RemoveStaff(object? sender, EmployeeLayOffEventArgs e)
        {
            Employee? employee = sender as Employee;
            if (employee != null)
            {
                Staff.Remove(employee);
                Console.WriteLine($"Employee {employee.EmployeeID} removed due to {e.Cause}");
            }
        }
    }

    #endregion
    #region Club
    public class Club
    {
        public int ClubID { get; set; }
        public string? ClubName { get; set; }
        public List<Employee> Members { get; set; } = new List<Employee>();

        public void AddMember(Employee e)
        {
            Members.Add(e);

            e.EmployeeLayOff += RemoveMember;
        }


        public void RemoveMember(object? sender, EmployeeLayOffEventArgs e)
        {
            Employee? employee = sender as Employee;
            if (employee != null && e.Cause == LayOffCause.VacationStockLow)
            {
                Members.Remove(employee);
                Console.WriteLine($"Employee {employee.EmployeeID} removed from club due to {e.Cause}");
            }
        }
    }
    #endregion

    #region Sales Employee & Board Member
    public class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }

        public bool CheckTarget(int Quota)
        {
            return AchievedTarget >= Quota;
        }

        public void EndOfYearOperation(int salesQuota)
        {
            if (!CheckTarget(salesQuota))
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.TargetNotAchieved });
            }
        }

    }
    public class BoardMember : Employee
    {
        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.Resigned });
        }


    } 
    #endregion

}
