using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Credit_card
    {
        public string number { get; set; }
        public string cvv { get; set; }
        public string date { get; set; }
        public double balance { get; set; }
        public Credit_card(string n,string c,string d,double b) {
            number = n;
            cvv = c;    
            date = d;
            balance = b;

        }
        public static double operator-(Credit_card c1, double s)
        {
            return c1.balance -s;
        }
        public static double operator +(Credit_card c1, double s)
        {
            return c1.balance + s;
        }
        
        
        public static bool operator >(Credit_card c1, Credit_card c2)
        {
            return c1.balance> c2.balance;
        }
        public static bool operator <(Credit_card c1, Credit_card c2)
        {
            return c1.balance < c2.balance;
        }
        public override bool Equals(object obj)
        {
            Credit_card other = obj as Credit_card;
            return this.cvv==other.cvv;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(Credit_card c1, Credit_card c2)
        {
            return c1.Equals(c2);
        }
        public static bool operator !=(Credit_card c1, Credit_card c2)
        {
            return !(c1.cvv == c2.cvv);
        }
        public void Print()
        {
            Console.WriteLine("C:"+cvv.ToString());
            Console.WriteLine("balance:"+balance.ToString());
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Credit_card c = new Credit_card ( "123456789", "123", "05/21", 70000 );
            Credit_card c2 = new Credit_card("1112131415", "124", "06/21", 30000);
            Console.WriteLine("- 500");
            c.balance = c.balance - 500.00;
            c.Print();
            Console.WriteLine("+ 500");
            c2.balance = c2.balance + 500.00;
            c2.Print();
           
            Console.WriteLine("==");
            Console.WriteLine(c == c2);
          
            Console.WriteLine("!=");
            Console.WriteLine(c != c2);
            Console.WriteLine(" 1>2");
            Console.WriteLine(c > c2);
            Console.WriteLine("1<2");
            Console.WriteLine(c < c2);




        }
    }
}
