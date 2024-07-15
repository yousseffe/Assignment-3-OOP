using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3OOP.Overriding
{

    internal class TypeA
    {
        public int A { get; set; }

        public TypeA( int _a)
        {
            A= _a;
        }

        public void MyFunc()
        {
            Console.WriteLine("I am Base");
        }
        public virtual void MyFunc2()
        {
            Console.WriteLine($"TypeA : A {A}");
        }

        public void print()
        {
            Console.WriteLine("hello");
        }

    }

    internal class TypeC :TypeB
    {
        public int C { get; set; }
        public TypeC(int _a , int _b ,int _c) : base(_a , _b)
        {
            C = _c;
        }
        public override void MyFunc2()
        {
            Console.WriteLine($"C = {C}");
        }


    }

    internal class TypeD :TypeC
    {
        public int D { get; set; }

        public TypeD( int _a , int _b , int _c ,int _d) : base(_a , _b ,_c)
        {
            D= _d;
        }
        public new virtual void MyFunc2()
        {
            Console.WriteLine('D');
        }


    }

    internal class TypeE : TypeD
    {
        public int E { get; set; }
        public TypeE(int _a, int _b , int _c ,int _d ,int _e):base(_a , _b ,_c , _d)
        {
            E = _e;
        }
        public override void MyFunc2()
        {
            Console.WriteLine("E");
        }
    }

}
