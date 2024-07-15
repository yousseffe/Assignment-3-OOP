﻿using Assignment3OOP.Binding;
using Assignment3OOP.Interface;
using Assignment3OOP.Overriding;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Assignment3OOP
{
    internal class Program
    {
        #region overLoading
        public static int sum(int x, int y)
        {
            return x + y;
        }
        public static int sum(int x, int y, int z)
        {
            return x + y;
        }
        public static int sum(int x, int y, int z, int d)
        {
            return x + y;
        } 
        #endregion

        public static void ProcessEmp(Employee emp)
        {
            if (emp is not null) {
                emp.MyFunc01();
                emp.MyFunc02();
            }
        }
        static void Main(string[] args)
        {

            #region overLoading
/*            int result = sum(1, 2 , 3 , 4 );
            Console.WriteLine(result);*/
            #endregion

            #region Overriding
/*            TypeA typeA = new TypeA(1);

            typeA.MyFunc();
            typeA.MyFunc2();
            
            TypeB typeB = new TypeB(1, 2);

            typeB.A = 3;
            typeB.B = 4;
            typeB.MyFunc();
            typeB.MyFunc2();*/
            
            #endregion

            #region Binding
/*            TypeA RefBase = new TypeB(1, 2);

            RefBase.A = 3; // valid
            RefBase.B = 4; // invalid
            RefBase.MyFunc2(); // Dynamic Binding
            RefBase.MyFunc(); // static Binding */
            #endregion

            #region  Nobinding (unsafe Casting)
            TypeA typeA = new TypeB(1 , 2); // binding
            typeA = new TypeA(1);
            TypeB typeB = (TypeB)typeA; // (unsafe) casting

            #endregion

            #region Example in binding 
            //FullTimeEmployee E2 = new FullTimeEmployee()
            //{
            //    ID = 1,
            //    Name = "Ahmed",
            //    Age = 20,
            //    Salary = 10000
            //};
            //PartTimeEmployee E3 = new PartTimeEmployee()
            //{
            //    Age = 20,
            //    HourSalary  = 20,
            //    ID = 2,
            //    Name   ="Ayman"  
            //};

            //ProcessEmp(E3); 
            #endregion

            #region Multi inhertance (part07)
            //TypeA typeA = new TypeE(1,2,3,4,5);
            //TypeB typeb = new TypeE(1,2,3,4,5);
            //TypeC typec = new TypeE(1,2,3,4,5);
            //typeA.MyFunc2(); // C
            //typeb.MyFunc2(); // C
            //typec.MyFunc2();// C
            //TypeD typeD = new TypeE(1, 2, 3, 4, 5);
            //typeD.MyFunc2(); // E

            //TypeA typeA = new TypeE(1,2,3,4,5); 
            #endregion

            #region Interface 
            //IMyType myType = new MyType();
            //myType.myFunc();
            //myType.Age = 25;
            //myType.Print(); 
            #endregion


        }
    }
}
