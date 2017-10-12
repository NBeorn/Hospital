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
            Doctor david = new Doctor("David Jones", 123, "Heart");
            Doctor james = new Doctor("James Smith", 342, "Lungs");
            Surgeon catherine = new Surgeon("Catherine Vincent", 725, "Brain", true);
            Surgeon jaime = new Surgeon("Jaime Rodriguez", 843, "Spine", false);
            Receptionist zachary = new Receptionist("Zachary Black", 186, "Office", true);
            Receptionist emma = new Receptionist("Emma Thompson", 865, "Customer Service", false);
            Nurse clara = new Nurse("Clara Kane", 527, "In-Patient", 4);
            Nurse kyle = new Nurse("Kyle James", 142, "Out-Patient", 2);

            Console.WriteLine("High St. Hospital Employees: \n");
            Console.WriteLine(david.EmployeeInformation());
            Console.WriteLine(james.EmployeeInformation());
            Console.WriteLine(catherine.EmployeeInformation());
            Console.WriteLine(jaime.EmployeeInformation());
            Console.WriteLine(zachary.EmployeeInformation());
            Console.WriteLine(emma.EmployeeInformation());
            Console.WriteLine(clara.EmployeeInformation());
            Console.WriteLine(kyle.EmployeeInformation());
        }
    }
}
