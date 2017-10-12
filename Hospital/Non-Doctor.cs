using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    abstract class Non_Doctor : Employee
    {
        protected string department;

        public string Department
        {
            get { return this.department; }
        }

        public Non_Doctor()
        {

        }

        public override string EmployeeInformation()
        {
            return base.EmployeeInformation() + "\tDepartment: " + department;
        }
    }
}
