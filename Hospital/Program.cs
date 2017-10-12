using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employees
            Doctor david = new Doctor("David Jones", 123, "heart");
            Doctor james = new Doctor("James Smith", 342, "lungs");
            Surgeon catherine = new Surgeon("Catherine Vincent", 725, "brain", true);
            Surgeon jaime = new Surgeon("Jaime Rodriguez", 843, "spine", false);
            Receptionist zachary = new Receptionist("Zachary Black", 186, "Office", true);
            Receptionist emma = new Receptionist("Emma Thompson", 865, "Customer Service", false);
            Nurse clara = new Nurse("Clara Kane", 527, "In-Patient", 4);
            Nurse kyle = new Nurse("Kyle James", 142, "Out-Patient", 2);

            Console.WriteLine("High St. Hospital Employees: \n");
        }
    }
}
