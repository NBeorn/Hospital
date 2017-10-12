using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Doctor : Employee
    {
        protected string specialtyArea;

        public string SpecialtyArea
        {
            get { return this.specialtyArea; }
        }

        public Doctor()
        {

        }

        public Doctor(string employeeName, int employeeNumber, string specialtyArea)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
        }

        public override string EmployeeInformation()
        {
            return base.EmployeeInformation() + "\tSpecialty Area: " + specialtyArea;
        }
    }
}
