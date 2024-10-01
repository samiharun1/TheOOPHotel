using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOOPHotel
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }
        public Person(string name, int age, string employeeId, DateTime startDate, decimal salary)
        {
            Name = name;
            Age = age;
            EmployeeId = employeeId;
            StartDate = startDate;
            Salary = salary;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Namn: {this.Name}");
            Console.WriteLine($"Ålder: {this.Age}");
        }
        public virtual void Introduce()
        {
            Console.WriteLine($"Hej jag heter {this.Name} och jag är {this.Age} år gammal.");  
        }
    }
    public class Manager : Person
    {
        public string Department;
        public Manager(string name, int age, string employeeId, DateTime startDate, decimal salary, string department) : base(name, age, employeeId, startDate, salary)
        {
            Department = department;
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hej jag heter {this.Name} och jag är chef.");
        }
        public void HoldMeeting()
        {
            Console.WriteLine($"Chefen {this.Name} håller just nu ett möte.");
        }
        public void PlanBudget()
        {
            Console.WriteLine($"Chefen {this.Name} planerar budgeten.");
        }
    }
    public class Employee : Person
    {
        public string JobTitle;
        public string Department;
        public Employee (string name, int age, string employeeId, DateTime startDate, decimal salary, string jobTitle, string department) : base(name, age, employeeId, startDate, salary)
        {
            JobTitle = jobTitle;
            Department = department;
        }
        public virtual void Work()
        {
            Console.WriteLine($"Arbetaren {Name} gör sitt jobb.");
        }
    }

    public class Consultant : Person
    {
        public decimal HourlyRate;
        public string ConsultingFirm;
        public string Expertise;
        public Consultant(string name, int age, string employeeId, DateTime startDate, decimal salary, decimal hourlyRate, string consultingFirm, string expertise) : base(name, age, employeeId, startDate, salary)
        {
            HourlyRate = hourlyRate;
            ConsultingFirm = consultingFirm;
            Expertise = expertise;
        }

        public void GiveAdvice()
        {
            Console.WriteLine("Här är råd.");
        }
        public string expertise
        {
            get { return Expertise; }
            set {
                if (Expertise == "HR" || Expertise == "Ekonomi" || Expertise == "Marknadsföring")
                {
                    Expertise = value;
                }
                else { Expertise = "Okänt"; }
                }
        }
    }
    public class HouseKeeper : Employee
    {
        public HouseKeeper(string name, int age) : base(name, age, "", new DateTime(), 0, "", "")
        {
        }
        public override void Work()
        {
            Console.WriteLine($"{Name} städar hotellrummen");
        }
    }

}
