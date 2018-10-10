using _NAMESPACE_.Shared.Contracts.Requests;
using _NAMESPACE_.Shared.Contracts.Responses;

namespace _NAMESPACE_.Shared.Infrastructure.Handlers
{
    /// <summary>
    /// Handler responsible for give <see cref="TCommand"/>
    /// </summary>
    /// <typeparam name="TCommand">Command (to modify system) to be handled</typeparam>
    public interface ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        /// <summary>
        /// Handle command
        /// </summary>
        /// <param name="command">Command</param>
        /// <returns>Result of handling command</returns>
        OperationResult Handle(TCommand command);
    }

    /// <summary>
    /// Handler responsible for give <see cref="TCommand"/>
    /// </summary>
    /// <typeparam name="TCommand">Command (to modify system) to be handled</typeparam>
    /// <typeparam name="TResponse">Response on handling command</typeparam>
    public interface ICommandHandler<TCommand, TResponse>
        where TCommand : ICommand where TResponse : IResponse<TCommand>
    {
        /// <summary>
        /// Handle command
        /// </summary>
        /// <param name="command">Command</param>
        /// <returns>Result with corresponding <see cref="TResponse"/></returns>
        OperationResult<TCommand, TResponse> Handle(TCommand command);
    }
}
