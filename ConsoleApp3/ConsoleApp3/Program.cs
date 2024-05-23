using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public abstract class Human
        {
            string _firstName;
            public string _lastName;
            DateTime _birthDate;
            public string C;
            public Human(string f, string l, DateTime t) {
                _firstName = f;
                _lastName = l;
                _birthDate = t;
            }

            public void Setfirstname(string value) { _firstName = value; }
            public void Setlastname(string value) { _lastName = value; }
            public void Setbirth(DateTime value) { _birthDate = value; }
            public void SetC(string value) { C = value; }

            public virtual void Show()
            {
                Console.WriteLine($"\nlastname : {_lastName}\n firstname{_firstName} \n {_birthDate}");
            }
            public abstract void Think();
            public abstract void Study();


        }
        public abstract class Learner : Human
        {
            string _institution;

            public Learner(string f, string l, DateTime t, string i) : base(f, l, t) { _institution = i; }
            public override void Study() { }
            

            public override void Show()
            {
                base.Show();
                Console.WriteLine($"i: {_institution}");
            }

        }
        class Student : Learner
        {
            string group;
            public Student(string f, string l, DateTime t, string i, string g) : base(f, l, t, i) { group = g; }
            public override void Think()
            {
                Console.WriteLine("Student Think()");
            }
            public override void Study()
            {
                Console.WriteLine("study() student");

            }
            public override void Show()
            {
                base.Show();
                Console.WriteLine($" g: {group}");

            }
        }
             class Pupil : Learner
            {
                string s;
                public Pupil(string f, string l, DateTime t, string i , string c) : base(f, l, t, i)
                {
                    s = c;
                }
                public override void Show()
                {
                    base.Show();
                    Console.WriteLine($" C: {s}");
                }
                public override void Think()
                {
                    Console.WriteLine("Pupil think");
                }
                public override void Study()
                {
                    Console.WriteLine(" pupil study");
                  
                }

            }


        



        static void Main(string[] args)
        {
            Learner[] l =
            {
                new Student("n","f",DateTime.Now,"i","g1"),
                new Pupil("n2","f2",DateTime.Now,"i2","s"),

            };
            foreach( Learner  i in l)
            {
                i.Show();
                i.Think();
                i.Study();
            }
            
        }
    }
}

