using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Nurse : Non_Doctor
    {
        private int numberOfPatients;

        public int NumberOfPatients
        {
            get { return this.numberOfPatients; }
        }

        public Nurse(string employeeName, int employeeNumber, string department, int numberOfPatients)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.numberOfPatients = numberOfPatients;
        }

        public override string EmployeeInformation()
        {
            return base.EmployeeInformation() + "\tNumber of Patients: " + numberOfPatients;
        }
    }
}
