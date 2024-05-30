using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        abstract class Human
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public override string ToString()
            {
                return $"lN {LastName} \nFN {FirstName} \nBirthDate {BirthDate.ToLongDateString()}";
            }
        }
        abstract class Employee : Human
        {
            public string Position { get; set; }
            public double Salary { get; set; }
            public override string ToString()
            {
                return base.ToString() + $"\nP {Position} \nSalary {Salary}";
            }
        }
            public interface IWorker
        {
           /* event EventHandler WorkEnded;*/
            bool IsWorking { get; }
            string Work();
        }
        interface IManager
        {
            List<IWorker> list { get; set; }
            void Organize();
            void MakeBudget();
            void Control();
        }
        class Director : Employee, IManager 
        {
            public List <IWorker> list { get; set;}
            public void Control()
            {
                Console.WriteLine("Control");
            }
                public void MakeBudget()
                {
                Console.WriteLine("Make Budget");
                }
            public void Organize()
            {
                Console.WriteLine("Organize");
            } 
            

        }
        class Seller : Employee, IWorker
        {
            bool isWorking = true;

            public bool IsWorking
            {
                get { return isWorking; }
            }
            public string Work()
            {
                return "Work() Seller";

            }
        }
        class Cashier : Employee, IWorker
        {
            bool isWorking = true;
            public bool IsWorking
            {
                get { return isWorking; }
            }
            public string Work()
            {
                return "Work() Cashier";
            }
        }
        class Storekeeper : Employee, IWorker
        {
            bool isWorking = true;
            public bool IsWorking
            {
                get { return isWorking; }
            }
            public string Work()
            {
                return "Work() Storekeeper";

            }
        }
        static void Main(string[] args)
        {
            Director director = new Director {/* LastName="LN1",*/FirstName="FN1",BirthDate=new DateTime(1998,10,12),Position="Director",Salary=12000};
            Seller seller = new Seller { LastName = "LN2", FirstName = "FN2", BirthDate = new DateTime(1956, 5, 23), Position = "Seller", Salary = 3000 };
            if (seller is Employee)
            {
                Console.WriteLine($"Salary {(seller as Employee).Salary}");
            }
            director.list = new List<IWorker> { seller, new Cashier { LastName = "LN3", FirstName = "FN3", BirthDate = new DateTime(1988, 09, 3), Position = "Cashier", Salary = 1200 },
                new Storekeeper { LastName = "LN4", FirstName = "FN4", BirthDate = new DateTime(1963, 7, 8), Position = "Storekeeper", Salary = 2000 } };
            Console.WriteLine(director);
            if (director is IManager)
            {
                director.Control();
            }
            foreach( IWorker i in director.list)
            {
                Console.WriteLine(i);
                if (i.IsWorking){
                    Console.WriteLine(i.Work());

                }

            }
        }
    }
}
