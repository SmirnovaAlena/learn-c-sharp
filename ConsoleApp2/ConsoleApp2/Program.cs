using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public class Human
        {
            string _firstName;
            public string _lastName;
            DateTime _birthDate;
            public string C;
            public Human() { }
        
            public void Setfirstname(string value) { _firstName = value; }
            public void Setlastname(string value) { _lastName = value; }
            public void Setbirth(DateTime value) { _birthDate = value; }
            public void SetC(string value) { C = value; }

            public virtual void Show()
            {
                Console.WriteLine($"\nlastname : {_lastName}\n firstname{_firstName} \n {_birthDate}");
            }


        }
       
        public class Employee: Human
        {
            double _salary;
             public Employee() { }
          
            public void SetSalary(double value) {  _salary = value; }
            public void Show()
            {
                base.Show();
                Console.WriteLine($" salary : {_salary}");
            }
        }
        public class EmployeeBuilder 
        {
            Employee e=new Employee();
            
        
            public EmployeeBuilder Setfirstname(string value)
            {
                e.Setfirstname(value);
                return this;
            }
            public EmployeeBuilder Setlastname(string value)
            {
                e.Setlastname(value);
                return this;
            }
            public EmployeeBuilder Setbirth(DateTime value)
            {
                e.Setbirth(value);
                return this;
            }
            public EmployeeBuilder SetSalary(double value)
            {
                e.SetSalary(value);
                return this;
            }
            public Employee build()
            {
                return e;
            }

        }
        public class Manager: Employee
        {
            public void ShowM()
            {
                Console.WriteLine("M");
            }
        }
        public class Specialist: Employee
        {
            public void ShowSp()
            {
                Console.WriteLine("Sp");
            }
        }
        public class Scientist : Employee
        {
            public void ShowS()
            {
                Console.WriteLine("S");
            }
        }

        static void Main(string[] args)
        {
            Employee[] e = {new Manager(),new Specialist(),new Scientist()};
            foreach(Employee item in e)
            {
                if (item is Manager)
                {
                    (item as Manager).ShowM();
                      

                }
                if (item is Specialist)
                {
                    (item as Specialist).ShowSp();


                }
                if (item is Scientist)
                {
                    (item as Scientist).ShowS();


                }
            }
        }
    }
}
