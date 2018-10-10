using _NAMESPACE_.Shared.Contracts.Responses;
using _NAMESPACE_.Shared.Infrastructure.Handlers;

namespace Test.Command_1
{
    public class CommandHandler1 : ICommandHandler<Command1, CommandResponse1>
    {
        public OperationResult<Command1, CommandResponse1> Handle(Command1 command)
        {
            throw new System.NotImplementedException();
        }
    }
}
