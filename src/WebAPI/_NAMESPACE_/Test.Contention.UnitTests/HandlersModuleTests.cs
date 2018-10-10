using _NAMESPACE_.Shared.Infrastructure.Handlers;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Test.Convention.UnitTests
{
    
    public class HandlersModuleTests
    {
        [Fact]
        public void HandlersModule_Load_ShouldNotAllow_TResponse_ToBeReturnedByMoreThanOneHandler()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<HandlersModule>();

            var container = builder.Build();

            var queryHandlers = container.ComponentRegistry.Registrations
                .Where(r => typeof(IQueryHandler).IsAssignableFrom(r.Activator.LimitType))
                .Select(r => container.Resolve(r.Activator.LimitType) as IQueryHandler);

            var commandHandlers = container.ComponentRegistry.Registrations
                .Where(r => typeof(ICommandHandler).IsAssignableFrom(r.Activator.LimitType))
                .Select(r => container.Resolve(r.Activator.LimitType) as ICommandHandler);

            var responsesCounter = new Dictionary<Type, int>();

            foreach (var handler in queryHandlers.Select(qh => qh.GetType().GetInterfaces()
                .Where(type => type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IQueryHandler<,>)))
                .SelectMany(type => type))
            {
                var responseType = handler.GetGenericArguments()[1];
                if (!responsesCounter.ContainsKey(responseType))
                {
                    responsesCounter.Add(responseType, 0);
                }
                responsesCounter[responseType]++;
            }

            foreach (var handler in commandHandlers.Select(qh => qh.GetType().GetInterfaces()
                .Where(type => type.IsGenericType && type.GetGenericTypeDefinition() == typeof(ICommandHandler<,>)))
                .SelectMany(type => type))
            {
                var responseType = handler.GetGenericArguments()[1];
                if (!responsesCounter.ContainsKey(responseType))
                {
                    responsesCounter.Add(responseType, 0);
                }
                responsesCounter[responseType]++;
            }

            foreach (var responseCount in responsesCounter)
            {
                Assert.True(1 == responseCount.Value, $"{responseCount.Key.FullName} is used by more than one handler (count: {responseCount.Value})");
            }
        }
    }
}
