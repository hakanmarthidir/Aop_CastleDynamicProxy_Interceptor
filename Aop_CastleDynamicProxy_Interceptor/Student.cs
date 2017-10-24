using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aop_CastleDynamicProxy_Interceptor
{
    public class Student : IStudent
    {
        public void TakeExam(string examName)
        {
            Console.WriteLine(string.Format("Passed successfully => {0}", examName));
        }
    }
}
