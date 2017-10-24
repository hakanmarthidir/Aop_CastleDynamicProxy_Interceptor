using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aop_CastleDynamicProxy_Interceptor
{
    class Program
    {
        static void Main(string[] args)
        {
            WindsorResolve.Initialize();
            var myType = WindsorResolve.For<IStudent>();
            myType.TakeExam("Physic");

            Console.ReadKey();
        }
    }
}
