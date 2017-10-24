using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aop_CastleDynamicProxy_Interceptor
{
    public class StudentInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            try
            {
                Console.WriteLine("Before");
                Console.WriteLine("Method : " + invocation.Method.ToString());
                foreach (var item in invocation.Arguments)
                {
                    Console.WriteLine("Parameters : " + item);
                }

                invocation.Proceed();
                Console.WriteLine("After Method");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception");
                throw;
            }
            finally
            {
                Console.WriteLine("Exit");
            }
        }
    }
}
