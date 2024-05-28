using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        public abstract class Figure {
            public Figure() { }
            public virtual double S() { return 0; }
         }
        public class Rectangle:Figure
        {
            public double a;
            public double b;
            public Rectangle(double a1, double b1) { a = a1; b = b1; }
             public override double S()
            {
                return a * b;

            }
        }
        public class Circle: Figure
        {
            public double a;
            public double b;
            public Circle( double b1) { a = 3.1415926; b = b1; }
            public override double S()
            {
                return a * b*b;

            }
        }
        public class PTriangle : Figure
        {
            public double a;
            public double b;
            public PTriangle(double a1,double b1) { a =a1; b = b1; }
            public override double S()
            {
                return (a *b)/2;

            }
        }
        public class F:Figure
        {
            public double a;
            public double b;
            public F(double a1, double b1) { a = a1; b = b1; }
            public double S()
            {
                return a * b;

            }

        }
        public class A : Figure
        {
            F f;
            public A(F f1) { f = f1; }
            public override double S()
            {
                return f.S();
            }
        }
          static public List<Figure> G()
        {
            var list = new List<Figure>();
            Random r=new Random();
            for (int i=0; i<10; i++)
            {
                double a = r.Next(1, 4);
                switch (a)
                {
                    case 1:
                        list.Add(new Rectangle(r.NextDouble(), r.NextDouble()));
                        break;
                    case 2:
                        list.Add(new PTriangle(r.NextDouble(), r.NextDouble()));
                        break;
                    case 3:
                        list.Add(new Circle( r.NextDouble()));
                        break;
                    case 4:
                        list.Add(new A(new F(r.NextDouble(),r.NextDouble())));
                        break;




                }
               
            }
            return list;

        }



        static void Main(string[] args)
        {
            List <Figure> list = G();   
            foreach(Figure f in list)
            {
                
                Console.WriteLine(f.S());
            }

        }
    }
}
