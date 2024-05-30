using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        interface IIndexer
        {
            string this[int index] { get;set; } 
            string this[string index] { get;  }
        }
        enum Numbers { one, teo, three, four, five };
        class IndexerClass : IIndexer
        {
            string[] name = new string[5];
            public string this[int index]
            {
                get { return name[index]; }
                set { name[index] = value; }
            }
            public string this[string index]
            {
                get
                {
                    if (Enum.IsDefined(typeof(Numbers), index))
                        return name[(int)Enum.Parse(typeof(Numbers), index)];
                    else
                        return "";
               
                }
            }
            public IndexerClass()
            {
                this[0] = "A";
                this[1] = "B";
                this[2] = "C";

                this[3] = "D";
                this[4] = "E";

            }

        }
        static void Main(string[] args)
        {
            IndexerClass i = new IndexerClass();
            Console.WriteLine("int");
            for (int j= 0; j < 5; j++)
            {
                Console.WriteLine(i[j]);
            }
            Console.WriteLine("string");
            foreach(string item in Enum.GetNames(typeof(Numbers)))
            {
                Console.WriteLine(i[item]);
            }

        }
    }
}
