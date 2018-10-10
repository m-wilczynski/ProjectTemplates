using _NAMESPACE_.Shared.Contracts.Requests;

namespace _NAMESPACE_.Shared.Contracts.Responses
{
    /// <summary>
    /// System response to exact request <see cref="TRequest"/>
    /// </summary>
    /// <typeparam name="TRequest">Request to which response has been produced by the system</typeparam>
    public interface IResponse<TRequest> where TRequest : IRequest
    {
    }
}
