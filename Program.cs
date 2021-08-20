using System;

namespace OpenClosedPrinciple_ex_
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service1 = new Service1();
            service1.DoService();

            Service service2 = new Service2();
            service1.DoService();

            Service service3 = new Service3();
            service3.DoService();
        }
    }
}
