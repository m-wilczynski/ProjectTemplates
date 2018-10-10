using _NAMESPACE_.Shared.Contracts.Requests;
using System;

namespace _NAMESPACE_.Shared.Contracts.Responses
{
    /// <summary>
    /// Result of system processing a request with response of <see cref="TResponse"/> 
    /// </summary>
    /// <typeparam name="TResponse">Provided response</typeparam>
    public class OperationResult<TResponse> where TResponse : IResponse<IRequest>
    {
        /// <summary>
        /// Result data - default(TResponse) if failed
        /// </summary>
        public readonly TResponse Result;

        /// <summary>
        /// Error message - if failed
        /// </summary>
        public readonly string ErrorMessage;

        /// <summary>
        /// Did operation succeed?
        /// </summary>
        public bool Successful => ErrorMessage != null;

        private OperationResult(TResponse result, string errorMessage = null)
        {
            ErrorMessage = errorMessage;

            if (Successful && result == null)
                throw new ArgumentNullException(nameof(result));

            Result = result;
        }
        
        /// <summary>
        /// Operation failed
        /// </summary>
        /// <param name="errorMessage">Error message</param>
        /// <returns></returns>
        public static OperationResult<TResponse> Failure(string errorMessage) =>
            new OperationResult<TResponse>(default(TResponse), errorMessage);

        /// <summary>
        /// Operation succeeded
        /// </summary>
        /// <param name="result">Result for user</param>
        /// <returns></returns>
        public static OperationResult<TResponse> Success(TResponse result) =>
            new OperationResult<TResponse>(result);
    }
}
