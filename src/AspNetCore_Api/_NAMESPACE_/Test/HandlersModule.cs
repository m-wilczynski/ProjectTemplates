using _NAMESPACE_.Shared.Infrastructure.Handlers;
using Autofac;

namespace Test
{
    public class HandlersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(Program).Assembly).AsClosedTypesOf(typeof(ICommandHandler<>));
            builder.RegisterAssemblyTypes(typeof(Program).Assembly).AsClosedTypesOf(typeof(ICommandHandler<,>));
            builder.RegisterAssemblyTypes(typeof(Program).Assembly).AsClosedTypesOf(typeof(IQueryHandler<,>));
        }
    }
}
