using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aop_CastleDynamicProxy_Interceptor
{
    //Registration
    public class WindsorRegistration : IRegistration
    {
        public void Register(IKernelInternal kernel)
        {
            kernel.Register(
                Component.For<StudentInterceptor>()
                    .ImplementedBy<StudentInterceptor>());

            kernel.Register(
                Component.For<IStudent>()
                         .ImplementedBy<Student>()
                         .Interceptors(InterceptorReference.ForType<StudentInterceptor>()).Anywhere);
        }
    }

    //Resolver
    public class WindsorResolve
    {

        private static IWindsorContainer _container;

        public static void Initialize()
        {
            _container = new WindsorContainer();
            _container.Register(new WindsorRegistration());
        }

        public static T For<T>()
        {
            return _container.Resolve<T>();
        }
    }

}
