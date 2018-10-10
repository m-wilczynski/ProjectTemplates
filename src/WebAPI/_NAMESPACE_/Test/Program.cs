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

            builder.RegisterAssemblyTypes(typeof(Program).Assembly).AsClosedTypesOf(typeof(ICommandHandler<>));
            builder.RegisterAssemblyTypes(typeof(Program).Assembly).AsClosedTypesOf(typeof(ICommandHandler<,>));
            builder.RegisterAssemblyTypes(typeof(Program).Assembly).AsClosedTypesOf(typeof(IQueryHandler<,>));

            builder.RegisterType<Composite>().As<Composite>();

            var container = builder.Build();

            var composite = container.Resolve<Composite>();

            Console.WriteLine("Hello World!");
        }
    }
}
