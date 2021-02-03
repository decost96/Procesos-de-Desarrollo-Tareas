using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;

namespace ClassLibrary1
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Register(Castle.MicroKernel.Registration.Component.For<ClassLibrary1.Main>());
            container.Register(Castle.MicroKernel.Registration.Component.For<ClassLibrary1.IDependency1>().ImplementedBy<ClassLibrary1.Dependency1>());
            container.Register(Castle.MicroKernel.Registration.Component.For<ClassLibrary1.IDependency2>().ImplementedBy<ClassLibrary1.Dependency2>());

            var mainThing = container.Resolve<ClassLibrary1.Main>();
            mainThing.DoSomething();

        }
    }
}
