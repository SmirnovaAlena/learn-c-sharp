using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        public class Cake
        {
            public bool chocolate;
            public bool cream;
            public int k;
            public int c;
            public string client;
            public void SetCh( bool b) { chocolate = b; }
            public void SetCr(bool b) { cream = b; }
            public void SetK(int k2) { k = k2; }
            public void SetC(int k2) { c = k2; }
            public void SetClient(string a) { client = a; }

        }
        public class Builder: Cake
        {
            private Cake c = new Cake();
            public void SetCh(bool b) { chocolate = b; }
            public void SetCr(bool b) { cream = b; }
            public void SetK(int k2) { k = k2; }
            public void SetC(int k3) { c = k3; }
            public void SetClient(string a) { client = a; }
            public 

        }
        static void Main(string[] args)
        {
        }
    }
}
