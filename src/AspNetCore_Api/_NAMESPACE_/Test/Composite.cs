using _NAMESPACE_.Shared.Infrastructure.Handlers;
using Test.Command_1;
using Test.Command_2;
using Test.Query_1;

namespace Test
{
    public class Composite
    {
        public Composite(
            IQueryHandler<Query1, QueryResponse1> query1,
            ICommandHandler<Command1, CommandResponse1> command1,
            ICommandHandler<Command2> command2)
        {
            Query1 = query1;
            Command1 = command1;
            Command2 = command2;
        }

        public IQueryHandler<Query1, QueryResponse1> Query1 { get; }
        public ICommandHandler<Command1, CommandResponse1> Command1 { get; }
        public ICommandHandler<Command2> Command2 { get; }
    }
}
