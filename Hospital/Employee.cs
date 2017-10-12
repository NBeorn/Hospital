using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    abstract class Employee
    {
        protected string employeeName;
        protected int employeeNumber;

        public string EmployeeName
        {
            get { return this.employeeName; }
        }

        public int EmployeeNumber
        {
            get { return this.employeeNumber; }
        }

        public Employee()
        {

        }

        public virtual string EmployeeInformation()
        {
            return "Name: " + employeeName + "\tNumber: " + employeeNumber + "\n";
        }
    }
}
