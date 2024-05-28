using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
         abstract public class Animals
        {
            public string name{ get; set; }
      

             public Animals(string s)
            {
                name = s;
           
            }
            public virtual void Print() {

                Console.WriteLine(name);
            }
            
            

        }
        public class Tiger : Animals
        {
            public string h;
            
            public Tiger(string s) : base( s ) { h = "run"; }
            public override void Print() 
            {
                Console.WriteLine($" {name} Tiger {h}");
            }



        }
        public class Crocodile : Animals
        {
            public string h;
            public Crocodile(string s1) : base(s1){ h = "swim"; }
            public override void Print()
            {
                Console.WriteLine($" {name} Crocodile {h}");
            }

        }
        public class Kangaroo : Animals
        {
            public string h;
            public Kangaroo(string s) : base(s) { h = "jump"; }
            public override void Print()
            {
                Console.WriteLine($" {name} Kangaroo {h}");
            }


        }
        static void Main(string[] args)
        {
            Tiger t = new Tiger("t");
            t.Print();
            Crocodile c = new Crocodile("c");
            c.Print();
            Kangaroo k = new Kangaroo("k");
            k.Print();


        }
    }
}
