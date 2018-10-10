using _NAMESPACE_.Shared.Infrastructure.Handlers;
using Autofac;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<HandlersModule>();
            builder.RegisterType<Composite>().As<Composite>();

            var container = builder.Build();

            var composite = container.Resolve<Composite>();

            Console.WriteLine("Hello World!");
        }
    }
}
