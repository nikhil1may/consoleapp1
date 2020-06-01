using System;
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string inputNumber = Console.ReadLine();
            //int input = Convert.ToInt32(inputNumber);
            //for(int i=1;i<=input;i++)
            //{
            //    if(i%3==0 && i%5==0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (i % 3 == 0 && i % 5 != 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (i % 5 == 0 && i % 3 != 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //A a = new A();
            B b = new B();
            b.a1();
            //C c = new C();
            //A b1 = new C();
            //A a1 = new C();
            //DrivedB b = new DrivedB();
            //b.PrintNumber();

            //DerivedClass derivedClass = new DerivedClass();
            //derivedClass.SayHi();


            //try
            //{
            //    int i = f1();
            //}
            ////catch (DivideByZeroException e1)
            //{

            //}
            //catch (Exception ex)
            //{

            //}
            //finally
            //{
            //    Console.WriteLine("fffff");
            //}

            // string c=  f2();
        }

        static int f1()
        {
            try
            {
                int val = 0;
                int i = 1 / val;
                return i;
            }
            //catch (DivideByZeroException e1)
            //{

            //}
            //catch (Exception ex)
            //{

            //}
            finally
            {
                Console.WriteLine("fffff");
            }
        }
        //static String f2()
        //{
        //    //String s1 = "42", s2;
        //    //f1(ref s1, out s2);
        //    //return s1 + s2;
        //}
    }

    class A
    {
        public A()
        {
            Console.WriteLine("Public A");
        }
        public virtual void a1()
        {
            Console.WriteLine("Public virtual A");
        }
        static A()
        {
            Console.WriteLine("static A");
        }

    }
    class B : A
    {
        public B()
        {
            Console.WriteLine("Public B");
        }
        public  void a1()
        {
            Console.WriteLine("Public virtual B");
        }
        static B()
        {
            Console.WriteLine("static B");
        }

    }
    class C : B, Interface1
    {
        public C()
        {
            Console.WriteLine("Public C");
        }
        static C()
        {
            Console.WriteLine("static C");
        }

        public void add(int a)
        {
            throw new NotImplementedException();
        }
    }

    class ParentA
    {
        public void Print(int a, int b)
        {
            Console.WriteLine($"Print {a}, {b}");
        }
        protected void Print(int a, float b)
        {
            Console.WriteLine($"Print {a}, {b}");
        }
    }
    class DrivedB : ParentA
    {
        public void PrintNumber()
        {
            ParentA p = new ParentA();
            p.Print(1, 2);
            Print(1, 2f);
        }
    }
    class BaseClass
    {
        public void SayHi()
        {
            Console.WriteLine("base");
        }
    }

    class DerivedClass : BaseClass
    {
        public new void SayHi()
        {
            Console.WriteLine("derived"); 
        }
    }

    static class newStatic
    {
        //public void tetsMethod()
        //{

        //}
    }
}
