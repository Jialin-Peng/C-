using System;

namespace ConsoleApp2
{
    class A
    {
        protected int n=1;
        
        public virtual void myMethod()
        {
            Console.WriteLine("重写前"+(n + 10));
        }
    }
    class B:A
    {
    
        public override void myMethod()
        {
            Console.WriteLine("重写后"+(n + 50));
        }
    }
    class Test
    {
        public static void Main(String[] args)
        {
            A a = new A();
            a.myMethod();
            B b = new B();
            b.myMethod();
            a.myMethod();
        }
    }
}
