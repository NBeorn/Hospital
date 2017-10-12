using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Receptionist : Non_Doctor
    {
        private bool onThePhone;

        public bool OnThePhone
        {
            get { return this.onThePhone; }
        }

        public Receptionist(string employeeName, int employeeNumber, string department, bool onThePhone)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.onThePhone = onThePhone;
        }

        public override string EmployeeInformation()
        {
            return base.EmployeeInformation() + "\tOn The Phone: " + onThePhone;
        }
    }
}
