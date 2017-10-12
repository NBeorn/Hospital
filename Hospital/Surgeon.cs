using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Surgeon : Doctor
    {
        private bool operationStatus;

        public bool OperationStatus
        {
            get { return this.operationStatus; }
        }

        public Surgeon(string employeeName, int employeeNumber, string specialtyArea, bool operationStatus)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
            this.operationStatus = operationStatus;
        }
    }
}
